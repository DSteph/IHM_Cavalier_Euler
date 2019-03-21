using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Simulation : Form
    {
        Button[,] Echiquier;
        static int[,] echec = new int[12, 12];
        static int[] depi = new int[] { 2, 1, -1, -2, -2, -1, 1, 2 };
        static int[] depj = new int[] { 1, 2, 2, 1, -1, -2, -2, -1 };
        int nb_fuite, min_fuite, lmin_fuite = 0;
        int i, j, k, l, ii, jj, nbPasRadio;
        System.Timers.Timer aTimer;

        private void PlacerCavalierButton_Click(object sender, EventArgs e)
        {
            Reboot_Click(sender, e);
            k = 1;
            bool okValue = Int32.TryParse(AbsTextbox.Text, out ii);
            if (okValue && ii >= 1 && ii <= 8)
                ii = Int32.Parse(AbsTextbox.Text);
            else
            {
                MessageBox.Show("Merci d'entrer une valeur comprise entre 1 et 8 dans " + AbsLabel.Text, "Valeur éronnée");
                ii = 0;
                AbsTextbox.Text = null;
                return;
            }

            okValue = Int32.TryParse(OrdTextbox.Text, out jj);
            if (okValue && jj >= 1 && jj <= 8)
                jj = Int32.Parse(OrdTextbox.Text);
            else
            {
                MessageBox.Show("Merci d'entrer une valeur comprise entre 1 et 8 dans " + OrdLabel.Text, "Valeur éronnée");
                jj = 0;
                OrdTextbox.Text = null;
                return;
            }
            // ii et jj evoluent de 1 à 8 !

            for (i = 0; i < 12; i++)
                for (j = 0; j < 12; j++)
                    echec[i, j] = ((i < 2 | i > 9 | j < 2 | j > 9) ? -1 : 0);
            i = ii + 1; j = jj + 1;
            echec[i, j] = 1;
            Echiquier[i - 2, j - 2].BackColor = Color.Red;
            Echiquier[i - 2, j - 2].Text = "1";
            Echiquier[i-2, j-2].Image = Image.FromFile("Cavalier.png");
            AvancerButton.Enabled = true;
            ReculerButton.Enabled = true;
            StopButton.Enabled = false;
            DémoComp.Enabled = true;
        }

        private void radioPas_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                RadioButton RB = (RadioButton)sender;

                if (RB.Text == "1 pas")
                    nbPasRadio = 1;
                else if (RB.Text == "5 pas")
                    nbPasRadio = 5;
                else nbPasRadio = 64;
            }
        }

        private void ReplayButton_Click(object sender, EventArgs e)
        {
            Reboot_Click(sender, e);
            PlacerCavalierButton_Click(sender, e);
            DémoComp_Click(sender, e);
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            aTimer.Stop();
            DémoComp.Enabled = true;
            StopButton.Enabled = false;
            AvancerButton.Enabled = true;
            ReculerButton.Enabled = true;
            Reboot.Enabled = true;
        }

        public Simulation()
        {
            InitializeComponent();
            this.Echiquier = new Button[8, 8];
            aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(AvancerButton_Click);
            AvancerButton.Enabled = false;
            ReculerButton.Enabled = false;
            StopButton.Enabled = false;
            DémoComp.Enabled = false;
            radio1Pas.Checked = true;
            nbPasRadio = 1;

            char lettre = '1';
            for (int i = 0, lx = 105; i < 8; ++i, lx += 83)
            {
                Label l = new Label();
                l.Size = new Size(24, 25);
                l.Font = new Font("Microsoft Sans Serif", 15);
                l.Text = lettre.ToString();
                l.Location = new System.Drawing.Point(lx, 38);
                ++lettre;
                this.Controls.Add(l);
            }
            lettre = '1';
            for (int i = 0, ly = 103; i < 8; ++i, ly += 83)
            {

                Label l = new Label();
                l.Size = new Size(24, 25);
                l.Font = new Font("Microsoft Sans Serif", 15);
                l.Text = lettre.ToString();
                l.Location = new System.Drawing.Point(38, ly);
                ++lettre;
                this.Controls.Add(l);
            }


            for (int l = 0; l < 8; l++)
                for (int c = 0; c < 8; c++)
                {
                    Button b;
                    // new Button
                    b = new Button();
                    Echiquier[l, c] = b;
                    // Location
                    b.Location = new System.Drawing.Point(75 + l * 83, 75 + c * 83);
                    //Image
                    if (c % 2 == 0)
                        if (l % 2 == 0)
                            b.BackColor = Color.Black;
                        else b.BackColor = Color.White;
                    else
                        if (l % 2 == 0)
                        b.BackColor = Color.White;
                    else b.BackColor = Color.Black;
                    // Size
                    b.Size = new System.Drawing.Size(83, 83);
                    //Mode simulation, bouton disabled
                    b.Enabled = false;
                    // Ajout du contrôle à la fenêtre
                    this.Controls.Add(b);
                }
        }

        public  Simulation(int x, int y ) : base()
        {

            InitializeComponent();
            AbsTextbox.Text = x.ToString();
            OrdTextbox.Text = y.ToString();
            AbsTextbox.Enabled = false;
        }

        private void DémoComp_Click(object sender, EventArgs e)
        {
            aTimer.Interval = VitTrackbar.Value * 1000;
            aTimer.Enabled = true;
            DémoComp.Enabled = false;
            StopButton.Enabled = true;
            AvancerButton.Enabled = false;
            ReculerButton.Enabled = false;
            Reboot.Enabled = false;
        }

        /**********************************************************************/
        /*     Fonction de recherche du nombre de cases de fuite possibles    */
        /**********************************************************************/

        static int fuite(int i, int j)
        {
            int n, l;

            for (l = 0, n = 8; l < 8; l++)
                if (echec[i + depi[l], j + depj[l]] != 0) n--;

            return (n == 0) ? 9 : n;
        }

        private void Reboot_Click(object sender, EventArgs e)
        {
            for (int l = 0; l < 8; l++)
                for (int c = 0; c < 8; c++)
                {
                    Echiquier[l, c].Image = null;
                    Echiquier[l, c].Text = null;
                    if (c % 2 == 0)
                        if (l % 2 == 0)
                            Echiquier[l, c].BackColor = Color.Black;
                        else Echiquier[l, c].BackColor = Color.White;
                    else
                            if (l % 2 == 0)
                        Echiquier[l, c].BackColor = Color.White;
                    else Echiquier[l, c].BackColor = Color.Black;
                }
            AvancerButton.Enabled = false;
            ReculerButton.Enabled = false;
            StopButton.Enabled = false;
            DémoComp.Enabled = false;
            ii = 0; jj = 0;
        }

        private void RandomCoorButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            AbsTextbox.Text = random.Next(1, 8).ToString();
            OrdTextbox.Text = random.Next(1, 8).ToString();
        }

        private void AvancerButton_Click(object sender, EventArgs e)
        {
            if (k == 0)
            {
                MessageBox.Show("Merci de replacer un cavalier", "Erreur");
                return;
            }
            for (int nbPas = 0; nbPas < nbPasRadio; ++nbPas)
            {
                if (k == 64)
                {
                    aTimer.Stop();
                    Reboot.Enabled = true;
                    DémoComp.Enabled = true;
                    return;
                }
                ++k;
                for (l = 0, min_fuite = 11; l < 8; l++)
                {
                    ii = i + depi[l]; jj = j + depj[l];

                    nb_fuite = ((echec[ii, jj] != 0) ? 10 : fuite(ii, jj));

                    if (nb_fuite < min_fuite)
                    {
                        min_fuite = nb_fuite; lmin_fuite = l;
                    }
                }
                i += depi[lmin_fuite]; j += depj[lmin_fuite];
                echec[i, j] = k;
                Echiquier[i - 2, j - 2].BackColor = Color.Red;
                Echiquier[i - 2, j - 2].Text = k.ToString();
                sweepCavalier(i - 2, j - 2);
            }
        }
        private void ReculerButton_Click(object sender, EventArgs e)
        {
            if (k == 1)
            {
                return;
            }
            int nbPas;
            if (radioPasFull.Checked == true)
                nbPas = 1;
            else nbPas = 0;
            for (; nbPas < nbPasRadio; ++nbPas)
            {
                for (int l = 0; l < 8; l++)
                    for (int c = 0; c < 8; c++)
                    {
                        if (Echiquier[l, c].Text == k.ToString())
                        {
                            Echiquier[l, c].Text = null;
                            if (c % 2 == 0)
                                if (l % 2 == 0)
                                    Echiquier[l, c].BackColor = Color.Black;
                                else Echiquier[l, c].BackColor = Color.White;
                            else
                            if (l % 2 == 0)
                                Echiquier[l, c].BackColor = Color.White;
                            else Echiquier[l, c].BackColor = Color.Black;
                        }
                    }
                        --k;
                echec[i, j] = 0;
                for (int l = 0; l < 8; l++)
                    for (int c = 0; c < 8; c++)
                        if (Echiquier[l, c].Text == k.ToString())
                        {
                            i = l+2;
                            j = c+2;
                        }
                sweepCavalier(i - 2, j - 2);
            }
        }

        private void sweepCavalier(int i, int j)
        {
            for (int l = 0; l < 8; l++)
                for (int c = 0; c < 8; c++)
                        Echiquier[l, c].Image = null;
            Echiquier[i, j].Image = Image.FromFile("Cavalier.png");
        }

        public Button getRandomButton()
        {
            return this.RandomCoorButton;
        }

        public TextBox getAbsTextBox()
        {
            return this.AbsTextbox;
        }

        public TextBox getOrdTextBox()
        {
            return this.OrdTextbox;
        }
    }
}
