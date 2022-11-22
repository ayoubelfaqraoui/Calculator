namespace Calculator
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
            this.UserInput = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.equals = new System.Windows.Forms.Button();
            this.divise = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.multiple = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.ce = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInput
            // 
            this.UserInput.BackColor = System.Drawing.SystemColors.Menu;
            this.UserInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInput.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.UserInput.Location = new System.Drawing.Point(28, 41);
            this.UserInput.Multiline = true;
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(369, 33);
            this.UserInput.TabIndex = 0;
            this.UserInput.Text = "0";
            this.UserInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.UserInput.TextChanged += new System.EventHandler(this.UserInput_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.equals, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.divise, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.zero, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.dot, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.plus, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.three, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.two, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.one, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.minus, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.six, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.five, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.four, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.multiple, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.nine, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.eight, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.seven, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ce, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.delete, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-7, 80);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(422, 375);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // equals
            // 
            this.equals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equals.Location = new System.Drawing.Point(318, 303);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(101, 69);
            this.equals.TabIndex = 19;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // divise
            // 
            this.divise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divise.Location = new System.Drawing.Point(213, 303);
            this.divise.Name = "divise";
            this.divise.Size = new System.Drawing.Size(99, 69);
            this.divise.TabIndex = 18;
            this.divise.Text = "/";
            this.divise.UseVisualStyleBackColor = true;
            this.divise.Click += new System.EventHandler(this.operator_Click);
            // 
            // zero
            // 
            this.zero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zero.Location = new System.Drawing.Point(108, 303);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(99, 69);
            this.zero.TabIndex = 17;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.button_Click);
            // 
            // dot
            // 
            this.dot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dot.Location = new System.Drawing.Point(3, 303);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(99, 69);
            this.dot.TabIndex = 16;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // plus
            // 
            this.plus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plus.Location = new System.Drawing.Point(318, 228);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(101, 69);
            this.plus.TabIndex = 15;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.operator_Click);
            // 
            // three
            // 
            this.three.Dock = System.Windows.Forms.DockStyle.Fill;
            this.three.Location = new System.Drawing.Point(213, 228);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(99, 69);
            this.three.TabIndex = 14;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.button_Click);
            // 
            // two
            // 
            this.two.Dock = System.Windows.Forms.DockStyle.Fill;
            this.two.Location = new System.Drawing.Point(108, 228);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(99, 69);
            this.two.TabIndex = 13;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.button_Click);
            // 
            // one
            // 
            this.one.Dock = System.Windows.Forms.DockStyle.Fill;
            this.one.Location = new System.Drawing.Point(3, 228);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(99, 69);
            this.one.TabIndex = 12;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.button_Click);
            // 
            // minus
            // 
            this.minus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minus.Location = new System.Drawing.Point(318, 153);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(101, 69);
            this.minus.TabIndex = 11;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.operator_Click);
            // 
            // six
            // 
            this.six.Dock = System.Windows.Forms.DockStyle.Fill;
            this.six.Location = new System.Drawing.Point(213, 153);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(99, 69);
            this.six.TabIndex = 10;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.button_Click);
            // 
            // five
            // 
            this.five.Dock = System.Windows.Forms.DockStyle.Fill;
            this.five.Location = new System.Drawing.Point(108, 153);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(99, 69);
            this.five.TabIndex = 9;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.button_Click);
            // 
            // four
            // 
            this.four.Dock = System.Windows.Forms.DockStyle.Fill;
            this.four.Location = new System.Drawing.Point(3, 153);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(99, 69);
            this.four.TabIndex = 8;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.button_Click);
            // 
            // multiple
            // 
            this.multiple.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiple.Location = new System.Drawing.Point(318, 78);
            this.multiple.Name = "multiple";
            this.multiple.Size = new System.Drawing.Size(101, 69);
            this.multiple.TabIndex = 7;
            this.multiple.Text = "*";
            this.multiple.UseVisualStyleBackColor = true;
            this.multiple.Click += new System.EventHandler(this.operator_Click);
            // 
            // nine
            // 
            this.nine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nine.Location = new System.Drawing.Point(213, 78);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(99, 69);
            this.nine.TabIndex = 6;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.button_Click);
            // 
            // eight
            // 
            this.eight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eight.Location = new System.Drawing.Point(108, 78);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(99, 69);
            this.eight.TabIndex = 5;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.button_Click);
            // 
            // seven
            // 
            this.seven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seven.Location = new System.Drawing.Point(3, 78);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(99, 69);
            this.seven.TabIndex = 4;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.button_Click);
            // 
            // ce
            // 
            this.ce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ce.Location = new System.Drawing.Point(213, 3);
            this.ce.Name = "ce";
            this.ce.Size = new System.Drawing.Size(99, 69);
            this.ce.TabIndex = 3;
            this.ce.Text = "ce";
            this.ce.UseVisualStyleBackColor = true;
            this.ce.Click += new System.EventHandler(this.ce_Click);
            // 
            // delete
            // 
            this.delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delete.Location = new System.Drawing.Point(318, 3);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(101, 69);
            this.delete.TabIndex = 0;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "entrer opération pour calculer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.UserInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button divise;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button multiple;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button ce;
        private System.Windows.Forms.Label label1;
    }
}

