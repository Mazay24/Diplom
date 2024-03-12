namespace NEW
{
    partial class Admin
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
            label1 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(897, 12);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 1;
            label1.Text = "Создание записи";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(937, 79);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 10;
            label4.Text = "Статус";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(706, 175);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(528, 205);
            textBox1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(897, 152);
            label3.Name = "label3";
            label3.Size = new Size(157, 20);
            label3.TabIndex = 8;
            label3.Text = "Описание проблемы";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Новая", "Требует выезда", "Закрыта" });
            comboBox1.Location = new Point(871, 102);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(193, 28);
            comboBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(883, 411);
            button1.Name = "button1";
            button1.Size = new Size(200, 48);
            button1.TabIndex = 11;
            button1.Text = "Отправить заявку";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(577, 496);
            dataGridView1.TabIndex = 12;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1290, 520);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private TextBox textBox1;
        private Label label3;
        private ComboBox comboBox1;
        private Button button1;
        private DataGridView dataGridView1;
    }
}