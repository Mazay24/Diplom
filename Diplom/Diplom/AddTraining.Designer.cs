namespace Diplom
{
    partial class AddTraining
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTraining));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            numericUpDown1 = new NumericUpDown();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(814, 481);
            button1.Name = "button1";
            button1.Size = new Size(156, 60);
            button1.TabIndex = 0;
            button1.Text = "Добавить тренировку";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(398, 21);
            label1.Name = "label1";
            label1.Size = new Size(172, 20);
            label1.TabIndex = 1;
            label1.Text = "Назввание тренировки";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(451, 112);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 2;
            label2.Text = "Тренер";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(421, 386);
            label3.Name = "label3";
            label3.Size = new Size(149, 20);
            label3.TabIndex = 3;
            label3.Text = "Мест на тренировку";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(425, 184);
            label4.Name = "label4";
            label4.Size = new Size(131, 20);
            label4.TabIndex = 4;
            label4.Text = "День тренировки";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(434, 253);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 5;
            label5.Text = "Время начала";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(425, 322);
            label6.Name = "label6";
            label6.Size = new Size(134, 20);
            label6.TabIndex = 6;
            label6.Text = "Время окончания";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(379, 44);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 55);
            textBox1.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(361, 135);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(246, 28);
            comboBox1.TabIndex = 9;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(398, 207);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(190, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(466, 410);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(53, 27);
            numericUpDown1.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "hh:mm";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(451, 276);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(81, 27);
            dateTimePicker2.TabIndex = 12;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.CustomFormat = "hh:mm";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.Location = new Point(449, 345);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.ShowUpDown = true;
            dateTimePicker3.Size = new Size(80, 27);
            dateTimePicker3.TabIndex = 13;
            // 
            // AddTraining
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(982, 553);
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
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddTraining";
            Text = "AddTraining";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown numericUpDown1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker3;
    }
}