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
            try
            {
                
                if (txtbReal1.Text == "")
                {
                    throw new ApplicationException("La parte real del complejo uno no debe estar vacía");
                }
                else
                {
                    errorProvider1.Clear();
                }
                if (txtbReal2.Text == "")
                {
                    throw new ApplicationException("La parte real del complejo dos no debe estar vacía");
                }
                else
                {
                    errorProvider3.Clear();
                }
                if (txtbImaginario1.Text == "")
                {
                    throw new ApplicationException("La parte maginaria del complejo uno no debe estar vacía");
                }
                else
                {
                    errorProvider2.Clear();
                }
                if (txtbImaginario2.Text == "")
                {
                    throw new ApplicationException("La parte imaginaria del complejo dos no debe estar vacía");
                }
                else
                {
                    errorProvider4.Clear();
                }

                c1 = new Complejo(float.Parse(txtbReal1.Text), float.Parse(txtbImaginario1.Text));
                c2 = new Complejo(float.Parse(txtbReal2.Text), float.Parse(txtbImaginario2.Text));

                c3 = c1 + c2;
                lbSimbolo.Text = "+";
                lbSuma.Text = c3.ToString();
            }
            catch(ApplicationException error)
            {
                if (txtbReal1.Text == "")
                {
                    errorProvider1.SetError(txtbReal1, error.Message);
                }
                if (txtbReal2.Text == "")
                {
                    errorProvider3.SetError(txtbReal2, error.Message);
                }
                if (txtbImaginario1.Text == "")
                {
                    errorProvider2.SetError(txtbImaginario1, error.Message);
                }
                if (txtbImaginario2.Text == "")
                {
                    errorProvider4.SetError(txtbImaginario2, error.Message);
                }

            }
            catch(FormatException error)
            {
                MessageBox.Show("Error: Debes de ingresar un numero");
            }
            catch(Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
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
            try
            {
                if (txtbReal1.Text == "")
                {
                    throw new ApplicationException("La parte real del complejo uno no debe estar vacía");
                }
                else
                {
                    errorProvider1.Clear();
                }
                if (txtbReal2.Text == "")
                {
                    throw new ApplicationException("La parte real del complejo dos no debe estar vacía");
                }
                else
                {
                    errorProvider3.Clear();
                }
                if (txtbImaginario1.Text == "")
                {
                    throw new ApplicationException("La parte maginaria del complejo uno no debe estar vacía");
                }
                else
                {
                    errorProvider2.Clear();
                }
                if (txtbImaginario2.Text == "")
                {
                    throw new ApplicationException("La parte imaginaria del complejo dos no debe estar vacía");
                }
                else
                {
                    errorProvider4.Clear();
                }

                c1 = new Complejo(float.Parse(txtbReal1.Text), float.Parse(txtbImaginario1.Text));
                c2 = new Complejo(float.Parse(txtbReal2.Text), float.Parse(txtbImaginario2.Text));

                c3 = c1 * c2;

                lbSimbolo.Text = "*";
                lbSuma.Text = c3.ToString();
            }
            catch (ApplicationException error)
            {
                if (txtbReal1.Text == "")
                {
                    errorProvider1.SetError(txtbReal1, error.Message);
                }
                if (txtbReal2.Text == "")
                {
                    errorProvider3.SetError(txtbReal2, error.Message);
                }
                if (txtbImaginario1.Text == "")
                {
                    errorProvider2.SetError(txtbImaginario1, error.Message);
                }
                if (txtbImaginario2.Text == "")
                {
                    errorProvider4.SetError(txtbImaginario2, error.Message);
                }

            }
            catch (FormatException error)
            {
                MessageBox.Show("Error: Debes de ingresar un numero");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }

        private void btnConjugar_Click(object sender, EventArgs e)
        {
            c3 = ~c3;
            lbSuma.Text = (c3).ToString(); 
        }

        
    }
}
