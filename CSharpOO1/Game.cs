using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpOO1
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();

        }

  
        private void Game_Load(object sender, EventArgs e)
        {

          


            Random gerador = new Random();
            Var.aleatorio = gerador.Next(1000);

            
            

        }

        private void btnCloseGame_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtSorte.Text != "")
            {


                Var.sorte = int.Parse(txtSorte.Text);
                lstHist.Items.Add(Convert.ToString(this.txtSorte.Text));

                if (Var.sorte == Var.aleatorio)
                {
                    MessageBox.Show("Você acertou!");
                }
                else
                {
                    if (Var.sorte > Var.aleatorio)
                    {
                        Certo.Text = ("O Número Certo é MENOR!");
                    }
                    if (Var.sorte < Var.aleatorio)
                    {
                        Certo.Text = ("O Número Certo é MAIOR!");
                    }

                    Var.vida++;

                    lblVidas.Text = Convert.ToString(10 - Var.vida);

                    if (Var.vida == 10)
                    {
                        MessageBox.Show("Você perdeu! O Número Certo Era: " + Convert.ToString(Var.aleatorio));
                        

                        
                    }

                }
            }
            else
            {
                MessageBox.Show("Digite um número para começar o jogo!", "Error!", MessageBoxButtons.OK);
            }

                if (Var.vida > 10)
            {
                MessageBox.Show("Clique em Jogar Novamente", "Error!", MessageBoxButtons.OK);

            }


            txtSorte.Clear();
            txtSorte.Focus();


                }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            Random gerador = new Random();
            Var.aleatorio = gerador.Next(1000);
            lstHist.Items.Clear();
            Var.vida = 0;
            lblVidas.Text = Convert.ToString(10 - Var.vida);
            txtSorte.Clear();
            txtSorte.Focus();
            Certo.Text = "";
        }
    }
        }
    


