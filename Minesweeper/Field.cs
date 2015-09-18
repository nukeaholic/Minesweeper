using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    class Field : Button
    {
        public Boolean mine = false;
        public int surroundings = 0;


        public Field()
        {
            Click += MyClick;
        }

        private void MyClick(object sender, EventArgs e)
        {
            if (mine == true)
            {
                MessageBox.Show("boom");
            }
        }       
    }
}
