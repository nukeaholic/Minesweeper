using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Minesweeper
{
    public class Field : Button
    {
        public Boolean check = false;
        public Boolean mine = false;
        public int suMines = 0;
        public List <Field> surroundings = new List <Field>();


        public Field()
        {
            Click += MyClick;
        }

        private void MyClick(object sender, EventArgs e)
        {
            //MessageBox.Show(suMines.ToString());

            Field button = (Field)sender;

            onClick(button);
            
        }

        private void onClick(Field button)
        {
            if (mine == true)
            {
                MessageBox.Show("boom");
            }
            else 
            {
                if (button.suMines == 0)
                {
                    button.Text = "" + button.suMines;
                    button.BackColor = Color.White;
                    button.check = true;
                    foreach (Field feld in button.surroundings)
                    {
                        if (feld.check == false)
                        {
                            feld.Text = "" + feld.suMines;
                            button.BackColor = Color.White;
                            onClick(feld);
                        }
                    }
                }
                else
                {
                    button.Text = "" + button.suMines;
                    button.BackColor = Color.White;
                }
            }
        }
    }
}