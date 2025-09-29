namespace ThucHanhBuoi1
{
    partial class Bai7
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
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            btnCalculate = new Button();
            ShowResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SlateBlue;
            label1.Location = new Point(181, 41);
            label1.Name = "label1";
            label1.Size = new Size(675, 61);
            label1.TabIndex = 0;
            label1.Text = "Bạn thuộc cung hoàng đạo gì?";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(464, 162);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(400, 39);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 167);
            label2.Name = "label2";
            label2.Size = new Size(277, 32);
            label2.TabIndex = 2;
            label2.Text = "Chọn ngày sinh của bạn:";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(390, 296);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(248, 46);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Cung gì ta?????";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // ShowResult
            // 
            ShowResult.AutoSize = true;
            ShowResult.Font = new Font("Times New Roman", 10.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ShowResult.Location = new Point(271, 417);
            ShowResult.Name = "ShowResult";
            ShowResult.Size = new Size(0, 33);
            ShowResult.TabIndex = 4;
            // 
            // Bai7
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 555);
            Controls.Add(ShowResult);
            Controls.Add(btnCalculate);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Name = "Bai7";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bai7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Button btnCalculate;
        private Label ShowResult;
    }
}