namespace ThucHanhBuoi1
{
    partial class Bai6
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
            txbA = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            txbB = new TextBox();
            label2 = new Label();
            cmbPhepTinh = new ComboBox();
            btnCalculate = new Button();
            btnDel = new Button();
            btnExit = new Button();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txbA);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(65, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(459, 101);
            panel1.TabIndex = 0;
            // 
            // txbA
            // 
            txbA.Location = new Point(156, 28);
            txbA.Name = "txbA";
            txbA.Size = new Size(200, 39);
            txbA.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 29);
            label1.Name = "label1";
            label1.Size = new Size(120, 36);
            label1.TabIndex = 1;
            label1.Text = "Nhập A:";
            // 
            // panel2
            // 
            panel2.Controls.Add(txbB);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(648, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(459, 101);
            panel2.TabIndex = 1;
            // 
            // txbB
            // 
            txbB.Location = new Point(156, 28);
            txbB.Name = "txbB";
            txbB.Size = new Size(200, 39);
            txbB.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 29);
            label2.Name = "label2";
            label2.Size = new Size(121, 36);
            label2.TabIndex = 1;
            label2.Text = "Nhập B:";
            // 
            // cmbPhepTinh
            // 
            cmbPhepTinh.FormattingEnabled = true;
            cmbPhepTinh.Location = new Point(418, 256);
            cmbPhepTinh.Name = "cmbPhepTinh";
            cmbPhepTinh.Size = new Size(355, 40);
            cmbPhepTinh.TabIndex = 2;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(271, 369);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(150, 46);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Tính";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(536, 369);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(150, 46);
            btnDel.TabIndex = 4;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(804, 369);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 46);
            btnExit.TabIndex = 5;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(139, 487);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(925, 356);
            listBox1.TabIndex = 6;
            // 
            // Bai6
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 924);
            Controls.Add(listBox1);
            Controls.Add(btnExit);
            Controls.Add(btnDel);
            Controls.Add(btnCalculate);
            Controls.Add(cmbPhepTinh);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Bai6";
            Text = "Bai6";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txbA;
        private Label label1;
        private Panel panel2;
        private TextBox txbB;
        private Label label2;
        private ComboBox cmbPhepTinh;
        private Button btnCalculate;
        private Button btnDel;
        private Button btnExit;
        private ListBox listBox1;
    }
}