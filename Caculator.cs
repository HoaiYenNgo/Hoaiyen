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
    public partial class frm_Caculator : Form
    {
        double SoA, SoB, SoC;

        private void btnt_Click(object sender, EventArgs e)
        {
            SoA = double.Parse(txt_1.Text);
            SoB = double.Parse(txt_2.Text);
            SoC = SoA - SoB;
            txt_3.Text = SoC.ToString();
        }

        private void btnn_Click(object sender, EventArgs e)
        {
            SoA = double.Parse(txt_1.Text);
            SoB = double.Parse(txt_2.Text);
            SoC = SoA * SoB;
            txt_3.Text = SoC.ToString();
        }

        private void btnchia_Click(object sender, EventArgs e)
        {
            SoA = double.Parse(txt_1.Text);
            SoB = double.Parse(txt_2.Text);
            SoC = SoA / SoB;
            txt_3.Text = SoC.ToString();
        }

        private void Caculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Đừng thoát mà! chơi tiếp đi (⋟﹏⋞)", "ĐỪNG MÀ (つ﹏<。)", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Đừng thoát mà! chơi tiếp đi (⋟﹏⋞)", "ĐỪNG MÀ (つ﹏<。)", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                Application.Exit();

            MessageBox.Show("Bạn muốn đăng xuất hay không","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question );
        }

        private void txt_2_TextChanged(object sender, EventArgs e)
        {
            if (txt_2.Text == "0")
            {
                btnchia.Enabled = false;
            }
            else btnchia.Enabled = true;
        }

        private void frm_Caculator_Load(object sender, EventArgs e)
        {

        }

        public frm_Caculator()
        {
            InitializeComponent();
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            SoA = double.Parse(txt_1.Text);
            SoB = double.Parse(txt_2.Text);
            SoC = SoA + SoB;
            txt_3.Text = SoC.ToString();

        }
    }
}
