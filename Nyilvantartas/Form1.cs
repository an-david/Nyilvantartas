using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nyilvantartas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Rendszam.Text))
            {
                MessageBox.Show("Rendszám mező kitöltése kötelező!", "Hiányzó Adat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Rendszam.Focus();
            }
            else if (String.IsNullOrEmpty(comboBox_Tipus.Text) || comboBox_Tipus.Text.Equals("Válasszon"))
            {
                MessageBox.Show("Tipus választása kötelező!", "Hiányzó Adat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox_Tipus.Focus();
            }
            else if (String.IsNullOrEmpty(textBox_Gyartmany.Text))
            {
                MessageBox.Show("Gyártmány mező kitöltése kötelező!", "Hiányzó Adat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Gyartmany.Focus();
            }
            else if (String.IsNullOrEmpty(textBox_Teljesitmeny.Text))
            {
                MessageBox.Show("Teljesitmény mező kitöltése kötelező!", "Hiányzó Adat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Teljesitmeny.Focus();
            }
            else
            {
                Gepjarmu ujJarmu = new Gepjarmu(textBox_Rendszam.Text, comboBox_Tipus.Text, textBox_Gyartmany.Text, textBox_Teljesitmeny.Text);
                listBox_OsszesJarmu.Items.Add(ujJarmu);

                textBox_Rendszam.Clear();
                comboBox_Tipus.Text = "Válasszon";
                textBox_Gyartmany.Clear();
                textBox_Teljesitmeny.Clear();
            }
        }

        private void listBox_OsszesJarmu_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gepjarmu kivalasztottJarmu = (Gepjarmu)listBox_OsszesJarmu.Items[listBox_OsszesJarmu.SelectedIndex];
            textBox_Rendszam.Text = kivalasztottJarmu.Rendszam;
            comboBox_Tipus.Text = kivalasztottJarmu.Tipus;
            textBox_Gyartmany.Text = kivalasztottJarmu.Gyartmany;
            textBox_Teljesitmeny.Text = kivalasztottJarmu.Teljesitmeny;
        }
    }
}
