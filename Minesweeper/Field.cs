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
        private Boolean check = false;
        private Boolean mine = false;
        private Boolean marked = false;

        private int suMines = 0;

        private List <Field> surroundings = new List <Field>();

        public Field()
        {
            MouseDown += MyClick;
        }

        private void MyClick(object sender, MouseEventArgs e)
        {
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
            if (marked == false)
            {
                button.BackColor = Color.OrangeRed;
                marked = false;
                Form1.Instance().Spielfeld.Markings++;
            }

            else
            {
                button.BackColor = Color.Gray;
                marked = false;
                Form1.Instance().Spielfeld.Markings--;
            }
            checkWin();           
        }

        private void onLeftClick(Field button)
        {
            if (mine == true)
            {
                foreach (Field feld in Form1.Instance().Spielfeld.Spielfeld)
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
                Form1.Instance().Spielfeld.FieldsRevealed++;
            }

            if (button.marked == true)
            {
                button.marked = false;
                Form1.Instance().Spielfeld.Markings--;
            }

            
            button.Text = "" + button.suMines;
            button.BackColor = Color.White;
            button.Enabled = false;
            button.check = true;
        }

        public static void checkWin()
        {
            int fields = Convert.ToInt32(Form1.Instance().und_X.Value) * Convert.ToInt32(Form1.Instance().und_Y.Value);

            if (Form1.Instance().Spielfeld.FieldsRevealed == fields - Convert.ToInt32(Form1.Instance().mines))
            {
                MessageBox.Show("Gewonnen!");
                gameOver();
            }
        }

        public static void gameOver()
        {
            Form1.Instance().tbctrl_Window.SelectedIndex = 0;
            Form1.Instance().tbctrl_Window.TabPages[1].Controls.Remove(Form1.Instance().MyDataGridView);
            Form1.Instance().Spielfeld.FieldsRevealed = 0;

            for (int i = 0; i < Form1.Instance().und_X.Value; i++)
            {
                for (int k = 0; k < Form1.Instance().und_Y.Value; k++)
                {
                    Form1.Instance().MyDataGridView.Controls.Remove(Form1.Instance().Spielfeld.Spielfeld[i, k]);
                }
            }
        }

        public Boolean Check
        {
            get
            {
                return this.check;
            }

            set
            {
                this.check = value;
            }
        }        

        public Boolean Mine
        {
            get 
            { 
                return this.mine;
            }

            set
            {
                this.mine = value;
            }
        }

        public int SuMines
        {
            get
            {
                return this.suMines;
            }

            set
            {
                this.suMines = value;
            }
        }

        public List<Field> Surroundings
        {
            get
            {
                return this.surroundings;
            }

            set
            {
                this.surroundings = value;
            }
        }
    }
}