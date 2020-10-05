using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adatbevitel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1_Rendszám.Text.Trim()))
            {
                MessageBox.Show("Nem töltötte ki a rendszám mezőt!","Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1_Rendszám.Focus();
            }
            Autok autok = new Autok(textBox1_Rendszám.Text.Trim(), (int)numericUpDown1.Value, comboBox1_Típus.SelectedIndex.ToString(), textBox2_Gyártmány.Text.Trim());
            listBox_Autok.Items.Add(textBox1_Rendszám.Text);
        }

        private void ListBox_Autok_SelectedIndexChanged(object sender, EventArgs e)
        {
            Autok autok = (Autok)listBox_Autok.Items[listBox_Autok.SelectedIndex];
            textBox1_Rendszám.Text = autok.Rendszám;
            numericUpDown1.Value = autok.Teljesítmény;
            comboBox1_Típus.Text = autok.Típus;
            textBox2_Gyártmány.Text = autok.Gyártmány;
        }
    }
}
