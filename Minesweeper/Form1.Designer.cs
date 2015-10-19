namespace Minesweeper
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbctrl_Window = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rdb_VeryEasy = new System.Windows.Forms.RadioButton();
            this.rdb_Hard = new System.Windows.Forms.RadioButton();
            this.rdb_Medium = new System.Windows.Forms.RadioButton();
            this.rdb_Easy = new System.Windows.Forms.RadioButton();
            this.und_Y = new System.Windows.Forms.NumericUpDown();
            this.und_X = new System.Windows.Forms.NumericUpDown();
            this.lbl_difficulty = new System.Windows.Forms.Label();
            this.lbl_Y = new System.Windows.Forms.Label();
            this.lbl_X = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbctrl_Window.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.und_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.und_X)).BeginInit();
            this.SuspendLayout();
            // 
            // tbctrl_Window
            // 
            this.tbctrl_Window.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbctrl_Window.Controls.Add(this.tabPage1);
            this.tbctrl_Window.Controls.Add(this.tabPage2);
            this.tbctrl_Window.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbctrl_Window.ItemSize = new System.Drawing.Size(0, 1);
            this.tbctrl_Window.Location = new System.Drawing.Point(0, 0);
            this.tbctrl_Window.Name = "tbctrl_Window";
            this.tbctrl_Window.SelectedIndex = 0;
            this.tbctrl_Window.Size = new System.Drawing.Size(657, 616);
            this.tbctrl_Window.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbctrl_Window.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rdb_VeryEasy);
            this.tabPage1.Controls.Add(this.rdb_Hard);
            this.tabPage1.Controls.Add(this.rdb_Medium);
            this.tabPage1.Controls.Add(this.rdb_Easy);
            this.tabPage1.Controls.Add(this.und_Y);
            this.tabPage1.Controls.Add(this.und_X);
            this.tabPage1.Controls.Add(this.lbl_difficulty);
            this.tabPage1.Controls.Add(this.lbl_Y);
            this.tabPage1.Controls.Add(this.lbl_X);
            this.tabPage1.Controls.Add(this.btn_start);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(649, 607);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rdb_VeryEasy
            // 
            this.rdb_VeryEasy.AutoSize = true;
            this.rdb_VeryEasy.Location = new System.Drawing.Point(470, 117);
            this.rdb_VeryEasy.Name = "rdb_VeryEasy";
            this.rdb_VeryEasy.Size = new System.Drawing.Size(86, 17);
            this.rdb_VeryEasy.TabIndex = 13;
            this.rdb_VeryEasy.TabStop = true;
            this.rdb_VeryEasy.Text = "Sehr Einfach";
            this.rdb_VeryEasy.UseVisualStyleBackColor = true;
            // 
            // rdb_Hard
            // 
            this.rdb_Hard.AutoSize = true;
            this.rdb_Hard.Location = new System.Drawing.Point(470, 187);
            this.rdb_Hard.Name = "rdb_Hard";
            this.rdb_Hard.Size = new System.Drawing.Size(61, 17);
            this.rdb_Hard.TabIndex = 12;
            this.rdb_Hard.TabStop = true;
            this.rdb_Hard.Text = "Schwer";
            this.rdb_Hard.UseVisualStyleBackColor = true;
            // 
            // rdb_Medium
            // 
            this.rdb_Medium.AutoSize = true;
            this.rdb_Medium.Location = new System.Drawing.Point(470, 164);
            this.rdb_Medium.Name = "rdb_Medium";
            this.rdb_Medium.Size = new System.Drawing.Size(50, 17);
            this.rdb_Medium.TabIndex = 11;
            this.rdb_Medium.TabStop = true;
            this.rdb_Medium.Text = "Mittel";
            this.rdb_Medium.UseVisualStyleBackColor = true;
            // 
            // rdb_Easy
            // 
            this.rdb_Easy.AutoSize = true;
            this.rdb_Easy.Location = new System.Drawing.Point(470, 140);
            this.rdb_Easy.Name = "rdb_Easy";
            this.rdb_Easy.Size = new System.Drawing.Size(61, 17);
            this.rdb_Easy.TabIndex = 10;
            this.rdb_Easy.TabStop = true;
            this.rdb_Easy.Text = "Einfach";
            this.rdb_Easy.UseVisualStyleBackColor = true;
            // 
            // und_Y
            // 
            this.und_Y.Location = new System.Drawing.Point(239, 106);
            this.und_Y.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.und_Y.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.und_Y.Name = "und_Y";
            this.und_Y.Size = new System.Drawing.Size(120, 20);
            this.und_Y.TabIndex = 9;
            this.und_Y.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // und_X
            // 
            this.und_X.Location = new System.Drawing.Point(51, 106);
            this.und_X.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.und_X.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.und_X.Name = "und_X";
            this.und_X.Size = new System.Drawing.Size(120, 20);
            this.und_X.TabIndex = 7;
            this.und_X.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lbl_difficulty
            // 
            this.lbl_difficulty.AutoSize = true;
            this.lbl_difficulty.Location = new System.Drawing.Point(467, 67);
            this.lbl_difficulty.Name = "lbl_difficulty";
            this.lbl_difficulty.Size = new System.Drawing.Size(84, 13);
            this.lbl_difficulty.TabIndex = 6;
            this.lbl_difficulty.Text = "Swierigkeitsgrad";
            // 
            // lbl_Y
            // 
            this.lbl_Y.AutoSize = true;
            this.lbl_Y.Location = new System.Drawing.Point(284, 68);
            this.lbl_Y.Name = "lbl_Y";
            this.lbl_Y.Size = new System.Drawing.Size(14, 13);
            this.lbl_Y.TabIndex = 5;
            this.lbl_Y.Text = "Y";
            // 
            // lbl_X
            // 
            this.lbl_X.AutoSize = true;
            this.lbl_X.Location = new System.Drawing.Point(101, 68);
            this.lbl_X.Name = "lbl_X";
            this.lbl_X.Size = new System.Drawing.Size(14, 13);
            this.lbl_X.TabIndex = 4;
            this.lbl_X.Text = "X";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(284, 384);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Spiel starten";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_Start_onClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(649, 607);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 616);
            this.Controls.Add(this.tbctrl_Window);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tbctrl_Window.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.und_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.und_X)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lbl_difficulty;
        private System.Windows.Forms.Label lbl_Y;
        private System.Windows.Forms.Label lbl_X;
        public System.Windows.Forms.TabControl tbctrl_Window;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton rdb_Hard;
        private System.Windows.Forms.RadioButton rdb_Medium;
        private System.Windows.Forms.RadioButton rdb_Easy;
        private System.Windows.Forms.RadioButton rdb_VeryEasy;
        public System.Windows.Forms.NumericUpDown und_Y;
        public System.Windows.Forms.NumericUpDown und_X;



    }
}

