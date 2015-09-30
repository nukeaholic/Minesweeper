using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Minesweeper
{
    public partial class Form1 : Form
    {
        public static TableLayoutPanel myDataGridView = new TableLayoutPanel();
        
        public Playground playground = new Playground();

        public void SetupGrid(int x, int y, int mines)
        {
            playground.spielfeld = new Field[x, y];            

            Controls.Add(myDataGridView);

            for (int i = 0; i < x; i++)
            {
                for (int k = 0; k < y; k++)
                {
                    playground.spielfeld[i,k]= new Field();
                    playground.spielfeld[i, k].Text = i + "," + k+", "+playground.spielfeld[i,k].suMines;

                    myDataGridView.Controls.Add(playground.spielfeld[i,k], i, k);
                }
            }

            myDataGridView.AutoSize = true;

            Random rnd = new Random();
            for (int j = 0; j < mines; j++)
            {
                int xx = rnd.Next(x);
                int yy = rnd.Next(y);

                if (playground.spielfeld[xx, yy].mine == false){
                    Console.WriteLine(xx + "\n" + yy+"\n");
                    playground.spielfeld[xx, yy].mine = true;
                }
                else
                {
                    j--;
                    Console.WriteLine("***************************************");
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            SetupGrid(2, 2, 3);
        }
    }
}
