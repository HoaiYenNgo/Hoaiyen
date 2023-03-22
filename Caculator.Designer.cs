namespace form_Y
{
    partial class frm_Caculator
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.txt_2 = new System.Windows.Forms.TextBox();
            this.txt_3 = new System.Windows.Forms.TextBox();
            this.btnc = new System.Windows.Forms.Button();
            this.btnt = new System.Windows.Forms.Button();
            this.btnn = new System.Windows.Forms.Button();
            this.btnchia = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 47);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 284);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 47);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kết quả";
            // 
            // txt_1
            // 
            this.txt_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_1.Location = new System.Drawing.Point(273, 68);
            this.txt_1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_1.Multiline = true;
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(556, 44);
            this.txt_1.TabIndex = 4;
            // 
            // txt_2
            // 
            this.txt_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_2.Location = new System.Drawing.Point(273, 180);
            this.txt_2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_2.Multiline = true;
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(556, 44);
            this.txt_2.TabIndex = 5;
            this.txt_2.TextChanged += new System.EventHandler(this.txt_2_TextChanged);
            // 
            // txt_3
            // 
            this.txt_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_3.Location = new System.Drawing.Point(273, 284);
            this.txt_3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_3.Multiline = true;
            this.txt_3.Name = "txt_3";
            this.txt_3.Size = new System.Drawing.Size(556, 44);
            this.txt_3.TabIndex = 6;
            // 
            // btnc
            // 
            this.btnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnc.Location = new System.Drawing.Point(116, 429);
            this.btnc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(129, 66);
            this.btnc.TabIndex = 7;
            this.btnc.Text = "+";
            this.btnc.UseVisualStyleBackColor = true;
            this.btnc.Click += new System.EventHandler(this.btnc_Click);
            // 
            // btnt
            // 
            this.btnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnt.Location = new System.Drawing.Point(357, 429);
            this.btnt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnt.Name = "btnt";
            this.btnt.Size = new System.Drawing.Size(129, 66);
            this.btnt.TabIndex = 8;
            this.btnt.Text = "-";
            this.btnt.UseVisualStyleBackColor = true;
            this.btnt.Click += new System.EventHandler(this.btnt_Click);
            // 
            // btnn
            // 
            this.btnn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnn.Location = new System.Drawing.Point(585, 429);
            this.btnn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnn.Name = "btnn";
            this.btnn.Size = new System.Drawing.Size(129, 66);
            this.btnn.TabIndex = 9;
            this.btnn.Text = "*";
            this.btnn.UseVisualStyleBackColor = true;
            this.btnn.Click += new System.EventHandler(this.btnn_Click);
            // 
            // btnchia
            // 
            this.btnchia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchia.Location = new System.Drawing.Point(821, 429);
            this.btnchia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnchia.Name = "btnchia";
            this.btnchia.Size = new System.Drawing.Size(129, 66);
            this.btnchia.TabIndex = 10;
            this.btnchia.Text = "/";
            this.btnchia.UseVisualStyleBackColor = true;
            this.btnchia.Click += new System.EventHandler(this.btnchia_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(864, 545);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(199, 75);
            this.btn_thoat.TabIndex = 11;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // frm_Caculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btnchia);
            this.Controls.Add(this.btnn);
            this.Controls.Add(this.btnt);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.txt_3);
            this.Controls.Add(this.txt_2);
            this.Controls.Add(this.txt_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Caculator";
            this.Text = "Caculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Caculator_FormClosing);
            this.Load += new System.EventHandler(this.frm_Caculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.TextBox txt_2;
        private System.Windows.Forms.TextBox txt_3;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button btnt;
        private System.Windows.Forms.Button btnn;
        private System.Windows.Forms.Button btnchia;
        private System.Windows.Forms.Button btn_thoat;
    }
}