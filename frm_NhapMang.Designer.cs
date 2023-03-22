namespace form_Y
{
	partial class frm_NhapMang
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
			this.btn_Thoat = new System.Windows.Forms.Button();
			this.btn_TinhToan = new System.Windows.Forms.Button();
			this.txt_Le = new System.Windows.Forms.TextBox();
			this.txt_Tong = new System.Windows.Forms.TextBox();
			this.txt_Chan = new System.Windows.Forms.TextBox();
			this.txt_MangA = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_LamMoi = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_Thoat
			// 
			this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Thoat.Location = new System.Drawing.Point(481, 336);
			this.btn_Thoat.Name = "btn_Thoat";
			this.btn_Thoat.Size = new System.Drawing.Size(146, 57);
			this.btn_Thoat.TabIndex = 19;
			this.btn_Thoat.Text = "Thoát";
			this.btn_Thoat.UseVisualStyleBackColor = true;
			this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
			// 
			// btn_TinhToan
			// 
			this.btn_TinhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_TinhToan.Location = new System.Drawing.Point(183, 336);
			this.btn_TinhToan.Name = "btn_TinhToan";
			this.btn_TinhToan.Size = new System.Drawing.Size(119, 57);
			this.btn_TinhToan.TabIndex = 18;
			this.btn_TinhToan.Text = "Tính toán";
			this.btn_TinhToan.UseVisualStyleBackColor = true;
			this.btn_TinhToan.Click += new System.EventHandler(this.btngiai_Click);
			// 
			// txt_Le
			// 
			this.txt_Le.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Le.Location = new System.Drawing.Point(311, 132);
			this.txt_Le.Name = "txt_Le";
			this.txt_Le.Size = new System.Drawing.Size(364, 32);
			this.txt_Le.TabIndex = 17;
			// 
			// txt_Tong
			// 
			this.txt_Tong.Enabled = false;
			this.txt_Tong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Tong.Location = new System.Drawing.Point(311, 276);
			this.txt_Tong.Name = "txt_Tong";
			this.txt_Tong.Size = new System.Drawing.Size(364, 32);
			this.txt_Tong.TabIndex = 16;
			// 
			// txt_Chan
			// 
			this.txt_Chan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Chan.Location = new System.Drawing.Point(311, 205);
			this.txt_Chan.Name = "txt_Chan";
			this.txt_Chan.Size = new System.Drawing.Size(364, 32);
			this.txt_Chan.TabIndex = 15;
			// 
			// txt_MangA
			// 
			this.txt_MangA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_MangA.Location = new System.Drawing.Point(311, 65);
			this.txt_MangA.Name = "txt_MangA";
			this.txt_MangA.Size = new System.Drawing.Size(364, 32);
			this.txt_MangA.TabIndex = 14;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(73, 132);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(166, 26);
			this.label4.TabIndex = 13;
			this.label4.Text = "Tổng các số lẻ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(73, 211);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(198, 26);
			this.label3.TabIndex = 12;
			this.label3.Text = "Tổng các số chẵn";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(73, 276);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(229, 26);
			this.label2.TabIndex = 11;
			this.label2.Text = "Tổng các số mảng A";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(73, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 26);
			this.label1.TabIndex = 10;
			this.label1.Text = "Mảng A";
			// 
			// btn_LamMoi
			// 
			this.btn_LamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_LamMoi.Location = new System.Drawing.Point(336, 336);
			this.btn_LamMoi.Name = "btn_LamMoi";
			this.btn_LamMoi.Size = new System.Drawing.Size(119, 57);
			this.btn_LamMoi.TabIndex = 20;
			this.btn_LamMoi.Text = "Làm mới";
			this.btn_LamMoi.UseVisualStyleBackColor = true;
			this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
			// 
			// frm_NhapMang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btn_LamMoi);
			this.Controls.Add(this.btn_Thoat);
			this.Controls.Add(this.btn_TinhToan);
			this.Controls.Add(this.txt_Le);
			this.Controls.Add(this.txt_Tong);
			this.Controls.Add(this.txt_Chan);
			this.Controls.Add(this.txt_MangA);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frm_NhapMang";
			this.Text = "frm_NhapMang";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Thoat;
		private System.Windows.Forms.Button btn_TinhToan;
		private System.Windows.Forms.TextBox txt_Le;
		private System.Windows.Forms.TextBox txt_Tong;
		private System.Windows.Forms.TextBox txt_Chan;
		private System.Windows.Forms.TextBox txt_MangA;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_LamMoi;
	}
}