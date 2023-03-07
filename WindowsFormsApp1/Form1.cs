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

        public string GenerateKeyPart()
        {
            Random random = new Random();
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(GenerateKeyPart());

          

        }
    }
}
