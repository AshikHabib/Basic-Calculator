namespace Calculator
{
    partial class Calculator
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
            this.Seven = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.AllClear = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.EqualTo = new System.Windows.Forms.Button();
            this.Addition = new System.Windows.Forms.Button();
            this.Dot = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.ResultScreen = new System.Windows.Forms.TextBox();
            this.ClearEntry = new System.Windows.Forms.Button();
            this.Subtraction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Seven
            // 
            this.Seven.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seven.Location = new System.Drawing.Point(25, 86);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(70, 45);
            this.Seven.TabIndex = 0;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = false;
            this.Seven.Click += new System.EventHandler(this.PressButton);
            // 
            // Eight
            // 
            this.Eight.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eight.Location = new System.Drawing.Point(101, 86);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(70, 45);
            this.Eight.TabIndex = 1;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = false;
            this.Eight.Click += new System.EventHandler(this.PressButton);
            // 
            // Nine
            // 
            this.Nine.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nine.Location = new System.Drawing.Point(177, 86);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(70, 45);
            this.Nine.TabIndex = 2;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = false;
            this.Nine.Click += new System.EventHandler(this.PressButton);
            // 
            // AllClear
            // 
            this.AllClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllClear.Location = new System.Drawing.Point(329, 86);
            this.AllClear.Name = "AllClear";
            this.AllClear.Size = new System.Drawing.Size(70, 45);
            this.AllClear.TabIndex = 3;
            this.AllClear.Text = "AC";
            this.AllClear.UseVisualStyleBackColor = true;
            this.AllClear.Click += new System.EventHandler(this.AllClear_Click);
            // 
            // Division
            // 
            this.Division.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Division.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Division.Location = new System.Drawing.Point(253, 86);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(70, 45);
            this.Division.TabIndex = 7;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = false;
            this.Division.Click += new System.EventHandler(this.PressOperation);
            // 
            // Six
            // 
            this.Six.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Six.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Six.Location = new System.Drawing.Point(177, 137);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(70, 45);
            this.Six.TabIndex = 6;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = false;
            this.Six.Click += new System.EventHandler(this.PressButton);
            // 
            // Five
            // 
            this.Five.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Five.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Five.Location = new System.Drawing.Point(101, 137);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(70, 45);
            this.Five.TabIndex = 5;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = false;
            this.Five.Click += new System.EventHandler(this.PressButton);
            // 
            // Four
            // 
            this.Four.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Four.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Four.Location = new System.Drawing.Point(25, 137);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(70, 45);
            this.Four.TabIndex = 4;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = false;
            this.Four.Click += new System.EventHandler(this.PressButton);
            // 
            // Multiplication
            // 
            this.Multiplication.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplication.Location = new System.Drawing.Point(253, 137);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(70, 45);
            this.Multiplication.TabIndex = 11;
            this.Multiplication.Text = "*";
            this.Multiplication.UseVisualStyleBackColor = false;
            this.Multiplication.Click += new System.EventHandler(this.PressOperation);
            // 
            // Three
            // 
            this.Three.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Three.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Three.Location = new System.Drawing.Point(177, 188);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(70, 45);
            this.Three.TabIndex = 10;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = false;
            this.Three.Click += new System.EventHandler(this.PressButton);
            // 
            // Two
            // 
            this.Two.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Two.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Two.Location = new System.Drawing.Point(101, 188);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(70, 45);
            this.Two.TabIndex = 9;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = false;
            this.Two.Click += new System.EventHandler(this.PressButton);
            // 
            // One
            // 
            this.One.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.One.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.One.Location = new System.Drawing.Point(25, 188);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(70, 45);
            this.One.TabIndex = 8;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = false;
            this.One.Click += new System.EventHandler(this.PressButton);
            // 
            // EqualTo
            // 
            this.EqualTo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.EqualTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualTo.Location = new System.Drawing.Point(329, 188);
            this.EqualTo.Name = "EqualTo";
            this.EqualTo.Size = new System.Drawing.Size(70, 96);
            this.EqualTo.TabIndex = 15;
            this.EqualTo.Text = "=";
            this.EqualTo.UseVisualStyleBackColor = false;
            this.EqualTo.Click += new System.EventHandler(this.EqualTo_Click);
            // 
            // Addition
            // 
            this.Addition.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addition.Location = new System.Drawing.Point(253, 239);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(70, 45);
            this.Addition.TabIndex = 14;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = false;
            this.Addition.Click += new System.EventHandler(this.PressOperation);
            // 
            // Dot
            // 
            this.Dot.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dot.Location = new System.Drawing.Point(177, 239);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(70, 45);
            this.Dot.TabIndex = 13;
            this.Dot.Text = ".";
            this.Dot.UseVisualStyleBackColor = false;
            this.Dot.Click += new System.EventHandler(this.PressButton);
            // 
            // Zero
            // 
            this.Zero.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zero.Location = new System.Drawing.Point(25, 239);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(146, 45);
            this.Zero.TabIndex = 12;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = false;
            this.Zero.Click += new System.EventHandler(this.PressButton);
            // 
            // ResultScreen
            // 
            this.ResultScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultScreen.Location = new System.Drawing.Point(25, 22);
            this.ResultScreen.Name = "ResultScreen";
            this.ResultScreen.Size = new System.Drawing.Size(374, 40);
            this.ResultScreen.TabIndex = 16;
            this.ResultScreen.Text = "0";
            this.ResultScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ClearEntry
            // 
            this.ClearEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearEntry.Location = new System.Drawing.Point(329, 137);
            this.ClearEntry.Name = "ClearEntry";
            this.ClearEntry.Size = new System.Drawing.Size(70, 45);
            this.ClearEntry.TabIndex = 17;
            this.ClearEntry.Text = "CE";
            this.ClearEntry.UseVisualStyleBackColor = true;
            this.ClearEntry.Click += new System.EventHandler(this.ClearEntry_Click);
            // 
            // Subtraction
            // 
            this.Subtraction.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Subtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtraction.Location = new System.Drawing.Point(253, 188);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(70, 45);
            this.Subtraction.TabIndex = 18;
            this.Subtraction.Text = "-";
            this.Subtraction.UseVisualStyleBackColor = false;
            this.Subtraction.Click += new System.EventHandler(this.PressOperation);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(422, 305);
            this.Controls.Add(this.Subtraction);
            this.Controls.Add(this.ClearEntry);
            this.Controls.Add(this.ResultScreen);
            this.Controls.Add(this.EqualTo);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.Dot);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.AllClear);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Seven);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button AllClear;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Multiplication;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button EqualTo;
        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.Button Dot;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.TextBox ResultScreen;
        private System.Windows.Forms.Button ClearEntry;
        private System.Windows.Forms.Button Subtraction;
    }
}

