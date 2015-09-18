    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Form1 : Form
    {
        public static TableLayoutPanel myDataGridView = new TableLayoutPanel();

        public void SetupGrid(int x, int y)
        {

            Controls.Add(myDataGridView);

            for (int i = 0; i < x; i++)
            {
                for (int k = 0; k < y; k++)
                {
                    myDataGridView.Controls.Add(new Field(), i, k);
                }
            }

            myDataGridView.AutoSize = true;
        }



        public Form1()
        {
            InitializeComponent();
            SetupGrid(2, 2);
            Playground.setMines(2);
        }
    }
}
