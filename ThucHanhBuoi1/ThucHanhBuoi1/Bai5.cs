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
    public partial class Bai5 : Form
    {

        Dictionary<string, (int GiaVe, List<int> PhongChieu)> movies = new Dictionary<string, (int, List<int>)>
        {
            {"Đào, phở và piano", (45000, new List<int> {1, 2, 3}) },
            {"Mai", (100000, new List<int> {2, 3}) },
            {"Gặp lại chị bầu", (70000, new List<int> {1}) },
            {"Tarot", (90000, new List<int> {3}) }
        };

        Dictionary<int, Dictionary<string, bool>> seats = new Dictionary<int, Dictionary<string, bool>>();

        Dictionary<string, string> seattype = new Dictionary<string, string>()
        {
            {"A1","vot"},{"A5","vot"},{"C1","vot"},{"C5","vot"},
            {"A2","thuong"},{"A3","thuong"},{"A4","thuong"},{"C2","thuong"},{"C3","thuong"},{"C4","thuong"},
            {"B2","vip"},{"B3","vip"},{"B4","vip"}
        };

        List<(string phim, int phong, string ghe, int gia)> TicketList = new List<(string, int, string, int)>();
        public Bai5()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            foreach (var item in movies.Keys)
            {
                cmbMovie.Items.Add(item);
            }

            foreach (var item in seattype.Keys)
            {
                cmbSeat.Items.Add(item);
            }

            for (int p = 1; p <= 3; p++)
            {
                seats[p] = new Dictionary<string, bool>();
                foreach (var seat in seattype.Keys)
                {
                    seats[p][seat] = false;
                }
            }
        }

        private void cmbMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbRoom.Items.Clear();
            if (cmbMovie.SelectedItem != null)
            {
                string phim = cmbMovie.SelectedItem.ToString();
                foreach (var p in movies[phim].PhongChieu)
                {
                    cmbRoom.Items.Add(p.ToString());
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbName.Text) ||
                cmbMovie.SelectedItem == null ||
                cmbRoom.SelectedItem == null ||
                cmbSeat.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }

            string HoTen = txbName.Text;
            string Phim = cmbMovie.SelectedItem.ToString();
            int Phong = int.Parse(cmbRoom.SelectedItem.ToString());
            string Ghe = cmbSeat.SelectedItem.ToString();

            if (seats[Phong][Ghe])
            {
                MessageBox.Show("Ghế này đã được mua!");
                return;
            }

            int giacoban = movies[Phim].GiaVe;
            int gia = 0;

            switch (seattype[Ghe])
            {
                case "vot": gia = giacoban / 4; break;
                case "thuong": gia = giacoban; break;
                case "vip": gia = giacoban * 2; break;
            }

            TicketList.Add((Phim, Phong, Ghe, gia));
            seats[Phong][Ghe] = true;

            listboxmovieticket.Items.Add($"Khách: {HoTen} | Phim: {Phim} | Phòng {Phong} | Ghế {Ghe} | Giá {gia}đ");
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            if (TicketList.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn vé nào!");
                return;
            }

            int tong = 0;

            foreach (var ve in TicketList)
            {
                tong += ve.gia;
            }

            MessageBox.Show($"Tổng Bill là: {tong}");

            TicketList.Clear();

            listboxmovieticket.Items.Clear();
        }

        private void listboxmovieticket_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (listboxmovieticket.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn vé cần xóa trong danh sách!");
                return;
            }

           
            int index = listboxmovieticket.SelectedIndex;
            var ve = TicketList[index];

            
            seats[ve.phong][ve.ghe] = false;

            
            TicketList.RemoveAt(index);
            listboxmovieticket.Items.RemoveAt(index);

            MessageBox.Show($"Đã xóa vé ghế {ve.ghe} - Phòng {ve.phong} cho phim {ve.phim}");
        }
    }
}
