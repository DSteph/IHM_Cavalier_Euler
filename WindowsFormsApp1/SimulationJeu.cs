using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   public partial class SimulationJeu : Simulation
    {
        public SimulationJeu(int x , int y) : base()
        {
            getRandomButton().Enabled = false;
            getAbsTextBox().Text = x.ToString();
            getOrdTextBox().Text = y.ToString();

        }
    }
}
