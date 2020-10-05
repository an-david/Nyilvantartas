namespace Nyilvantartas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Rendszam = new System.Windows.Forms.TextBox();
            this.textBox_Gyartmany = new System.Windows.Forms.TextBox();
            this.comboBox_Tipus = new System.Windows.Forms.ComboBox();
            this.textBox_Teljesitmeny = new System.Windows.Forms.TextBox();
            this.listBox_OsszesJarmu = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(173, 376);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Rögzités";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(228, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gépjármű Nyilvántartás";
            // 
            // textBox_Rendszam
            // 
            this.textBox_Rendszam.Location = new System.Drawing.Point(159, 138);
            this.textBox_Rendszam.Name = "textBox_Rendszam";
            this.textBox_Rendszam.Size = new System.Drawing.Size(140, 26);
            this.textBox_Rendszam.TabIndex = 2;
            // 
            // textBox_Gyartmany
            // 
            this.textBox_Gyartmany.Location = new System.Drawing.Point(159, 238);
            this.textBox_Gyartmany.Name = "textBox_Gyartmany";
            this.textBox_Gyartmany.Size = new System.Drawing.Size(140, 26);
            this.textBox_Gyartmany.TabIndex = 3;
            // 
            // comboBox_Tipus
            // 
            this.comboBox_Tipus.FormattingEnabled = true;
            this.comboBox_Tipus.Items.AddRange(new object[] {
            "ALFA-ROMEO",
            "AUDI",
            "BENTLEY",
            "BMW",
            "BUICK",
            "CADILLAC",
            "CHEVROLET",
            "CHRYSLER",
            "CITROEN",
            "DACIA",
            "DAEWOO",
            "DAIHATSU",
            "DODGE",
            "FERRARI",
            "FIAT",
            "FORD",
            "HONDA",
            "HUMMER",
            "HYUNDAI",
            "ISUZU",
            "IVECO",
            "JAGUAR",
            "JEEP",
            "KIA",
            "LADA",
            "LANCIA",
            "LEXUS",
            "LOTUS",
            "MAHINDRA",
            "MASERATI",
            "MAZDA",
            "MERCEDES",
            "MOSZKVICS",
            "MG",
            "MITSUBISHI",
            "NISSAN",
            "OPEL",
            "PEUGEOT",
            "PONTIAC",
            "PORSCHE",
            "PROTON",
            "RENAULT",
            "ROVER",
            "SAAB",
            "SCANIA",
            "SEAT",
            "SKODA",
            "SMART",
            "SSANGYONG",
            "SUBARU",
            "SUZUKI",
            "TOYOTA",
            "TRABANT",
            "VOLKSWAGEN",
            "VOLVO",
            "WARTBURG"});
            this.comboBox_Tipus.Location = new System.Drawing.Point(159, 185);
            this.comboBox_Tipus.Name = "comboBox_Tipus";
            this.comboBox_Tipus.Size = new System.Drawing.Size(140, 28);
            this.comboBox_Tipus.TabIndex = 4;
            this.comboBox_Tipus.Text = "Válasszon";
            // 
            // textBox_Teljesitmeny
            // 
            this.textBox_Teljesitmeny.Location = new System.Drawing.Point(159, 294);
            this.textBox_Teljesitmeny.Name = "textBox_Teljesitmeny";
            this.textBox_Teljesitmeny.Size = new System.Drawing.Size(140, 26);
            this.textBox_Teljesitmeny.TabIndex = 5;
            // 
            // listBox_OsszesJarmu
            // 
            this.listBox_OsszesJarmu.FormattingEnabled = true;
            this.listBox_OsszesJarmu.ItemHeight = 20;
            this.listBox_OsszesJarmu.Location = new System.Drawing.Point(456, 138);
            this.listBox_OsszesJarmu.Name = "listBox_OsszesJarmu";
            this.listBox_OsszesJarmu.Size = new System.Drawing.Size(247, 184);
            this.listBox_OsszesJarmu.TabIndex = 6;
            this.listBox_OsszesJarmu.SelectedIndexChanged += new System.EventHandler(this.listBox_OsszesJarmu_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Rendszám:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Típus:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gyártmány:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Teljesitmény:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Gépjármű Adatok:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(493, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nyilvántartott Járművek:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(788, 438);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox_OsszesJarmu);
            this.Controls.Add(this.textBox_Teljesitmeny);
            this.Controls.Add(this.comboBox_Tipus);
            this.Controls.Add(this.textBox_Gyartmany);
            this.Controls.Add(this.textBox_Rendszam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Gépjármű Nyilvántartás";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Rendszam;
        private System.Windows.Forms.TextBox textBox_Gyartmany;
        private System.Windows.Forms.ComboBox comboBox_Tipus;
        private System.Windows.Forms.TextBox textBox_Teljesitmeny;
        private System.Windows.Forms.ListBox listBox_OsszesJarmu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

