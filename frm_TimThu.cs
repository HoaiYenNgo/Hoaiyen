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
	public partial class frm_TimThu : Form
	{
		public frm_TimThu()
		{
			InitializeComponent();
		}

		private void btn_Tim_Click(object sender, EventArgs e)
		{
			string a = txt_Thu.Text;
			switch (a)
			{
				case "hai":
					MessageBox.Show("Thứ Hai");
					break;
				case "ba":
					MessageBox.Show("Thứ Ba");
					break;
				case "tu":
					MessageBox.Show("Thứ Tư");
					break;
				case "nam":
					MessageBox.Show("Thứ Năm");
					break;
				case "sau":
					MessageBox.Show("Thứ Sáu");
					break;
				case "bay":
					MessageBox.Show("Thứ Bảy");
					break;
				case "tam":
					MessageBox.Show("Chủ Nhật");
					break;
			}
		}
	}
}
