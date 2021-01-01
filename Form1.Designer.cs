namespace HarcosokApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.letrehozButton = new System.Windows.Forms.Button();
            this.harcosNeveTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hozzaadButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.leirasTextBox = new System.Windows.Forms.TextBox();
            this.kepessegNeveTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hasznaloComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.harcosokListBox = new System.Windows.Forms.ListBox();
            this.kepessegekListBox = new System.Windows.Forms.ListBox();
            this.modositButton = new System.Windows.Forms.Button();
            this.torlesButton = new System.Windows.Forms.Button();
            this.kepessegLeirasTextBox = new System.Windows.Forms.TextBox();
            this.harcosTorlesButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.letrehozButton);
            this.groupBox1.Controls.Add(this.harcosNeveTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Harcos létrehozása";
            // 
            // letrehozButton
            // 
            this.letrehozButton.Location = new System.Drawing.Point(253, 27);
            this.letrehozButton.Name = "letrehozButton";
            this.letrehozButton.Size = new System.Drawing.Size(100, 30);
            this.letrehozButton.TabIndex = 2;
            this.letrehozButton.Text = "Létrehozás";
            this.letrehozButton.UseVisualStyleBackColor = true;
            this.letrehozButton.Click += new System.EventHandler(this.LetrehozButton_Click);
            // 
            // harcosNeveTextBox
            // 
            this.harcosNeveTextBox.Location = new System.Drawing.Point(51, 31);
            this.harcosNeveTextBox.Name = "harcosNeveTextBox";
            this.harcosNeveTextBox.Size = new System.Drawing.Size(179, 22);
            this.harcosNeveTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hozzaadButton);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.leirasTextBox);
            this.groupBox2.Controls.Add(this.kepessegNeveTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.hasznaloComboBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(774, 136);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Képesség hozzáadása";
            // 
            // hozzaadButton
            // 
            this.hozzaadButton.Location = new System.Drawing.Point(13, 99);
            this.hozzaadButton.Name = "hozzaadButton";
            this.hozzaadButton.Size = new System.Drawing.Size(217, 23);
            this.hozzaadButton.TabIndex = 6;
            this.hozzaadButton.Text = "Hozzáadás";
            this.hozzaadButton.UseVisualStyleBackColor = true;
            this.hozzaadButton.Click += new System.EventHandler(this.HozzaadButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Leírás";
            // 
            // leirasTextBox
            // 
            this.leirasTextBox.Location = new System.Drawing.Point(356, 30);
            this.leirasTextBox.Multiline = true;
            this.leirasTextBox.Name = "leirasTextBox";
            this.leirasTextBox.Size = new System.Drawing.Size(392, 54);
            this.leirasTextBox.TabIndex = 4;
            // 
            // kepessegNeveTextBox
            // 
            this.kepessegNeveTextBox.Location = new System.Drawing.Point(85, 62);
            this.kepessegNeveTextBox.Name = "kepessegNeveTextBox";
            this.kepessegNeveTextBox.Size = new System.Drawing.Size(145, 22);
            this.kepessegNeveTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Név:";
            // 
            // hasznaloComboBox
            // 
            this.hasznaloComboBox.FormattingEnabled = true;
            this.hasznaloComboBox.Location = new System.Drawing.Point(85, 30);
            this.hasznaloComboBox.Name = "hasznaloComboBox";
            this.hasznaloComboBox.Size = new System.Drawing.Size(145, 24);
            this.hasznaloComboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Használó:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Harcosok:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Képességek:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(457, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Képességek leírása:";
            // 
            // harcosokListBox
            // 
            this.harcosokListBox.FormattingEnabled = true;
            this.harcosokListBox.ItemHeight = 16;
            this.harcosokListBox.Location = new System.Drawing.Point(23, 281);
            this.harcosokListBox.Name = "harcosokListBox";
            this.harcosokListBox.Size = new System.Drawing.Size(220, 228);
            this.harcosokListBox.TabIndex = 5;
            
            // 
            // kepessegekListBox
            // 
            this.kepessegekListBox.FormattingEnabled = true;
            this.kepessegekListBox.ItemHeight = 16;
            this.kepessegekListBox.Location = new System.Drawing.Point(251, 280);
            this.kepessegekListBox.Name = "kepessegekListBox";
            this.kepessegekListBox.Size = new System.Drawing.Size(158, 228);
            this.kepessegekListBox.TabIndex = 6;
            // 
            // modositButton
            // 
            this.modositButton.Location = new System.Drawing.Point(686, 403);
            this.modositButton.Name = "modositButton";
            this.modositButton.Size = new System.Drawing.Size(75, 23);
            this.modositButton.TabIndex = 8;
            this.modositButton.Text = "Módósít";
            this.modositButton.UseVisualStyleBackColor = true;
            // 
            // torlesButton
            // 
            this.torlesButton.Location = new System.Drawing.Point(251, 514);
            this.torlesButton.Name = "torlesButton";
            this.torlesButton.Size = new System.Drawing.Size(75, 23);
            this.torlesButton.TabIndex = 9;
            this.torlesButton.Text = "Törlés";
            this.torlesButton.UseVisualStyleBackColor = true;
            // 
            // kepessegLeirasTextBox
            // 
            this.kepessegLeirasTextBox.Location = new System.Drawing.Point(460, 281);
            this.kepessegLeirasTextBox.Multiline = true;
            this.kepessegLeirasTextBox.Name = "kepessegLeirasTextBox";
            this.kepessegLeirasTextBox.Size = new System.Drawing.Size(301, 116);
            this.kepessegLeirasTextBox.TabIndex = 10;
            // 
            // harcosTorlesButton
            // 
            this.harcosTorlesButton.Location = new System.Drawing.Point(23, 515);
            this.harcosTorlesButton.Name = "harcosTorlesButton";
            this.harcosTorlesButton.Size = new System.Drawing.Size(75, 23);
            this.harcosTorlesButton.TabIndex = 11;
            this.harcosTorlesButton.Text = "Törlés";
            this.harcosTorlesButton.UseVisualStyleBackColor = true;
            this.harcosTorlesButton.Click += new System.EventHandler(this.HarcosTorlesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 556);
            this.Controls.Add(this.harcosTorlesButton);
            this.Controls.Add(this.kepessegLeirasTextBox);
            this.Controls.Add(this.torlesButton);
            this.Controls.Add(this.modositButton);
            this.Controls.Add(this.kepessegekListBox);
            this.Controls.Add(this.harcosokListBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button letrehozButton;
        private System.Windows.Forms.TextBox harcosNeveTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button hozzaadButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox leirasTextBox;
        private System.Windows.Forms.TextBox kepessegNeveTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox hasznaloComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox harcosokListBox;
        private System.Windows.Forms.ListBox kepessegekListBox;
        private System.Windows.Forms.Button modositButton;
        private System.Windows.Forms.Button torlesButton;
        private System.Windows.Forms.TextBox kepessegLeirasTextBox;
        private System.Windows.Forms.Button harcosTorlesButton;
    }
}

