using System;
using System.Windows.Forms;

namespace FormComplejos_G2_2024_1
{
    public partial class Form1 : Form
    {
        Complejo c1;
        Complejo c2;
        Complejo c3;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            c1 = new Complejo(float.Parse(txtbReal1.Text), float.Parse(txtbImaginario1.Text));
            c2 = new Complejo(float.Parse(txtbReal2.Text), float.Parse(txtbImaginario2.Text));

            c3 = c1 + c2;

            lbSuma.Text = c3.ToString();
        }
        private void btnRestar_Click(object sender, EventArgs e)
        {
            c1 = new Complejo(float.Parse(txtbReal1.Text), float.Parse(txtbImaginario1.Text));
            c2 = new Complejo(float.Parse(txtbReal2.Text), float.Parse(txtbImaginario2.Text));

            c3 = c1 - c2;

            lbSimbolo.Text = "-";
            lbSuma.Text = c3.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            c1 = new Complejo(float.Parse(txtbReal1.Text), float.Parse(txtbImaginario1.Text));
            c2 = new Complejo(float.Parse(txtbReal2.Text), float.Parse(txtbImaginario2.Text));

            c3 = c1 * c2;

            lbSimbolo.Text = "*";
            lbSuma.Text = c3.ToString();
        }

        private void btnConjugar_Click(object sender, EventArgs e)
        {
            c3 = ~c3;
            lbSuma.Text = (c3).ToString(); 
        }

        
    }
}
