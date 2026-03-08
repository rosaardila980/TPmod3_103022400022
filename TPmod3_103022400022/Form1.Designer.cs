namespace TPmod3_103022400022
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
            lblOutput = new Label();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnPlus = new Button();
            btn0 = new Button();
            btnEquals = new Button();
            SuspendLayout();
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(12, 9);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(115, 25);
            lblOutput.TabIndex = 0;
            lblOutput.Text = "Label Output";
            // 
            // btn1
            // 
            btn1.Location = new Point(15, 37);
            btn1.Name = "btn1";
            btn1.Size = new Size(112, 34);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += ButtonNumber_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(132, 37);
            btn2.Name = "btn2";
            btn2.Size = new Size(112, 34);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += ButtonNumber_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(255, 37);
            btn3.Name = "btn3";
            btn3.Size = new Size(112, 34);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += ButtonNumber_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(15, 88);
            btn4.Name = "btn4";
            btn4.Size = new Size(112, 34);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += ButtonNumber_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(132, 88);
            btn5.Name = "btn5";
            btn5.Size = new Size(112, 34);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += ButtonNumber_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(255, 88);
            btn6.Name = "btn6";
            btn6.Size = new Size(112, 34);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += ButtonNumber_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(12, 135);
            btn7.Name = "btn7";
            btn7.Size = new Size(112, 34);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += ButtonNumber_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(132, 135);
            btn8.Name = "btn8";
            btn8.Size = new Size(112, 34);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += ButtonNumber_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(255, 135);
            btn9.Name = "btn9";
            btn9.Size = new Size(112, 34);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += ButtonNumber_Click;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(12, 190);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(112, 34);
            btnPlus.TabIndex = 10;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(132, 190);
            btn0.Name = "btn0";
            btn0.Size = new Size(112, 34);
            btn0.TabIndex = 11;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += ButtonNumber_Click;
            // 
            // btnEquals
            // 
            btnEquals.Location = new Point(255, 190);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(112, 34);
            btnEquals.TabIndex = 12;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEquals);
            Controls.Add(btn0);
            Controls.Add(btnPlus);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(lblOutput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOutput;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnPlus;
        private Button btn0;
        private Button btnEquals;
    }
}
