namespace ThucHanhBuoi1
{
    partial class Bai9
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
            txbFoodName = new TextBox();
            btnAdd = new Button();
            btnDel = new Button();
            btnFind = new Button();
            listboxFoodName = new ListBox();
            label2 = new Label();
            txbResult = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 52);
            label1.Name = "label1";
            label1.Size = new Size(183, 33);
            label1.TabIndex = 0;
            label1.Text = "Nhập tên món:";
            // 
            // txbFoodName
            // 
            txbFoodName.Location = new Point(236, 49);
            txbFoodName.Name = "txbFoodName";
            txbFoodName.Size = new Size(371, 39);
            txbFoodName.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(38, 148);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(246, 148);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(150, 46);
            btnDel.TabIndex = 3;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(457, 148);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(150, 46);
            btnFind.TabIndex = 4;
            btnFind.Text = "Tìm món";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // listboxFoodName
            // 
            listboxFoodName.FormattingEnabled = true;
            listboxFoodName.Location = new Point(760, 49);
            listboxFoodName.Name = "listboxFoodName";
            listboxFoodName.Size = new Size(485, 388);
            listboxFoodName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(236, 549);
            label2.Name = "label2";
            label2.Size = new Size(158, 33);
            label2.TabIndex = 6;
            label2.Text = "Hôm nay ăn:";
            // 
            // txbResult
            // 
            txbResult.Location = new Point(419, 546);
            txbResult.Name = "txbResult";
            txbResult.ReadOnly = true;
            txbResult.Size = new Size(404, 39);
            txbResult.TabIndex = 8;
            // 
            // Bai9
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1292, 675);
            Controls.Add(txbResult);
            Controls.Add(label2);
            Controls.Add(listboxFoodName);
            Controls.Add(btnFind);
            Controls.Add(btnDel);
            Controls.Add(btnAdd);
            Controls.Add(txbFoodName);
            Controls.Add(label1);
            Name = "Bai9";
            Text = "Bai9";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbFoodName;
        private Button btnAdd;
        private Button btnDel;
        private Button btnFind;
        private ListBox listboxFoodName;
        private Label label2;
        private TextBox txbResult;
    }
}