using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_Y
{
	public partial class frm_DangNhap : Form
	{
		public frm_DangNhap()
		{
			InitializeComponent();
		}

		private void btn_DangNhap_Click(object sender, EventArgs e)
		{
			int count = 0;
			if (txt_TenTaiKhoan.Text.ToLower() == "admin" && txt_MatKhau.Text == "123456")
			{
				frm_QLSinhVien frmQLSV = new frm_QLSinhVien();
				frmQLSV.ShowDialog();
			}
			else
			{
				// Đăng nhập sai
				count++;
				MessageBox.Show("Đăng nhập sai! Vui lòng nhập lại.", "Thông báo");
				if (count >= 3)
				{
					// Đăng nhập sai quá 3 lần, thoát ứng dụng
					MessageBox.Show("Bạn đã đăng nhập sai quá 3 lần! Cảm ơn bạn đã sử dụng ứng dụng.", "Thông báo");
					Application.Exit();
				}
			}
		}

		private void btn_NhapLai_Click(object sender, EventArgs e)
		{
			txt_TenTaiKhoan.Text = "";
			txt_MatKhau.Text = "";
		}

		private void btn_Thoat_Click(object sender, EventArgs e)
		{
			DialogResult r;
			r = MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (r == DialogResult.Yes)
				Application.Exit();
		}
	}
}
