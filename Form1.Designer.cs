namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            calcDisplay = new TextBox();
            clear = new Button();
            division = new Button();
            mutiply = new Button();
            backspace = new Button();
            seven = new Button();
            eight = new Button();
            nine = new Button();
            subtract = new Button();
            four = new Button();
            five = new Button();
            six = new Button();
            addition = new Button();
            one = new Button();
            two = new Button();
            three = new Button();
            equals = new Button();
            percent = new Button();
            zero = new Button();
            dot = new Button();
            SuspendLayout();
            // 
            // calcDisplay
            // 
            calcDisplay.BackColor = Color.LightGreen;
            calcDisplay.Font = new Font("Segoe UI", 25F);
            calcDisplay.ForeColor = SystemColors.WindowText;
            calcDisplay.Location = new Point(-3, -2);
            calcDisplay.MaxLength = 12;
            calcDisplay.MinimumSize = new Size(340, 50);
            calcDisplay.Name = "calcDisplay";
            calcDisplay.ReadOnly = true;
            calcDisplay.Size = new Size(340, 52);
            calcDisplay.TabIndex = 0;
            calcDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // clear
            // 
            clear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            clear.Location = new Point(7, 54);
            clear.Name = "clear";
            clear.Size = new Size(75, 31);
            clear.TabIndex = 1;
            clear.Text = "C";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // division
            // 
            division.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            division.Location = new Point(88, 54);
            division.Name = "division";
            division.Size = new Size(75, 31);
            division.TabIndex = 1;
            division.Text = "÷";
            division.UseVisualStyleBackColor = true;
            division.Click += operator_Click;
            // 
            // mutiply
            // 
            mutiply.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            mutiply.Location = new Point(169, 54);
            mutiply.Name = "mutiply";
            mutiply.Size = new Size(75, 31);
            mutiply.TabIndex = 1;
            mutiply.Text = "X";
            mutiply.UseVisualStyleBackColor = true;
            mutiply.Click += operator_Click;
            // 
            // backspace
            // 
            backspace.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            backspace.Location = new Point(250, 54);
            backspace.Name = "backspace";
            backspace.Size = new Size(75, 31);
            backspace.TabIndex = 1;
            backspace.Text = "<-";
            backspace.UseVisualStyleBackColor = true;
            backspace.Click += backspace_Click;
            // 
            // seven
            // 
            seven.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            seven.Location = new Point(7, 91);
            seven.Name = "seven";
            seven.Size = new Size(75, 31);
            seven.TabIndex = 1;
            seven.Text = "7";
            seven.UseVisualStyleBackColor = true;
            seven.Click += num_Click;
            // 
            // eight
            // 
            eight.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            eight.Location = new Point(88, 91);
            eight.Name = "eight";
            eight.Size = new Size(75, 31);
            eight.TabIndex = 1;
            eight.Text = "8";
            eight.UseVisualStyleBackColor = true;
            eight.Click += num_Click;
            // 
            // nine
            // 
            nine.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            nine.Location = new Point(169, 91);
            nine.Name = "nine";
            nine.Size = new Size(75, 31);
            nine.TabIndex = 1;
            nine.Text = "9";
            nine.UseVisualStyleBackColor = true;
            nine.Click += num_Click;
            // 
            // subtract
            // 
            subtract.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            subtract.Location = new Point(250, 91);
            subtract.Name = "subtract";
            subtract.Size = new Size(75, 31);
            subtract.TabIndex = 1;
            subtract.Text = "-";
            subtract.UseVisualStyleBackColor = true;
            subtract.Click += operator_Click;
            // 
            // four
            // 
            four.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            four.Location = new Point(7, 128);
            four.Name = "four";
            four.Size = new Size(75, 31);
            four.TabIndex = 1;
            four.Text = "4";
            four.UseVisualStyleBackColor = true;
            four.Click += num_Click;
            // 
            // five
            // 
            five.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            five.Location = new Point(88, 128);
            five.Name = "five";
            five.Size = new Size(75, 31);
            five.TabIndex = 1;
            five.Text = "5";
            five.UseVisualStyleBackColor = true;
            five.Click += num_Click;
            // 
            // six
            // 
            six.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            six.Location = new Point(169, 128);
            six.Name = "six";
            six.Size = new Size(75, 31);
            six.TabIndex = 1;
            six.Text = "6";
            six.UseVisualStyleBackColor = true;
            six.Click += num_Click;
            // 
            // addition
            // 
            addition.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            addition.Location = new Point(250, 128);
            addition.Name = "addition";
            addition.Size = new Size(75, 31);
            addition.TabIndex = 1;
            addition.Text = "+";
            addition.UseVisualStyleBackColor = true;
            addition.Click += operator_Click;
            // 
            // one
            // 
            one.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            one.Location = new Point(7, 165);
            one.Name = "one";
            one.Size = new Size(75, 31);
            one.TabIndex = 1;
            one.Text = "1";
            one.UseVisualStyleBackColor = true;
            one.Click += num_Click;
            // 
            // two
            // 
            two.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            two.Location = new Point(88, 165);
            two.Name = "two";
            two.Size = new Size(75, 31);
            two.TabIndex = 1;
            two.Text = "2";
            two.UseVisualStyleBackColor = true;
            two.Click += num_Click;
            // 
            // three
            // 
            three.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            three.Location = new Point(169, 165);
            three.Name = "three";
            three.Size = new Size(75, 31);
            three.TabIndex = 1;
            three.Text = "3";
            three.UseVisualStyleBackColor = true;
            three.Click += num_Click;
            // 
            // equals
            // 
            equals.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            equals.Location = new Point(250, 165);
            equals.Name = "equals";
            equals.Size = new Size(75, 68);
            equals.TabIndex = 1;
            equals.Text = "=";
            equals.UseVisualStyleBackColor = true;
            equals.Click += equals_Click;
            // 
            // percent
            // 
            percent.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            percent.Location = new Point(7, 202);
            percent.Name = "percent";
            percent.Size = new Size(75, 31);
            percent.TabIndex = 1;
            percent.Text = "%";
            percent.UseVisualStyleBackColor = true;
            // 
            // zero
            // 
            zero.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            zero.Location = new Point(88, 202);
            zero.Name = "zero";
            zero.Size = new Size(75, 31);
            zero.TabIndex = 1;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = true;
            zero.Click += num_Click;
            // 
            // dot
            // 
            dot.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dot.Location = new Point(169, 202);
            dot.Name = "dot";
            dot.Size = new Size(75, 31);
            dot.TabIndex = 1;
            dot.Text = ".";
            dot.UseVisualStyleBackColor = true;
            dot.Click += dot_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 241);
            Controls.Add(equals);
            Controls.Add(addition);
            Controls.Add(subtract);
            Controls.Add(backspace);
            Controls.Add(dot);
            Controls.Add(three);
            Controls.Add(six);
            Controls.Add(nine);
            Controls.Add(mutiply);
            Controls.Add(zero);
            Controls.Add(percent);
            Controls.Add(two);
            Controls.Add(one);
            Controls.Add(five);
            Controls.Add(four);
            Controls.Add(eight);
            Controls.Add(seven);
            Controls.Add(division);
            Controls.Add(clear);
            Controls.Add(calcDisplay);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox calcDisplay;
        private Button clear;
        private Button division;
        private Button mutiply;
        private Button backspace;
        private Button seven;
        private Button eight;
        private Button nine;
        private Button subtract;
        private Button four;
        private Button five;
        private Button six;
        private Button addition;
        private Button one;
        private Button two;
        private Button three;
        private Button equals;
        private Button percent;
        private Button zero;
        private Button dot;
    }
}
