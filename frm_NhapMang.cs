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
	public partial class frm_NhapMang : Form
	{
		public frm_NhapMang()
		{
			InitializeComponent();
		}

		private void btngiai_Click(object sender, EventArgs e)
		{
			int[] arr = txt_MangA.Text.Split(' ').Select(int.Parse).ToArray(); // Chuyển đổi dữ liệu trong textbox thành mảng số nguyên

			int sumEven = 0, sumOdd = 0, sumAll = 0;

			// Duyệt mảng để tính tổng các số chẵn, lẻ và tổng tất cả số trong mảng
			for (int i = 0; i < arr.Length; i++)
			{
				sumAll += arr[i];

				if (arr[i] % 2 == 0) // Số chẵn
				{
					sumEven += arr[i];
				}
				else // Số lẻ
				{
					sumOdd += arr[i];
				}
			}

			// Hiển thị kết quả
			txt_Tong.Text = sumAll.ToString();
			txt_Chan.Text = sumEven.ToString();
			txt_Le.Text = sumOdd.ToString();
		}

		private void btn_LamMoi_Click(object sender, EventArgs e)
		{
			txt_MangA.Text = "";
			txt_Chan.Text = "";
			txt_Le.Text = " ";
			txt_Tong.Text = " ";

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
