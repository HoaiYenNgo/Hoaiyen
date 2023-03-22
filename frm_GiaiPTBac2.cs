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
	public partial class frm_GiaiPTBac2 : Form
	{
		public frm_GiaiPTBac2()
		{
			InitializeComponent();
		}

		private void btngiai_Click(object sender, EventArgs e)
		{
			double a, b, c, d;
			a = double.Parse(txta.Text);
			b = double.Parse(txtb.Text);
			c = double.Parse(txtc.Text);
			d = b * b - 4 * a * c;
			if (a == 0)
			{
				if (b == 0) txtkq.Text = "vô nghiệm";
				else
					txtkq.Text = (-c / b).ToString();
				return;

			}
			// tinh delta
			d = b * b - 4 * a * c;
			double x1;
			double x2;
			// tinh nghiem
			if (d > 0)
			{
				x1 = (double)((-b + Math.Sqrt(d)) / (2 * a));
				x2 = (double)((-b - Math.Sqrt(d)) / (2 * a));
				txtkq.Text = "x1=" + x1.ToString() + " x2 = " + x2.ToString();
			}
			else if (d == 0)
			{
				x1 = (-b / (2 * a));
				txtkq.Text = x1.ToString();
			}
			else
			{
				txtkq.Text = "Phương trình vô nghiệm";
			}
		}

		private void btnthoat_Click(object sender, EventArgs e)
		{
			DialogResult r;
			r = MessageBox.Show("Đừng thoát mà! chơi tiếp đi (⋟﹏⋞)", "ĐỪNG MÀ (つ﹏<。)", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (r == DialogResult.Yes)
				Application.Exit();
		}
	}
}
