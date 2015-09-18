using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public class Playground
    {
        public static void setMines(int mines)
        {

            Form1.myDataGridView.
            for (int i = 0; i <= mines; i++)
            {                
                Field feld = new Field();                
                feld.mine = true;                
            }
        }
    }
}
