using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucHanhBuoi1
{
    public partial class Bai9 : Form
    {
        string foodString = "Phở,Bún chả,Cơm tấm,Hủ tiếu,Bánh mì";
        Random rnd = new Random();
        public Bai9()
        {
            InitializeComponent();
            LoadFoodList();
        }

        private void LoadFoodList()
        {
            listboxFoodName.Items.Clear();
            string[] foods = foodString.Split(',');
            listboxFoodName.Items.AddRange(foods);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string food = txbFoodName.Text.Trim();
            if (!string.IsNullOrEmpty(food))
            {
                string[] foods = foodString.Split(',');
                if (!foods.Contains(food))
                {
                    foodString += "," + food;
                    LoadFoodList();
                    txbFoodName.Clear();
                }
                else
                {
                    MessageBox.Show("Món đã tồn tại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên món!");
            }
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (listboxFoodName.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn món cần xóa!");
                return;
            }

            int index = listboxFoodName.SelectedIndex;

            listboxFoodName.Items.RemoveAt(index);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (listboxFoodName.Items.Count > 0)
            {
                int index = rnd.Next(listboxFoodName.Items.Count);
                txbResult.Text = listboxFoodName.Items[index].ToString();
            }
            else
            {
                MessageBox.Show("Danh sách trống!");
            }
        }
    }
}
