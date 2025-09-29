
namespace ThucHanhBuoi1
{
    partial class Bai1
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
            panel1 = new Panel();
            label2 = new Label();
            tbso1 = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            tbso2 = new TextBox();
            panel3 = new Panel();
            label4 = new Label();
            tbkq = new TextBox();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbso1);
            panel1.Location = new Point(113, 146);
            panel1.Name = "panel1";
            panel1.Size = new Size(847, 120);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 45);
            label2.Name = "label2";
            label2.Size = new Size(327, 49);
            label2.TabIndex = 1;
            label2.Text = "Nhập số thứ nhất:";
            label2.Click += label2_Click;
            // 
            // tbso1
            // 
            tbso1.Location = new Point(418, 55);
            tbso1.Name = "tbso1";
            tbso1.Size = new Size(400, 39);
            tbso1.TabIndex = 0;
            tbso1.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightCyan;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Peru;
            label1.Location = new Point(360, 58);
            label1.Name = "label1";
            label1.Size = new Size(394, 55);
            label1.TabIndex = 1;
            label1.Text = "Tổng hai số nguyên";
            label1.Click += label1_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(tbso2);
            panel2.Location = new Point(113, 272);
            panel2.Name = "panel2";
            panel2.Size = new Size(847, 119);
            panel2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 45);
            label3.Name = "label3";
            label3.Size = new Size(317, 49);
            label3.TabIndex = 1;
            label3.Text = "Nhập số thứ hai :";
            // 
            // tbso2
            // 
            tbso2.Location = new Point(418, 55);
            tbso2.Name = "tbso2";
            tbso2.Size = new Size(400, 39);
            tbso2.TabIndex = 0;
            tbso2.TextAlign = HorizontalAlignment.Right;
            // 
            // panel3
            // 
            panel3.Controls.Add(label4);
            panel3.Controls.Add(tbkq);
            panel3.Location = new Point(113, 458);
            panel3.Name = "panel3";
            panel3.Size = new Size(847, 119);
            panel3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(214, 45);
            label4.Name = "label4";
            label4.Size = new Size(123, 49);
            label4.TabIndex = 1;
            label4.Text = "Tổng:";
            // 
            // tbkq
            // 
            tbkq.Location = new Point(418, 55);
            tbkq.Name = "tbkq";
            tbkq.ReadOnly = true;
            tbkq.Size = new Size(400, 39);
            tbkq.TabIndex = 0;
            tbkq.TextAlign = HorizontalAlignment.Right;
            tbkq.TextChanged += tbkq_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(920, 608);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 4;
            button1.Text = "Tính";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 691);
            Controls.Add(button1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Bai1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bai1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private TextBox tbso1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private TextBox tbso2;
        private Panel panel3;
        private Label label4;
        private TextBox tbkq;
        private Button button1;
    }
}