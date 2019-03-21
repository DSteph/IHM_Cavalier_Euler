using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Jeu : Form
    {

        ButtonPerso[,] plateau = new ButtonPerso[12, 12];
        int ii;
        int ij;
        static int[] depx = new int[] { -2, -2, -1, -1, 1, 1, 2, 2 };
        static int[] depy = new int[] { -1, 1, -2, 2, -2, 2, -1, 1 };
        ButtonPerso cavalier;

        int compteurCoup = 1;
        public Jeu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1200, 1200);
            for (int x = 0; x < 12; x++)
            {
                for (int y = 0; y < 12; y++)
                {
                    plateau[x, y] = new ButtonPerso(x, y);
                    if ((x >= 2 && x <= 9) && (y >= 2 && y <= 9))
                    {
                        plateau[x, y].Size = new Size(99, 99);
                        plateau[x, y].Location = new Point((x) * 100 , ((y - 2) * 100) + 200);
                        plateau[x, y].Visible = true;
                        
                        
                        plateau[x, y].Click += new EventHandler(this.ButtonClik);
                    
                        

                    }
                    else
                    {
                        plateau[x, y].Visible = false;
                        plateau[x, y].Size = new Size(0, 0);
                        plateau[x, y].Enabled = false;
                        plateau[x, y].cliqué = true;
                    }



                    this.Controls.Add(this.plateau[x, y]);
                    if ((x + y) % 2 != 0)
                        plateau[x, y].BackColor = Color.Black;


                }
            }

        }



        public void afficherCoups(int x, int y)
        {
            for (int i = 0; i < 8; i++)
            {
                if (plateau[x + depx[i], y - depy[i]].cliqué == false)
                {
                    plateau[x + depx[i], y - depy[i]].BackColor = Color.Green;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (compteurCoup >= 1)
                return;

            Random rd = new Random();
            ii = rd.Next(2, 9);
            ij = rd.Next(2, 9);
            
            plateau[ii, ij].BackColor = Color.Red;
            plateau[ii, ij].Text = "" + compteurCoup++;

            plateau[ii, ij].cliqué = true;
            afficherCoups(plateau[ii, ij].x, plateau[ii, ij].y);
            button2.Enabled = false;
        }

        

        private void ButtonClik(object sender, EventArgs e)
        {

            ButtonPerso b = (ButtonPerso)sender;
            if (compteurCoup == 1 || b.BackColor == Color.Green)
            {
                
                if (!b.cliqué)
                {
                    if (compteurCoup == 1)
                    {
                        ii = b.x;
                        ij = b.y;
                    }
                    b.cliqué = true;
                    cavalier = b;
                    refreshPlateau();
                    b.BackColor = Color.Red;
                    b.Text = "" + compteurCoup++;
                 
                    afficherCoups(b.x, b.y);
                    if (endGame() && aGagné() )
                    {
                     
                        
                        MessageBox.Show("Vous avez Gagné");
                    }

                    else if(endGame())
                    {
                        MessageBox.Show("Vous avez perdu");
                    }
                }

                else MessageBox.Show("Vous avez deja joué ici");

            }
            else
                MessageBox.Show("Coup invalide");


        }


        public void refreshPlateau()
        {

            for (int i = 2; i <= 9; i++)
            {
                for (int j = 2; j <= 9; j++)
                {


                    if ((i + j) % 2 != 0 && plateau[i, j].cliqué == false)
                    {
                        plateau[i, j].BackColor = Color.Black;
                    }
                    else if ((i + j) % 2 == 0 && plateau[i, j].cliqué == false)
                        plateau[i, j].BackColor = Color.White;

                    else if (plateau[i, j].cliqué)
                        plateau[i, j].BackColor = Color.Red;
                    plateau[i, j].Image = null;
                }
            }
            cavalier.Image = Image.FromFile("Cavalier.png");
        }

        public Boolean endGame()
        {
            {
                for (int i = 2; i <= 9; i++)
                {
                    for (int j = 2; j <= 9; j++)
                    {
                        if (plateau[i, j].BackColor == Color.Green)
                        {
                            return false;
                        }
                    }

                }
                return true;
            }


        }

        public Boolean aGagné()
        {
            if (endGame()==true && compteurCoup >= 63)
            {
                return true;
            }
            else return false;
        }

        public void replay()
        {
            ButtonPerso max=plateau[2,2];
            cavalier=new ButtonPerso(0,0);
            int test;
            int maximum = 0;
           
                for (int i = 2; i <= 9; i++)
                {
                    for (int j = 2; j <= 9; j++)
                    {
                        if (Int32.TryParse(plateau[i, j].Text, out test)) {

                            if (test >= maximum)
                            {
                                maximum = test;
                                max = plateau[i, j];
                            }
                        }
                        else;


                    }
                }

                for (int i = 2; i <= 9; i++)
                {
                    for (int j = 2; j <= 9; j++)
                    {
                        if (Int32.TryParse(plateau[i, j].Text, out test))
                        {
                            if (test == maximum - 1)
                                cavalier = plateau[i, j];


                        }
                    }
                }

                max.cliqué = false;
                refreshPlateau();
                compteurCoup--;
                max.Text = "";
                afficherCoups(cavalier.x, cavalier.y);
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (compteurCoup > 2)
                replay();
            else
                ;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Jeu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!aGagné())
            {
                DialogResult reponse = MessageBox.Show(
                    "Voulez vous lancer une simulation pour voir vos erreurs ? ?",
                    "Fermeture",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.ServiceNotification);


                if (reponse == DialogResult.Yes)
                {
                    Simulation s = new SimulationJeu(ii - 1, ij - 1);
                    s.Focus();
                    s.Show();

                }
            }
        }

        private void règlesDuJeuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Le but de cette application graphique WinForms (C#), est de faire parcourir à un cavalier l'ensemble d'un échiquier sans passer deux fois sur la même case. On rappelle la technique de déplacement d'un cavalier sur un échiquier : à partir d'une case X, un cavalier peut se déplacer sur l'une des 8 cases suivantes ");
        }
    }
}

    


