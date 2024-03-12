namespace Diplom
{
    partial class Profil
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
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            button2 = new Button();
            textBox6 = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(64, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 168);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(396, 32);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 65);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(490, 9);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 2;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(488, 100);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 3;
            label2.Text = "Описание";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(333, 121);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(402, 82);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(476, 219);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 5;
            label3.Text = "Время работы";
            label3.Click += label3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(406, 242);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(253, 163);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(130, 315);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 7;
            label4.Text = "Телефон";
            // 
            // button1
            // 
            button1.Location = new Point(79, 183);
            button1.Name = "button1";
            button1.Size = new Size(137, 37);
            button1.TabIndex = 8;
            button1.Text = "Изменить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(46, 338);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(253, 27);
            textBox4.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(145, 385);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 10;
            label5.Text = "Соц.Сети";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(46, 408);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(253, 27);
            textBox5.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(650, 453);
            button2.Name = "button2";
            button2.Size = new Size(138, 45);
            button2.TabIndex = 12;
            button2.Text = "Сохранить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(46, 270);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(253, 27);
            textBox6.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(145, 247);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 14;
            label6.Text = "Адрес";
            // 
            // Profil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(label6);
            Controls.Add(textBox6);
            Controls.Add(button2);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "Profil";
            Text = "Profil";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private Button button1;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Button button2;
        private TextBox textBox6;
        private Label label6;
    }
}