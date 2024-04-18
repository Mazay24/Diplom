namespace Diplom2
{
    partial class UpdateSubscription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateSubscription));
            button1 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(824, 492);
            button1.Name = "button1";
            button1.Size = new Size(146, 49);
            button1.TabIndex = 17;
            button1.Text = "Обновить данные";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(305, 276);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(194, 53);
            textBox4.TabIndex = 16;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(84, 276);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(194, 53);
            textBox3.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(558, 174);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(381, 155);
            textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(84, 174);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 53);
            textBox1.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(363, 253);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 12;
            label4.Text = "Заморозка";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(139, 253);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 11;
            label3.Text = "Срок действия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(709, 151);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 10;
            label2.Text = "Описание";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 151);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 9;
            label1.Text = "Название";
            // 
            // button2
            // 
            button2.Location = new Point(664, 492);
            button2.Name = "button2";
            button2.Size = new Size(146, 49);
            button2.TabIndex = 18;
            button2.Text = "Удалить абонемент";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(381, 151);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 19;
            label5.Text = "Цена";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(305, 175);
            numericUpDown1.Maximum = new decimal(new int[] { 9000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(194, 27);
            numericUpDown1.TabIndex = 20;
            // 
            // UpdateSubscription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(982, 553);
            Controls.Add(numericUpDown1);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UpdateSubscription";
            Text = "UpdateSubscription";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private Label label5;
        private NumericUpDown numericUpDown1;
    }
}