using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Zamestnanec zamestnanec;
        Vedouci vedouci;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown3.Enabled = true;
            try
            {
                zamestnanec = new Zamestnanec(textBox1.Text, textBox2.Text, dateTimePicker1.Value, (int)numericUpDown1.Value);
            }
            catch
            {
                MessageBox.Show("Chyba");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown3.Enabled = true;
            try
            {
                vedouci = new Vedouci(textBox1.Text, textBox2.Text, dateTimePicker1.Value, (int)numericUpDown1.Value, (int)numericUpDown2.Value, textBox3.Text);
            }
            catch
            {
                MessageBox.Show("Chyba");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                try
                {
                    zamestnanec.OdpracujHodiny((int)numericUpDown3.Value);
                    MessageBox.Show(zamestnanec.Vypis());
                }
                catch
                {
                    MessageBox.Show("Chyba");
                }
            }
            else if (radioButton2.Checked)
            {
                try
                {
                    vedouci.OdpracujHodiny((int)numericUpDown3.Value);
                    MessageBox.Show(vedouci.Vypis());
                }
                catch
                {
                    MessageBox.Show("Chyba");
                }
            }
            else
                MessageBox.Show("Chyba");
        }
    }
}

