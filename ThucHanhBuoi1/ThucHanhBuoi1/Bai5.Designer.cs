
namespace ThucHanhBuoi1
{
    partial class Bai5
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
            txbName = new TextBox();
            label3 = new Label();
            cmbMovie = new ComboBox();
            cmbRoom = new ComboBox();
            label4 = new Label();
            cmbSeat = new ComboBox();
            label5 = new Label();
            btnAdd = new Button();
            btnBill = new Button();
            listboxmovieticket = new ListBox();
            label6 = new Label();
            btnDel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(578, 53);
            label1.Name = "label1";
            label1.Size = new Size(351, 55);
            label1.TabIndex = 0;
            label1.Text = "Đặt vé xem phim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(85, 160);
            label2.Name = "label2";
            label2.Size = new Size(147, 42);
            label2.TabIndex = 1;
            label2.Text = "Họ Tên: ";
            // 
            // txbName
            // 
            txbName.Location = new Point(314, 160);
            txbName.Name = "txbName";
            txbName.Size = new Size(433, 39);
            txbName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(85, 251);
            label3.Name = "label3";
            label3.Size = new Size(195, 42);
            label3.TabIndex = 3;
            label3.Text = "Chọn Phim:";
            // 
            // cmbMovie
            // 
            cmbMovie.FormattingEnabled = true;
            cmbMovie.Location = new Point(314, 251);
            cmbMovie.Name = "cmbMovie";
            cmbMovie.Size = new Size(433, 40);
            cmbMovie.TabIndex = 4;
            cmbMovie.SelectedIndexChanged += cmbMovie_SelectedIndexChanged;
            // 
            // cmbRoom
            // 
            cmbRoom.FormattingEnabled = true;
            cmbRoom.Location = new Point(314, 343);
            cmbRoom.Name = "cmbRoom";
            cmbRoom.Size = new Size(433, 40);
            cmbRoom.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(85, 343);
            label4.Name = "label4";
            label4.Size = new Size(212, 42);
            label4.TabIndex = 5;
            label4.Text = "Chọn Phòng:";
            // 
            // cmbSeat
            // 
            cmbSeat.FormattingEnabled = true;
            cmbSeat.Location = new Point(314, 440);
            cmbSeat.Name = "cmbSeat";
            cmbSeat.Size = new Size(433, 40);
            cmbSeat.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(85, 440);
            label5.Name = "label5";
            label5.Size = new Size(178, 42);
            label5.TabIndex = 7;
            label5.Text = "Chọn Ghế:";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(147, 554);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Thêm vé";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnBill
            // 
            btnBill.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBill.Location = new Point(462, 554);
            btnBill.Name = "btnBill";
            btnBill.Size = new Size(150, 46);
            btnBill.TabIndex = 11;
            btnBill.Text = "Thanh toán";
            btnBill.UseVisualStyleBackColor = true;
            btnBill.Click += btnBill_Click;
            // 
            // listboxmovieticket
            // 
            listboxmovieticket.FormattingEnabled = true;
            listboxmovieticket.HorizontalScrollbar = true;
            listboxmovieticket.Location = new Point(844, 219);
            listboxmovieticket.Name = "listboxmovieticket";
            listboxmovieticket.ScrollAlwaysVisible = true;
            listboxmovieticket.Size = new Size(625, 260);
            listboxmovieticket.TabIndex = 12;
            listboxmovieticket.SelectedIndexChanged += listboxmovieticket_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(844, 160);
            label6.Name = "label6";
            label6.Size = new Size(252, 42);
            label6.TabIndex = 13;
            label6.Text = "Các vé đã chọn:";
            // 
            // btnDel
            // 
            btnDel.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDel.Location = new Point(779, 554);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(150, 46);
            btnDel.TabIndex = 16;
            btnDel.Text = "Xóa vé";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // Bai5
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1510, 822);
            Controls.Add(btnDel);
            Controls.Add(label6);
            Controls.Add(listboxmovieticket);
            Controls.Add(btnBill);
            Controls.Add(btnAdd);
            Controls.Add(cmbSeat);
            Controls.Add(label5);
            Controls.Add(cmbRoom);
            Controls.Add(label4);
            Controls.Add(cmbMovie);
            Controls.Add(label3);
            Controls.Add(txbName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bai5";
            Text = "Bai5";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private Label label2;
        private TextBox txbName;
        private Label label3;
        private ComboBox cmbMovie;
        private ComboBox cmbRoom;
        private Label label4;
        private ComboBox cmbSeat;
        private Label label5;
        private Button btnAdd;
        private Button btnBill;
        private ListBox listboxmovieticket;
        private Label label6;
        private Button btnDel;
    }
}