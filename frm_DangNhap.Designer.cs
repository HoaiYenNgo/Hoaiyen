﻿namespace form_Y
{
	partial class frm_DangNhap
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_TenTaiKhoan = new System.Windows.Forms.TextBox();
			this.txt_MatKhau = new System.Windows.Forms.TextBox();
			this.btn_DangNhap = new System.Windows.Forms.Button();
			this.btn_NhapLai = new System.Windows.Forms.Button();
			this.btn_Thoat = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(105, 99);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên Tài khoản";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(105, 177);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "Mật Khẩu";
			// 
			// txt_TenTaiKhoan
			// 
			this.txt_TenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_TenTaiKhoan.Location = new System.Drawing.Point(315, 103);
			this.txt_TenTaiKhoan.Name = "txt_TenTaiKhoan";
			this.txt_TenTaiKhoan.Size = new System.Drawing.Size(219, 31);
			this.txt_TenTaiKhoan.TabIndex = 2;
			// 
			// txt_MatKhau
			// 
			this.txt_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_MatKhau.Location = new System.Drawing.Point(315, 174);
			this.txt_MatKhau.Name = "txt_MatKhau";
			this.txt_MatKhau.PasswordChar = '*';
			this.txt_MatKhau.Size = new System.Drawing.Size(219, 31);
			this.txt_MatKhau.TabIndex = 3;
			// 
			// btn_DangNhap
			// 
			this.btn_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_DangNhap.Location = new System.Drawing.Point(85, 263);
			this.btn_DangNhap.Name = "btn_DangNhap";
			this.btn_DangNhap.Size = new System.Drawing.Size(157, 42);
			this.btn_DangNhap.TabIndex = 4;
			this.btn_DangNhap.Text = "Đăng Nhập";
			this.btn_DangNhap.UseVisualStyleBackColor = true;
			this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
			// 
			// btn_NhapLai
			// 
			this.btn_NhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_NhapLai.Location = new System.Drawing.Point(301, 263);
			this.btn_NhapLai.Name = "btn_NhapLai";
			this.btn_NhapLai.Size = new System.Drawing.Size(157, 42);
			this.btn_NhapLai.TabIndex = 5;
			this.btn_NhapLai.Text = "Nhập Lại";
			this.btn_NhapLai.UseVisualStyleBackColor = true;
			this.btn_NhapLai.Click += new System.EventHandler(this.btn_NhapLai_Click);
			// 
			// btn_Thoat
			// 
			this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Thoat.Location = new System.Drawing.Point(506, 263);
			this.btn_Thoat.Name = "btn_Thoat";
			this.btn_Thoat.Size = new System.Drawing.Size(157, 42);
			this.btn_Thoat.TabIndex = 6;
			this.btn_Thoat.Text = "Thoát";
			this.btn_Thoat.UseVisualStyleBackColor = true;
			this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
			// 
			// frm_DangNhap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btn_Thoat);
			this.Controls.Add(this.btn_NhapLai);
			this.Controls.Add(this.btn_DangNhap);
			this.Controls.Add(this.txt_MatKhau);
			this.Controls.Add(this.txt_TenTaiKhoan);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frm_DangNhap";
			this.Text = "frm_DangNhap";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_TenTaiKhoan;
		private System.Windows.Forms.TextBox txt_MatKhau;
		private System.Windows.Forms.Button btn_DangNhap;
		private System.Windows.Forms.Button btn_NhapLai;
		private System.Windows.Forms.Button btn_Thoat;
	}
}