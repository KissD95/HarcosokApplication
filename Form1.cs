using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HarcosokApplication
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = null;
        MySqlCommand sql = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //------------------------KAPCSOLAT LÉREHOZÁSA-----------------------------------------------
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "cs_harcosok";
            sb.CharacterSet = "utf8";
            conn = new MySqlConnection(sb.ToString());

            try
            {
                conn.Open();
                sql = conn.CreateCommand();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            HarcosokListaUpdate();
          
            
        }

        private void HarcosokListaUpdate()
        {
            harcosokListBox.Items.Clear();
            hasznaloComboBox.Items.Clear();
            sql.CommandText = "SELECT `id`,`nev`,`letrehozas` FROM `harcosok` WHERE 1";
            using (MySqlDataReader dr = sql.ExecuteReader())
            {
                while (dr.Read())
                {
                    harcosokListBox.Items.Add(new Harcos(dr.GetInt32("id"),dr.GetString("nev"),dr.GetString("letrehozas")));
                    hasznaloComboBox.Items.Add(dr.GetString("nev"));
                }
            }
        }


        //-------------------HARCOS LÉTREHOZÁSA--------------------------------------------------------------------------------------------------------------------------------------
        private void LetrehozButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(harcosNeveTextBox.Text)) { 
                sql.CommandText = "INSERT INTO harcosok (nev,letrehozas) VALUES ('" + harcosNeveTextBox.Text.Trim() + "','"+DateTime.Now.ToString("MM/dd/yyyy") +"')";
                try
                {
                    if (sql.ExecuteNonQuery() == 1)
                    {
                        harcosNeveTextBox.Text = "";
                        MessageBox.Show("Harcos sikeresen felvéve!");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }else
            {
                MessageBox.Show("Harcos létrehozásához töltse ki a név mezőt!");
            }
            HarcosokListaUpdate();
        }
        //-----------------KÉPESSÉG HOZZÁADÁSA--------------------------------------------------------------------------
        private void HozzaadButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(kepessegNeveTextBox.Text) || !string.IsNullOrWhiteSpace(leirasTextBox.Text))
            {
                sql.CommandText = "INSERT INTO kepessegek (nev,leiras,harcos_id) VALUES ('"+kepessegNeveTextBox.Text.Trim()+"','"+leirasTextBox.Text+"',(SELECT id FROM harcosok WHERE nev='"+hasznaloComboBox.SelectedItem+"'))";
                try
                {
                    if (sql.ExecuteNonQuery() == 1)
                    {
                        kepessegNeveTextBox.Text = "";
                        leirasTextBox.Text = "";
                        MessageBox.Show("Képesség sikeresen hozzáadva");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Kötelező kitölteni a név és a leírás mezőket!");
            }
        }

        private void HarcosokListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Harcos kiv = (Harcos)harcosokListBox.SelectedItem;
            
            sql.CommandText = "SELECT 'nev','leiras' FROM kepessegek WHERE harcos_id='" + kiv.Id + "'";
            using (MySqlDataReader dr = sql.ExecuteReader())
            {
                while (dr.Read())
                {
                    kepessegekListBox.Items.Add(kiv.Id);
                }
            }
        }
    }
}
