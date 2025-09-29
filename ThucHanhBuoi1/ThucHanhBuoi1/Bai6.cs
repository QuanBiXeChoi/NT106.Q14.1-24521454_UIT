using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucHanhBuoi1
{
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
            cmbPhepTinh.Items.Add("Bảng cửu chương");
            cmbPhepTinh.Items.Add("Tính toán giá trị");
            cmbPhepTinh.SelectedIndex = 0;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (!int.TryParse(txbA.Text, out int A) || !int.TryParse(txbB.Text, out int B))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
                return;
            }

            string choosen = cmbPhepTinh.SelectedItem.ToString();

            if (choosen == "Bảng cửu chương")
            {
                listBox1.Items.Add(" Bảng cửu chương từ B đến A");
                for (int i = B; i <= A; i++)
                {
                    for (int j = 1; j <= 9; j++)
                    {
                        listBox1.Items.Add($"{i} x {j} = {i * j}");
                    }
                    listBox1.Items.Add("");
                }
            }
            else if (choosen == "Tính toán giá trị")
            {
                int temp = A - B;
                BigInteger giaithua = 1;
                if (temp < 0)
                {
                    listBox1.Items.Add("Không tính được giai thừa vì A - B < 0");
                }
                else
                {
                    for (int i = 1; i <= temp; i++)
                    {
                        giaithua *= i;
                    }
                    listBox1.Items.Add($"(A - B)! = {giaithua}");
                }
                BigInteger tong = 0;
                for (int i = 1; i <= B; i++)
                {
                    tong += BigInteger.Pow(A, i);
                }

                listBox1.Items.Add($"Tổng S = {tong}");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txbA.Clear();
            txbB.Clear();
            listBox1.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
