using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public class Playground
    {
        public static void setMines(int mines)
        {            
            for (int i = 0; i <= mines; i++)
            {                
                int seed = Convert.ToInt32(Regex.Match(Guid.NewGuid().ToString(), @"\d+").Value);
                int x = new Random(seed).Next(1, 3);
                int y = new Random(seed).Next(1, 3);

                Form1.myDataGridView.GetRow();
            }
        }
    }
}