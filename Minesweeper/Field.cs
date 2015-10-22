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
        private Boolean flip = true;
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
            }

            else
            {
                button.BackColor = Color.Gray;
                flip = true;
            }
            checkWin();           
        }

        private void onLeftClick(Field button)
        {
            if (mine == true)
            {
                foreach (Field feld in Form1.Instance().spielfeld.spielfeld)
                {
                    if (feld.mine == true){
                        feld.Text = "M";
                        feld.BackColor = Color.Red;
                    }
                }
                MessageBox.Show("boom");
                gameOver();
            }

            else 
            {
                if (button.suMines == 0)
                {
                    buttonRevealed(button);
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
            checkWin();
        }

        private void buttonRevealed(Field button)
        {
            if (button.check == false)
            {
                Form1.Instance().spielfeld.fieldsRevealed++;
            }
            
            button.Text = "" + button.suMines;
            button.BackColor = Color.White;
            button.Enabled = false;
            button.check = true;
        }

        public static void checkWin()
        {
            int fields = Convert.ToInt32(Form1.Instance().und_X.Value) * Convert.ToInt32(Form1.Instance().und_Y.Value);

            if (Form1.Instance().spielfeld.fieldsRevealed == fields - Convert.ToInt32(Form1.Instance().mines))
            {
                MessageBox.Show("Gewonnen!");
                gameOver();
            }
        }

        public static void gameOver()
        {
            Form1.Instance().tbctrl_Window.SelectedIndex = 0;
            Form1.Instance().tbctrl_Window.TabPages[1].Controls.Remove(Form1.Instance().myDataGridView);
            Form1.Instance().spielfeld.fieldsRevealed = 0;

            for (int i = 0; i < Form1.Instance().und_X.Value; i++)
            {
                for (int k = 0; k < Form1.Instance().und_Y.Value; k++)
                {
                    Form1.Instance().myDataGridView.Controls.Remove(Form1.Instance().spielfeld.spielfeld[i, k]);
                }
            }            
        }
    }
}