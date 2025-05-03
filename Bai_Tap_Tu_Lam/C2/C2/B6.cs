using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C2
{
    public partial class B6 : Form
    {
        public B6()
        {
            InitializeComponent();
        }

        private List<string> danhSachSinhVien = new List<string>();

        private void CapNhatListBox()
        {
            lstDSSV.Items.Clear();
            foreach (var sv in danhSachSinhVien)
            {
                lstDSSV.Items.Add(sv);
            }
        }
        private void btNhap_Click(object sender, EventArgs e)
        {
            string mssv = txtMSSV.Text.Trim();
            string ho = txtHo.Text.Trim();
            string ten = txtTen.Text.Trim();

            if (mssv == "" || ho == "" || ten == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }


            string sinhVien = $"{mssv} - {ho} {ten}";
            danhSachSinhVien.Add(sinhVien);
            CapNhatListBox();

            txtMSSV.Clear();
            txtHo.Clear();
            txtTen.Clear();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim().ToLower();

            var ketQua = danhSachSinhVien.Where(s =>
            {
                string[] parts = s.Split('-');
                if (parts.Length < 2) return false;

                string mssv = parts[0].Trim().ToLower();
                string hoTen = parts[1].Trim();
                string ten = hoTen.Split(' ').Last().ToLower();

                return mssv.Contains(tuKhoa) || ten.Contains(tuKhoa);
            }).ToList();

            lstDSSV.Items.Clear();
            foreach (var sv in ketQua)
            {
                lstDSSV.Items.Add(sv);
            }
        }

        private void btSapXep_Click(object sender, EventArgs e)
        {
            danhSachSinhVien.Sort((a, b) =>
            {
                string tenA = a.Split('-')[1].Trim().Split(' ').Last();
                string tenB = b.Split('-')[1].Trim().Split(' ').Last();
                return tenA.CompareTo(tenB);
            });

            CapNhatListBox();
        }

        private void lstDSSV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
