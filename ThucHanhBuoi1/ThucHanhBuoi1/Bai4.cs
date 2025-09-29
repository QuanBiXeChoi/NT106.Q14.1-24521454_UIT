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
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            long input = long.Parse(tb1.Text);

            tb2.Text = Read1(input);
        }

        private string Read1(long input)
        {
            if (input == 0) return "Không";

            string[] DonViNhom = { "", "ngàn", "triệu", "tỷ" };
            string kq = "";

            int i = 0;
            while (input > 0)
            {
                long BaChuSo = input % 1000;
                if (BaChuSo != 0)
                {
                    string nhom = Read2(BaChuSo) + " " + DonViNhom[i];
                    kq = nhom + " " + kq;
                }
                input /= 1000;
                i++;
            }


            return kq.Trim();
        }

        private string Read2(long input)
        {
            string[] so = { "không", "một", "hai", "ba", "bốn", "năm",
                    "sáu", "bảy", "tám", "chín" };

            long tram = input / 100;
            long chuc = (input % 100) / 10;
            long donvi = input % 10;

            string result = "";
            
            if (tram > 0)
                result += so[tram] + " trăm";

            
            if (chuc > 1)
            {
                result += (result.Length > 0 ? " " : "") + so[chuc] + " mươi";

                if (donvi == 1) result += " mốt";
                else if (donvi == 5) result += " lăm";
                else if (donvi > 0) result += " " + so[donvi];
            }
            else if (chuc == 1)
            {
                result += (result.Length > 0 ? " " : "") + "mười";

                if (donvi == 5) result += " lăm";
                else if (donvi > 0) result += " " + so[donvi];
            }
            else if (chuc == 0)
            {
                if (tram > 0 && donvi > 0)
                {
                    result += " lẻ";
                }

                
                if (donvi > 0)
                {
                    result += (result.Length > 0 ? " " : "") + so[donvi];
                }
            }

            return result.Trim();
        }


        private void btnDel_Click(object sender, EventArgs e)
        {
            tb1.Clear();
            tb2.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
            tb1.MaxLength = 12;
        }

        private void tb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Bai4_Load(object sender, EventArgs e)
        {

        }
    }
}
