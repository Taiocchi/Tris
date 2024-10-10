namespace Thread_form1
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
            components = new System.ComponentModel.Container();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            label1 = new Label();
            label_turno = new Label();
            tempo_rimanente = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Font = new Font("Ravie", 36F, FontStyle.Bold);
            btn1.ForeColor = Color.Black;
            btn1.Location = new Point(50, 50);
            btn1.Name = "btn1";
            btn1.Size = new Size(100, 100);
            btn1.TabIndex = 0;
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Ravie", 36F, FontStyle.Bold);
            btn2.ForeColor = Color.Black;
            btn2.Location = new Point(150, 50);
            btn2.Name = "btn2";
            btn2.Size = new Size(100, 100);
            btn2.TabIndex = 1;
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn1_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Ravie", 36F, FontStyle.Bold);
            btn3.ForeColor = Color.Black;
            btn3.Location = new Point(250, 50);
            btn3.Name = "btn3";
            btn3.Size = new Size(100, 100);
            btn3.TabIndex = 3;
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn1_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Ravie", 36F, FontStyle.Bold);
            btn4.ForeColor = Color.Black;
            btn4.Location = new Point(50, 150);
            btn4.Name = "btn4";
            btn4.Size = new Size(100, 100);
            btn4.TabIndex = 2;
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn1_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Ravie", 36F, FontStyle.Bold);
            btn5.ForeColor = Color.Black;
            btn5.Location = new Point(150, 150);
            btn5.Name = "btn5";
            btn5.Size = new Size(100, 100);
            btn5.TabIndex = 5;
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn1_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Ravie", 36F, FontStyle.Bold);
            btn6.ForeColor = Color.Black;
            btn6.Location = new Point(250, 150);
            btn6.Name = "btn6";
            btn6.Size = new Size(100, 100);
            btn6.TabIndex = 4;
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn1_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Ravie", 36F, FontStyle.Bold);
            btn7.ForeColor = Color.Black;
            btn7.Location = new Point(50, 250);
            btn7.Name = "btn7";
            btn7.Size = new Size(100, 100);
            btn7.TabIndex = 8;
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn1_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Ravie", 36F, FontStyle.Bold);
            btn8.ForeColor = Color.Black;
            btn8.Location = new Point(150, 250);
            btn8.Name = "btn8";
            btn8.Size = new Size(100, 100);
            btn8.TabIndex = 7;
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn1_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Ravie", 36F, FontStyle.Bold);
            btn9.ForeColor = Color.Black;
            btn9.Location = new Point(250, 250);
            btn9.Name = "btn9";
            btn9.Size = new Size(100, 100);
            btn9.TabIndex = 6;
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 387);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 9;
            label1.Text = "E' il turno di";
            // 
            // label_turno
            // 
            label_turno.AutoSize = true;
            label_turno.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_turno.Location = new Point(156, 378);
            label_turno.Name = "label_turno";
            label_turno.Size = new Size(143, 32);
            label_turno.TabIndex = 10;
            label_turno.Text = "label_turno";
            // 
            // tempo_rimanente
            // 
            tempo_rimanente.AutoSize = true;
            tempo_rimanente.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tempo_rimanente.Location = new Point(383, 196);
            tempo_rimanente.Name = "tempo_rimanente";
            tempo_rimanente.Size = new Size(209, 30);
            tempo_rimanente.TabIndex = 11;
            tempo_rimanente.Text = "Tempo rimanente: 3";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 411);
            Controls.Add(tempo_rimanente);
            Controls.Add(label_turno);
            Controls.Add(label1);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn3);
            Controls.Add(btn4);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Label label1;
        private Label label_turno;
        private Label tempo_rimanente;
        private System.Windows.Forms.Timer timer1;
    }
}
