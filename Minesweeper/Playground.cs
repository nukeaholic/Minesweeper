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
        private Field[,] spielfeld;

        private int mines;
        private int fieldsRevealed;
        private int markings = 0;

        public int Mines
        {
            get
            {
                return this.mines;
            }

            set
            {
                this.mines = value;
            }
        }

        public int FieldsRevealed
        {
            get
            {
                return this.fieldsRevealed;
            }

            set
            {
                this.fieldsRevealed = value;
            }
        }

        public int Markings
        {
            get
            {
                return this.markings;
            }

            set
            {
                this.markings = value;
            }
        }

        public Field[,] Spielfeld
        {
            get
            {
                return this.spielfeld;
            }

            set
            {
                this.spielfeld = value;
            }
        }        
    }
}