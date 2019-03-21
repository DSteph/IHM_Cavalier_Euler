using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class ButtonPerso : Button
    {
        public int x { get; set; }
        public int y { get; set; }
        public Boolean cliqué { get; set; }

        public ButtonPerso(int x, int y) : base()
        {
            this.x = x;
            this.y = y;
            this.cliqué = false;
            
        }
    }
}
