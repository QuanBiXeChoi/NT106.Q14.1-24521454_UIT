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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            tb1.Clear();
            tb2.Clear();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Int32.Parse(tb1.Text);
                switch (a)
                {
                    case 0:
                        tb2.Text = "Không";
                        break;
                    case 1:
                        tb2.Text = "Một";
                        break;
                    case 2:
                        tb2.Text = "Hai";
                        break;
                    case 3:
                        tb2.Text = "Ba";
                        break;
                    case 4:
                        tb2.Text = "Bốn";
                        break;
                    case 5:
                        tb2.Text = "Năm";
                        break;
                    case 6:
                        tb2.Text = "Sáu";
                        break;
                    case 7:
                        tb2.Text = "Bảy";
                        break;
                    case 8:
                        tb2.Text = "Tám";
                        break;
                    case 9:
                        tb2.Text = "Chín";
                        break;
                    default:
                        tb2 = null;
                        break;
                }
            }
            catch { }
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
            tb1.MaxLength = 1;
        }

        private void tb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
