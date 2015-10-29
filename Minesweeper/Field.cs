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
                marked = true;
                frm_Main.Instance().Spielfeld.Markings++;
                frm_Main.Instance().setLabelMarkText(frm_Main.Instance().MarkingsCounter);
            }

            else
            {
                button.BackColor = Color.Gray;
                marked = false;
                frm_Main.Instance().Spielfeld.Markings--;
                frm_Main.Instance().setLabelMarkText(frm_Main.Instance().MarkingsCounter);
            }
            checkWin();           
        }

        private void onLeftClick(Field button)
        {
            if (mine == true)
            {
                foreach (Field feld in frm_Main.Instance().Spielfeld.Spielfeld)
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
                frm_Main.Instance().Spielfeld.FieldsRevealed++;
            }

            if (button.marked == true)
            {
                button.marked = false;
                frm_Main.Instance().Spielfeld.Markings--;
                frm_Main.Instance().setLabelMarkText(frm_Main.Instance().MarkingsCounter);
            }

            
            button.Text = "" + button.suMines;
            button.BackColor = Color.White;
            button.Enabled = false;
            button.check = true;
        }

        public static void checkWin()
        {
            int fields = Convert.ToInt32(frm_Main.Instance().und_X.Value) * Convert.ToInt32(frm_Main.Instance().und_Y.Value);

            if (frm_Main.Instance().Spielfeld.FieldsRevealed == fields - Convert.ToInt32(frm_Main.Instance().Mines))
            {
                MessageBox.Show("Gewonnen!");
                gameOver();
            }
        }

        public static void gameOver()
        {
            frm_Main.Instance().tbctrl_Window.SelectedIndex = 0;
            frm_Main.Instance().tbctrl_Window.TabPages[1].Controls.Remove(frm_Main.Instance().MyDataGridView);
            frm_Main.Instance().Spielfeld.FieldsRevealed = 0;
            frm_Main.Instance().Spielfeld.Markings = 0;

            for (int i = 0; i < frm_Main.Instance().und_X.Value; i++)
            {
                for (int k = 0; k < frm_Main.Instance().und_Y.Value; k++)
                {
                    frm_Main.Instance().MyDataGridView.Controls.Remove(frm_Main.Instance().Spielfeld.Spielfeld[i, k]);
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