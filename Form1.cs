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
            //------------------------------------------------KAPCSOLAT LÉREHOZÁSA-----------------------------------------------

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

            TablakLetrehozasa();
            HarcosokListaUpdate();
          
            
        }
        //--------------------------TÁBLÁK LÉTREHOZÁSA-----------------------------------------------------------------
        private void TablakLetrehozasa()
        {
            sql.CommandText = @"CREATE TABLE IF NOT EXISTS harcosok(" +
                "id INTEGER PRIMARY KEY AUTO_INCREMENT, " +
                "nev VARCHAR(32) NOT NULL, " +
                "letrehozas VARCHAR(32) NOT NULL" +
                ")";
            sql.ExecuteNonQuery();

            sql.CommandText = @"CREATE TABLE IF NOT EXISTS kepessegek(" +
                "id INTEGER PRIMARY KEY AUTO_INCREMENT NOT NULL, " +
                "nev VARCHAR(32) NOT NULL, " +
                "leiras VARCHAR(128) NOT NULL, " +
                "harcos_id INTEGER NOT NULL" +
                ")";
            sql.ExecuteNonQuery();

            sql.CommandText = @"ALTER TABLE kepessegek
                ADD FOREIGN KEY (harcos_id)
                REFERENCES harcosok(id)";
            sql.ExecuteNonQuery();

        }

        //--------------------------------------Harcos Combobox és Listbox frissítése---------------------------------------------
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


        //----------------------------------------------------------HARCOS LÉTREHOZÁSA---------------------------------------------------------------------------------
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
        //-----------------KÉPESSÉG HOZZÁADÁSA--------------------------------------------------------------------------------------------------
        private void HozzaadButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(kepessegNeveTextBox.Text) && !string.IsNullOrWhiteSpace(leirasTextBox.Text) || hasznaloComboBox.SelectedIndex>0)
            {
                sql.CommandText = "INSERT INTO kepessegek (nev,leiras,harcos_id) VALUES ('"+kepessegNeveTextBox.Text.Trim()+"','"+leirasTextBox.Text+"',(SELECT id FROM harcosok WHERE nev='"+hasznaloComboBox.SelectedItem+"'))";
                try
                {

                    if (sql.ExecuteNonQuery() == 1)
                    {
                        KepessegListaUpdate();
                        kepessegNeveTextBox.Text = "";
                        leirasTextBox.Text = "";
                        MessageBox.Show("Képesség sikeresen hozzáadva");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Válasszon ki melyik harcoshoz kíván hozzáadni!");
                }
            }
            else if(string.IsNullOrWhiteSpace(kepessegNeveTextBox.Text))
            {
                MessageBox.Show("Kötelező megadni képesség nevet!");
            }else if(string.IsNullOrWhiteSpace(kepessegLeirasTextBox.Text))
            {
                MessageBox.Show("Kőtelező képesség leírást megadni!");
            }
        }


    
        //------------------------- képességek listázása harcosra kattintva-------------------------------------------------------------------------
        private void KepessegListaUpdate()
        {

            kepessegekListBox.Items.Clear();
            kepessegLeirasTextBox.Text = "";
            Harcos kiv = (Harcos)harcosokListBox.SelectedItem;
            sql.CommandText = "SELECT `id`,`nev`,`leiras`,`harcos_id` FROM `kepessegek` WHERE harcos_id='" + kiv.Id + "'";
            using (MySqlDataReader dr = sql.ExecuteReader())
            {
                while (dr.Read())
                {
                    kepessegekListBox.Items.Add(new Kepesseg(dr.GetInt32("id"), dr.GetString("nev"), dr.GetString("leiras"), dr.GetInt32("harcos_id")));

                }
            }
        }

        private void HarcosokListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (harcosokListBox.SelectedIndex < 0)
            {
                MessageBox.Show("Harcosra kattintson!");
            }else
            {
                KepessegListaUpdate();
            }
           

        }
        //-----------------------------------------Képessége leírás megejelnítés képességre kattintva-----------------------------------------------
        private void KepessegekListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kepessegekListBox.SelectedIndex < 0)
            {
                MessageBox.Show("Képességre kattintson!");
            }else
            {
                Kepesseg kep = (Kepesseg)kepessegekListBox.SelectedItem;
                kepessegLeirasTextBox.Text = kep.Leiras;
            }
           
        }
        //--------------------------KÉPESSÉG TÖRLÉSE---------------------------------------------------------------------
        private void TorlesButton_Click(object sender, EventArgs e)
        {
            if (kepessegekListBox.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztva képesség!");
                return;
            }
            Kepesseg kivKep = (Kepesseg)kepessegekListBox.SelectedItem;
            sql.CommandText = "delete from kepessegek where id=" +kivKep.Id ;
            if (sql.ExecuteNonQuery() == 1)
            {
                KepessegListaUpdate();
                MessageBox.Show("Sikeres törlés");
            }
            else
            {
                MessageBox.Show("A törlés sikertelen!");
            }
            
        }
        //----------------------------------------------KÉPESSÉG LEÍRÁS MÓDOSÍTÁSA-------------------------------------------------------------------
        private void ModositButton_Click(object sender, EventArgs e)
        {
            Kepesseg kivKep = (Kepesseg)kepessegekListBox.SelectedItem;
            if (kepessegekListBox.SelectedIndex < 0)
            {
                MessageBox.Show("Válasszon ki egy képességet a módosításhoz!");
            }else
            {
                sql.CommandText = "UPDATE kepessegek SET leiras='" + kepessegLeirasTextBox.Text + "' WHERE id=" + kivKep.Id;
                if (sql.ExecuteNonQuery() == 1)
                {

                    MessageBox.Show("Módosítás sikeres");
                }
                else
                {
                    MessageBox.Show("A módosítás sikertelen");
                }
            }
            
        }

        private void HarcosTorlesButton_Click(object sender, EventArgs e)
        {
            if (harcosokListBox.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztva harcos!");
                return;
            }
            Harcos kivKep = (Harcos)harcosokListBox.SelectedItem;
            sql.CommandText = "delete from harcosok where id=" + kivKep.Id;
            if (sql.ExecuteNonQuery() == 1)
            {
                HarcosokListaUpdate();
                MessageBox.Show("Sikeres törlés");
            }
            else
            {
                MessageBox.Show("A törlés sikertelen!");
            }
        }
    }
}
