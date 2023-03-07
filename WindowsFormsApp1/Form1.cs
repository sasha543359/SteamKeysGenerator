using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        const string symbols = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        string SteamKey = string.Empty;

        Random random = new Random();
        
       string GenerateKeyPart()
        {
          
            string keyPart = string.Empty;

            for (int i = 0; i < 5; i++)
            {
                keyPart += symbols[random.Next(0, symbols.Length)];
            }

            return keyPart;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.ScrollBars = ScrollBars.Vertical;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SteamKey = string.Empty;

            if (checkBox1.Checked == false && checkBox2.Checked == false)
                MessageBox.Show("Выбери хотябы один тип ключа");
               

            if (checkBox1.Checked == true && checkBox2.Checked != true)
                    for (int i = 1; i <= numericUpDown1.Value ; i++)
                    {
                    SteamKey += $"{i}. {GenerateKeyPart()}-{GenerateKeyPart()}-{GenerateKeyPart()}\r\n";
                    textBox1.Text = SteamKey;
                    }

          else if (checkBox2.Checked == true && checkBox1.Checked != true)
                    for (int i = 1; i <= numericUpDown1.Value; i++)
                    {
                    SteamKey += $"{i}. {GenerateKeyPart()}-{GenerateKeyPart()}-{GenerateKeyPart()}-{GenerateKeyPart()}-{GenerateKeyPart()}\r\n";
                    textBox1.Text = SteamKey;
                    }
         
           



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
