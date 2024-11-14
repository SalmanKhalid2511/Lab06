namespace Lab7Ex1
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
            label1 = new Label();
            textboxNum1 = new TextBox();
            textBoxNum2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBoxResult = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(199, 45);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 2;
            label1.Text = "Enter number 1";
            label1.Click += label1_Click;
            // 
            // textboxNum1
            // 
            textboxNum1.AcceptsTab = true;
            textboxNum1.BackColor = SystemColors.Window;
            textboxNum1.BorderStyle = BorderStyle.None;
            textboxNum1.Location = new Point(326, 45);
            textboxNum1.Name = "textboxNum1";
            textboxNum1.Size = new Size(125, 20);
            textboxNum1.TabIndex = 3;
            // 
            // textBoxNum2
            // 
            textBoxNum2.Location = new Point(326, 122);
            textBoxNum2.Name = "textBoxNum2";
            textBoxNum2.Size = new Size(125, 27);
            textBoxNum2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 125);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 5;
            label2.Text = "Enter number 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 212);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 6;
            label3.Text = "Result";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(326, 212);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(125, 27);
            textBoxResult.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(162, 326);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(293, 326);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "Subtract";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(435, 326);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 10;
            button3.Text = "Multiply";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(575, 326);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 11;
            button4.Text = "Divide";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxResult);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxNum2);
            Controls.Add(textboxNum1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textboxNum1;
        private TextBox textBoxNum2;
        private Label label2;
        private Label label3;
        private TextBox textBoxResult;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
