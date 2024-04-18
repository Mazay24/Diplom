namespace Diplom2
{
    partial class UpdateTraining
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateTraining));
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            numericUpDown1 = new NumericUpDown();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.CustomFormat = "HH:mm";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.Location = new Point(461, 351);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.ShowUpDown = true;
            dateTimePicker3.Size = new Size(80, 27);
            dateTimePicker3.TabIndex = 25;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "HH:mm";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(463, 282);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(81, 27);
            dateTimePicker2.TabIndex = 24;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(478, 416);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(53, 27);
            numericUpDown1.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(410, 213);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(190, 27);
            dateTimePicker1.TabIndex = 22;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(373, 141);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(246, 28);
            comboBox1.TabIndex = 21;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(391, 50);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 55);
            textBox1.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(437, 328);
            label6.Name = "label6";
            label6.Size = new Size(134, 20);
            label6.TabIndex = 19;
            label6.Text = "Время окончания";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(446, 259);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 18;
            label5.Text = "Время начала";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(437, 190);
            label4.Name = "label4";
            label4.Size = new Size(131, 20);
            label4.TabIndex = 17;
            label4.Text = "День тренировки";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(433, 392);
            label3.Name = "label3";
            label3.Size = new Size(149, 20);
            label3.TabIndex = 16;
            label3.Text = "Мест на тренировку";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(463, 118);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 15;
            label2.Text = "Тренер";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(410, 27);
            label1.Name = "label1";
            label1.Size = new Size(172, 20);
            label1.TabIndex = 14;
            label1.Text = "Назввание тренировки";
            // 
            // button1
            // 
            button1.Location = new Point(814, 481);
            button1.Name = "button1";
            button1.Size = new Size(156, 60);
            button1.TabIndex = 26;
            button1.Text = "Обновить тренировку";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(643, 481);
            button2.Name = "button2";
            button2.Size = new Size(156, 60);
            button2.TabIndex = 27;
            button2.Text = "Удалить тренировку";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // UpdateTraining
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(982, 553);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker3);
            Controls.Add(dateTimePicker2);
            Controls.Add(numericUpDown1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UpdateTraining";
            Text = "UpdateTraining";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker2;
        private NumericUpDown numericUpDown1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}