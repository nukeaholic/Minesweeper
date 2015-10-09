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
        Boolean flip = true;
        public Boolean check = false;
        public Boolean mine = false;

        public int suMines = 0;        

        public List <Field> surroundings = new List <Field>();

        public Field()
        {
            MouseDown += MyClick;
        }

        private void MyClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show(suMines.ToString());

            Field button = (Field)sender;

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                onLeftClick(button);
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                onRightClick(button);
            }
        }

        private void onRightClick(Field button)
        {
            if (flip == true)
            {
                button.BackColor = Color.OrangeRed;
                flip = false;
                Form1.spielfeld.markings++;

                if (button.mine == true)
                {
                    Form1.spielfeld.markedMines++;
                }
            }

            else
            {
                button.BackColor = Color.Gray;
                flip = true;
                Form1.spielfeld.markings--;

                if (button.mine == true)
                {
                    Form1.spielfeld.markedMines--;
                }
            }

            if (Form1.spielfeld.markedMines == Form1.spielfeld.mines)// && Form1.spielfeld.markedMines == Form1.spielfeld.markings)
            {
                MessageBox.Show("Gewonnen!");
            }
        }

        private void onLeftClick(Field button)
        {
            if (mine == true)
            {
                MessageBox.Show("boom");
            }

            else 
            {
                if (button.suMines == 0)
                {
                    buttonRevealed(button);
                    button.check = true;
                    foreach (Field feld in button.surroundings)
                    {
                        if (feld.check == false)
                        {
                            buttonRevealed(button);
                            onLeftClick(feld);
                        }
                    }
                }

                else
                {
                    buttonRevealed(button);
                }
            }
        }

        private void buttonRevealed(Field button)
        {
            button.Text = "" + button.suMines;
            button.BackColor = Color.White;
            button.Enabled = false;
        }
    }
}