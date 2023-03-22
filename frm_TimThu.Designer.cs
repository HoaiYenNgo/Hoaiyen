namespace form_Y
{
	partial class frm_TimThu
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
			this.txt_Thu = new System.Windows.Forms.TextBox();
			this.btn_Tim = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(122, 88);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Thứ";
			// 
			// txt_Thu
			// 
			this.txt_Thu.Location = new System.Drawing.Point(222, 82);
			this.txt_Thu.Margin = new System.Windows.Forms.Padding(6);
			this.txt_Thu.Name = "txt_Thu";
			this.txt_Thu.Size = new System.Drawing.Size(196, 31);
			this.txt_Thu.TabIndex = 1;
			// 
			// btn_Tim
			// 
			this.btn_Tim.Location = new System.Drawing.Point(233, 160);
			this.btn_Tim.Name = "btn_Tim";
			this.btn_Tim.Size = new System.Drawing.Size(91, 41);
			this.btn_Tim.TabIndex = 2;
			this.btn_Tim.Text = "Tìm";
			this.btn_Tim.UseVisualStyleBackColor = true;
			this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
			// 
			// frm_TimThu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1284, 701);
			this.Controls.Add(this.btn_Tim);
			this.Controls.Add(this.txt_Thu);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "frm_TimThu";
			this.Text = "frm_TimThu";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_Thu;
		private System.Windows.Forms.Button btn_Tim;
	}
}