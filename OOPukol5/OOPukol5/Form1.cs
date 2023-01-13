using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPukol5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Zamestnanec lojza;
        Vedouci pepa;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lojza = new Zamestnanec(textBox1.Text,textBox2.Text,dateTimePicker1.Value,(int)numericUpDown1.Value);
            label1.Text = lojza.Vypis();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pepa = new Vedouci(textBox1.Text, textBox2.Text, dateTimePicker1.Value, (int)numericUpDown1.Value, (int)numericUpDown2.Value, textBox3.Text);
            label1.Text = pepa.Vypis();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                lojza.OdpracjHodiny((int)numericUpDown3.Value);
                label1.Text = lojza.Vypis();
            }
            if (radioButton2.Checked == true)
            {
                pepa.OdpracjHodiny((int)numericUpDown3.Value);
                label1.Text = pepa.Vypis();
            }

        }
    }
}
