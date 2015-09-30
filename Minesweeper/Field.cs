using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public class Field : Button
    {
        public Boolean mine = false;
        public int suMines = 0;
        public List <Field> surroundings = new List <Field>();


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
