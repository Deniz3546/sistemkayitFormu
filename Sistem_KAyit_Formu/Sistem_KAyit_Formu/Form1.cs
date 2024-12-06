using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistem_KAyit_Formu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Ad:" + textBox1.Text + " Soyad: " + textBox2.Text + " TC NO: " + maskedTextBox1.Text.ToString() + " Saat: " + maskedTextBox2.Text.ToString() + " Tarih:" + dateTimePicker1.Text.ToString() + " Cinsiyet: " + comboBox1.Text.ToString());

        }
    }
}
