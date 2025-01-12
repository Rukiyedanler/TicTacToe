namespace tictactoee
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
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 48F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(235, 152);
            label1.Name = "label1";
            label1.Size = new Size(308, 98);
            label1.TabIndex = 0;
            label1.Text = "TICTACO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(81, 288);
            label2.Name = "label2";
            label2.Size = new Size(617, 42);
            label2.TabIndex = 1;
            label2.Text = "lütfen başlamadan önce oyun modu seçiniz";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Impact", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(275, 393);
            button1.Name = "button1";
            button1.Size = new Size(237, 85);
            button1.TabIndex = 11;
            button1.Text = "3×3";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Impact", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.White;
            button2.Location = new Point(275, 504);
            button2.Name = "button2";
            button2.Size = new Size(237, 85);
            button2.TabIndex = 12;
            button2.Text = "5×5";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Font = new Font("Impact", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.ForeColor = Color.White;
            button3.Location = new Point(275, 620);
            button3.Name = "button3";
            button3.Size = new Size(237, 85);
            button3.TabIndex = 13;
            button3.Text = "7×7";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.FlatStyle = FlatStyle.System;
            button4.Font = new Font("Impact", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.ForeColor = Color.White;
            button4.Location = new Point(748, 12);
            button4.Name = "button4";
            button4.Size = new Size(40, 44);
            button4.TabIndex = 14;
            button4.Text = "×";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(button4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 73);
            panel1.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 35, 40);
            ClientSize = new Size(800, 800);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "AnaMenü";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel1;
    }
}
