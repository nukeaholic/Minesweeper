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
        private static Form1 _instance;

        public TableLayoutPanel myDataGridView = new TableLayoutPanel();

        public Playground spielfeld = new Playground();

        private double difficulty;
        public double mines;

        private const double difVeryEasy = 0.05;
        private const double difEasy = 0.10;
        private const double difMedium = 0.15;
        private const double difHard = 0.20;



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
                    spielfeld.spielfeld[i, k].Width = 30;
                    spielfeld.spielfeld[i, k].Height = 30;


                    myDataGridView.Controls.Add(spielfeld.spielfeld[i, k], i, k);
                }
            }

            for (int i = 0; i < x; i++)
            {
                for (int k = 0; k < y; k++)
                {
                    for (int j = i - 1; j < i + 1; j++)
                    {
                        for (int l = k - 1; l < k + 1; l++)
                        {
                            if (j >= 0 && j < x && l >= 0 && l < y)
                            {
                                if (j != i && l != k)
                                {
                                    spielfeld.spielfeld[i, k].surroundings.Add(spielfeld.spielfeld[j, l]);
                                }
                            }
                        }
                    }
                }
            }

            Random rnd = new Random();
            for (int m = 0; m < mines; m++)
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
                    m--;
                }
            }
            myDataGridView.AutoSize = true;            
        }

        private Form1()
        {
            InitializeComponent();            
        }

        private void btn_Start_onClick(object sender, EventArgs e)
        {
            if (rdb_VeryEasy.Checked == true)
            {
                difficulty = difVeryEasy;
            }

            else if (rdb_Easy.Checked == true)
            {
                difficulty = difEasy;
            }

            else if (rdb_Medium.Checked == true)
            {
                difficulty = difMedium;
            }

            else if (rdb_Hard.Checked == true)
            {
                difficulty = difHard;
            }

            if (rdb_VeryEasy.Checked == true || rdb_Easy.Checked == true || rdb_Medium.Checked == true || rdb_Hard.Checked == true )
            {
                mines = Convert.ToInt32(und_X.Value) * Convert.ToInt32(und_Y.Value) * difficulty;
                Console.WriteLine("*******************************************\n\n" + mines + "\n\n*******************************************");

                SetupGrid(Convert.ToInt32(und_X.Value), Convert.ToInt32(und_Y.Value), Convert.ToInt32(mines));
                tbctrl_Window.SelectedIndex = 1;
            }
            
            else
            {
                MessageBox.Show("Bitte einen Schwierigkeitsgrad auswählen.");
            }
        }

        public static Form1 Instance()
        {
            if (_instance == null)
            {
                _instance = new Form1();
            }
            return _instance;
        }
    }
}