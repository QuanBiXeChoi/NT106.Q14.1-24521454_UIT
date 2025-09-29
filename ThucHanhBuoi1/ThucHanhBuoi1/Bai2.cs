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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void Bai2_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                float a = float.Parse(tbso1.Text);
                float b = float.Parse(tbso2.Text);
                float c = float.Parse(tbso3.Text);
                float max = a, min = a;
                if (max < b) max = b;
                if (max < c) max = c;
                if (min > b) min = b;
                if (min > c) min = c;

                tbso4.Text = max.ToString();
                tbso5.Text = min.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi!" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            tbso1.Clear();
            tbso2.Clear();
            tbso3.Clear();
            tbso4.Clear();
            tbso5.Clear();

            tbso1.Focus();
        }
    }
}
