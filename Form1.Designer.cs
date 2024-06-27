namespace WinFormsApp_Calculator

{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox displayTextBox;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonClear;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            displayTextBox = new TextBox();
            button0 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonAdd = new Button();
            buttonSubtract = new Button();
            buttonMultiply = new Button();
            buttonDivide = new Button();
            buttonEquals = new Button();
            buttonClear = new Button();
            SuspendLayout();
            // 
            // displayTextBox
            // 
            displayTextBox.Location = new Point(16, 64);
            displayTextBox.Margin = new Padding(4, 5, 4, 5);
            displayTextBox.Name = "displayTextBox";
            displayTextBox.Size = new Size(400, 27);
            displayTextBox.TabIndex = 0;
            displayTextBox.TextChanged += displayTextBox_TextChanged;
            // 
            // button0
            // 
            button0.Location = new Point(16, 444);
            button0.Margin = new Padding(4, 5, 4, 5);
            button0.Name = "button0";
            button0.Size = new Size(80, 92);
            button0.TabIndex = 1;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button_Click;
            // 
            // button1
            // 
            button1.Location = new Point(16, 321);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(80, 92);
            button1.TabIndex = 2;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Click;
            // 
            // button2
            // 
            button2.Location = new Point(115, 321);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(80, 92);
            button2.TabIndex = 3;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_Click;
            // 
            // button3
            // 
            button3.Location = new Point(221, 321);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(80, 92);
            button3.TabIndex = 4;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_Click;
            // 
            // button4
            // 
            button4.Location = new Point(13, 219);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(80, 92);
            button4.TabIndex = 5;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_Click;
            // 
            // button5
            // 
            button5.Location = new Point(115, 219);
            button5.Margin = new Padding(4, 5, 4, 5);
            button5.Name = "button5";
            button5.Size = new Size(80, 92);
            button5.TabIndex = 6;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button_Click;
            // 
            // button6
            // 
            button6.Location = new Point(221, 219);
            button6.Margin = new Padding(4, 5, 4, 5);
            button6.Name = "button6";
            button6.Size = new Size(80, 92);
            button6.TabIndex = 7;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_Click;
            // 
            // button7
            // 
            button7.Location = new Point(16, 117);
            button7.Margin = new Padding(4, 5, 4, 5);
            button7.Name = "button7";
            button7.Size = new Size(80, 92);
            button7.TabIndex = 8;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_Click;
            // 
            // button8
            // 
            button8.Location = new Point(115, 117);
            button8.Margin = new Padding(4, 5, 4, 5);
            button8.Name = "button8";
            button8.Size = new Size(80, 92);
            button8.TabIndex = 9;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_Click;
            // 
            // button9
            // 
            button9.Location = new Point(221, 117);
            button9.Margin = new Padding(4, 5, 4, 5);
            button9.Name = "button9";
            button9.Size = new Size(80, 92);
            button9.TabIndex = 10;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(221, 444);
            buttonAdd.Margin = new Padding(4, 5, 4, 5);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(80, 92);
            buttonAdd.TabIndex = 11;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += operator_Click;
            // 
            // buttonSubtract
            // 
            buttonSubtract.Location = new Point(322, 117);
            buttonSubtract.Margin = new Padding(4, 5, 4, 5);
            buttonSubtract.Name = "buttonSubtract";
            buttonSubtract.Size = new Size(80, 92);
            buttonSubtract.TabIndex = 12;
            buttonSubtract.Text = "-";
            buttonSubtract.UseVisualStyleBackColor = true;
            buttonSubtract.Click += operator_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Location = new Point(322, 219);
            buttonMultiply.Margin = new Padding(4, 5, 4, 5);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(80, 92);
            buttonMultiply.TabIndex = 13;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += operator_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.Location = new Point(322, 321);
            buttonDivide.Margin = new Padding(4, 5, 4, 5);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(80, 92);
            buttonDivide.TabIndex = 14;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += operator_Click;
            // 
            // buttonEquals
            // 
            buttonEquals.Location = new Point(322, 444);
            buttonEquals.Margin = new Padding(4, 5, 4, 5);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(80, 92);
            buttonEquals.TabIndex = 15;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = true;
            buttonEquals.Click += buttonEquals_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(115, 444);
            buttonClear.Margin = new Padding(4, 5, 4, 5);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(80, 92);
            buttonClear.TabIndex = 16;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 569);
            Controls.Add(buttonClear);
            Controls.Add(buttonEquals);
            Controls.Add(buttonDivide);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonSubtract);
            Controls.Add(buttonAdd);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button0);
            Controls.Add(displayTextBox);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Basic Calculator";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
