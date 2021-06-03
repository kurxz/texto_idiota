using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;

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
            label1.Visible = false;
            label2.Visible = false;
            label4.Visible = false;

            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            button1.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label3.Visible = false;
            button1.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Inverter()
        {
            string textoOut = "";

            string texto = textBox1.Text;
            char[] inv = texto.ToCharArray();

            Array.Reverse(inv);

            for (int i = 0; i <= inv.Length - 1; i++)
            {
                textoOut += inv.GetValue(i);
            }

            textBox3.Text = textoOut;
        }

        private void processarTexto()
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

                }
                else
                {
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

        private void Riscado()
        {

            string texto = textBox1.Text;
			
            string textoOut = " ̶";

            char[] ch = texto.ToCharArray();

            foreach (char c in ch)
            {
                if (c == ' ')
                {

                }

                textoOut += " ̶" + c + " ̶";
            }
            textBox4.Text = textoOut.Replace(" ", ""); ;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            processarTexto();
            Inverter();
            Riscado();

            label3.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label4.Visible = true;

            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/kurxz/texto_idiota");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click_1(this, new EventArgs());
            }
        }
    }
}
