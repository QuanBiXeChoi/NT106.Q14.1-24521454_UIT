namespace ThucHanhBuoi1
{
    partial class Bai3
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
            label2 = new Label();
            btnRead = new Button();
            btnDel = new Button();
            btnExit = new Button();
            tb1 = new TextBox();
            tb2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 346);
            label1.Name = "label1";
            label1.Size = new Size(122, 36);
            label1.TabIndex = 0;
            label1.Text = "Kết quả:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 98);
            label2.Name = "label2";
            label2.Size = new Size(565, 49);
            label2.TabIndex = 1;
            label2.Text = "Nhập vào số nguyên từ 0 đến 9:";
            label2.Click += label2_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(779, 146);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(150, 46);
            btnRead.TabIndex = 2;
            btnRead.Text = "Đọc";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(779, 263);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(150, 46);
            btnDel.TabIndex = 3;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(779, 378);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 46);
            btnExit.TabIndex = 4;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // tb1
            // 
            tb1.Location = new Point(377, 164);
            tb1.Name = "tb1";
            tb1.Size = new Size(200, 39);
            tb1.TabIndex = 5;
            tb1.TextChanged += tb1_TextChanged;
            tb1.KeyPress += tb1_KeyPress;
            // 
            // tb2
            // 
            tb2.Location = new Point(27, 405);
            tb2.Name = "tb2";
            tb2.ReadOnly = true;
            tb2.Size = new Size(200, 39);
            tb2.TabIndex = 6;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 596);
            Controls.Add(tb2);
            Controls.Add(tb1);
            Controls.Add(btnExit);
            Controls.Add(btnDel);
            Controls.Add(btnRead);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bai3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bai3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnRead;
        private Button btnDel;
        private Button btnExit;
        private TextBox tb1;
        private TextBox tb2;
    }
}