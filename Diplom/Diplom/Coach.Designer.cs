
namespace Diplom
{
    partial class Coach
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
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(60, 56);
            button1.Name = "button1";
            button1.Size = new Size(227, 63);
            button1.TabIndex = 3;
            button1.Text = "Добавить тренера";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(346, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(598, 507);
            flowLayoutPanel1.TabIndex = 4;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // Coach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 520);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button1);
            Name = "Coach";
            Text = "Coach";
            ResumeLayout(false);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

#endregion
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}