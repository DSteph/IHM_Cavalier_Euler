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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("Cavalier.png");
            pictureBox2.Image= Image.FromFile("Cavalier.png");
        }

        private void buttonSimu_Click(object sender, EventArgs e)
        {
            Simulation FS = new Simulation();
            FS.Show();
        }

        private void JeuButton_Click(object sender, EventArgs e)
        {
            Jeu FJ = new Jeu();
            FJ.Show();
        }
    }
}
