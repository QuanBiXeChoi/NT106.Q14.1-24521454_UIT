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
    public partial class Bai8 : Form
    {
        public Bai8()
        {
            InitializeComponent();
        }

        private void btnXuLy_Click(object sender, EventArgs e)
        {
            listboxOutput.Items.Clear();

            string[] lines = txbInput.Lines;

            foreach (string line in lines) 
            {
                if (string.IsNullOrEmpty(line)) continue;

                string[] parts = line.Split(',');

                if (parts.Length < 2) 
                {
                    listboxOutput.Items.Add("Sai format!");
                    listboxOutput.Items.Add("");
                    continue;
                }

                string HoTen = parts[0].Trim();

                double[] diem;

                try
                {
                    diem = parts.Skip(1).Select(p => double.Parse(p.Trim())).ToArray();
                }
                catch
                {
                    listboxOutput.Items.Add("Lỗi nhập sai định dạng!");
                    listboxOutput.Items.Add("");
                    continue;
                }

                if (!diem.All(d => d >= 0 && d <= 10))
                {
                    MessageBox.Show($"{HoTen}: Có điểm ngoài phạm vi 0–10. Vui lòng nhập lại!");
                    return;
                }

                listboxOutput.Items.Add($"Họ Tên: {HoTen}");

                double dtb = diem.Average();
                double max = diem.Max(); ;
                double min = diem.Min();

                int somondau = diem.Count(d => d >= 5);
                int somonrot = diem.Length - somondau;

                string XepLoai;
                if (dtb >= 8 && diem.All(d => d >= 6.5))
                    XepLoai = "Giỏi";
                else if (dtb >= 6.5 && diem.All(d => d >= 5))
                    XepLoai = "Khá";
                else if (dtb >= 5 && diem.All(d => d >= 3.5))
                    XepLoai = "Trung Bình";
                else if (dtb >= 3.5 && diem.All(d => d >= 2))
                    XepLoai = "Yếu";
                else
                    XepLoai = "Kém";

                listboxOutput.Items.Add($"- Điểm trung bình: {dtb:F2}");
                listboxOutput.Items.Add($"- Môn cao nhất: {Array.IndexOf(diem, max) + 1} ({max})");
                listboxOutput.Items.Add($"- Môn thấp nhất: {Array.IndexOf(diem, min) + 1} ({min})");
                listboxOutput.Items.Add($"- Số môn đậu: {somondau}, rớt: {somonrot}");
                listboxOutput.Items.Add($"- Xếp loại: {XepLoai}");
                listboxOutput.Items.Add("");
            }
        }
    }
}
