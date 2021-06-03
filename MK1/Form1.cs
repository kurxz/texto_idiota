using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Texto_Idiota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            string textoOut = "";
            int x = 0;

            char[] ch = texto.ToCharArray();

            foreach (char c in ch)
            {
                if (c == ' ')
                {

                   textoOut += c;

                } else {
                        switch (x)
                        {
                            case 0:

                                textoOut += Char.ToUpper(c);
                                x = 1;

                                break;

                            case 1:

                                textoOut += Char.ToLower(c);
                                x = 0;

                                break;

                            default:

                                break;

                        }
                }
            }

            textBox2.Text = textoOut;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/kurxz/texto_idiota");
        }
    }
}
