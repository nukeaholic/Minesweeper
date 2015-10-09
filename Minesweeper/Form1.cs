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
        
        public static Playground spielfeld = new Playground();

        public void SetupGrid(int x, int y, int mines)
        {
            spielfeld.mines = mines;

            spielfeld.spielfeld = new Field[x, y];            

            tbctrl_Window.TabPages[1].Controls.Add(myDataGridView);


            for (int i = 0; i < x; i++)
            {
                for (int k = 0; k < y; k++)
                {
                    spielfeld.spielfeld[i, k] = new Field();
                    spielfeld.spielfeld[i, k].BackColor = Color.Gray;


                    myDataGridView.Controls.Add(spielfeld.spielfeld[i, k], i, k);
                }
            }

            for (int i = 0; i < x; i++)
            {
                for (int k = 0; k < y; k++)
                { 
                    int a = i;
                    int b = k;

                    i--;
                    getSurroundings(i, k, x, y, a, b);
                    
                    k--;
                    getSurroundings(i, k, x, y, a, b);

                    i++;
                    getSurroundings(i, k, x, y, a, b);
                    
                    i++;
                    getSurroundings(i, k, x, y, a, b);
                    
                    k++;
                    getSurroundings(i, k, x, y, a, b);
                    
                    k++;
                    getSurroundings(i, k, x, y, a, b);
                    
                    i--;
                    getSurroundings(i, k, x, y, a, b);                    
                        
                    i--;
                    getSurroundings(i, k, x, y, a, b);

                    i = a;
                    k = b;
                }
            }


            Random rnd = new Random();
            for (int j = 0; j < mines; j++)
            {
                int xx = rnd.Next(x);
                int yy = rnd.Next(y);

                if (spielfeld.spielfeld[xx, yy].mine == false)
                {
                    spielfeld.spielfeld[xx, yy].mine = true;

                    foreach (Field feld in spielfeld.spielfeld[xx, yy].surroundings)
                    {
                        feld.suMines++;
                    }
                }

                else
                {
                    j--;
                }
            }
            myDataGridView.AutoSize = true;            
        }

        public void getSurroundings(int i, int k, int x, int y, int a, int b)
        {
            if (i >= 0 && i < x && k >= 0 && k < y)
            {
                spielfeld.spielfeld[a, b].surroundings.Add(spielfeld.spielfeld[i, k]);
            }
        }

        public Form1()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((und_X.Value * und_Y.Value)/2 > und_Mines.Value)
            {
                SetupGrid(Convert.ToInt32(und_X.Value), Convert.ToInt32(und_Y.Value), Convert.ToInt32(und_Mines.Value));
                tbctrl_Window.SelectedIndex = 1;
            }

            else
            {
                MessageBox.Show("Zu viele Minen bzw zu kleines Spielfeld!");
            }
            
        }
    }
}