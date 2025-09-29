namespace ThucHanhBuoi1
{
    partial class Bai4
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
            tb2 = new TextBox();
            tb1 = new TextBox();
            btnExit = new Button();
            btnDel = new Button();
            btnRead = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // tb2
            // 
            tb2.Location = new Point(81, 489);
            tb2.Name = "tb2";
            tb2.ReadOnly = true;
            tb2.Size = new Size(902, 39);
            tb2.TabIndex = 13;
            // 
            // tb1
            // 
            tb1.Location = new Point(375, 198);
            tb1.Name = "tb1";
            tb1.Size = new Size(400, 39);
            tb1.TabIndex = 12;
            tb1.TextChanged += tb1_TextChanged;
            tb1.KeyPress += tb1_KeyPress;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(833, 412);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 46);
            btnExit.TabIndex = 11;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(833, 297);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(150, 46);
            btnDel.TabIndex = 10;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(833, 180);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(150, 46);
            btnRead.TabIndex = 9;
            btnRead.Text = "Đọc";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(81, 132);
            label2.Name = "label2";
            label2.Size = new Size(710, 49);
            label2.TabIndex = 8;
            label2.Text = "Nhập vào số nguyên 12 kí tự từ 0 đến 9:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(81, 417);
            label1.Name = "label1";
            label1.Size = new Size(122, 36);
            label1.TabIndex = 7;
            label1.Text = "Kết quả:";
            // 
            // Bai4
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 607);
            Controls.Add(tb2);
            Controls.Add(tb1);
            Controls.Add(btnExit);
            Controls.Add(btnDel);
            Controls.Add(btnRead);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bai4";
            Text = "Bai4";
            Load += Bai4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb2;
        private TextBox tb1;
        private Button btnExit;
        private Button btnDel;
        private Button btnRead;
        private Label label2;
        private Label label1;
    }
}