namespace QuanLyPhongGYMv1
{
    partial class NhapThongTin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhapThongTin));
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.nutHuy = new System.Windows.Forms.Button();
            this.nutLuu = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.textSDT = new System.Windows.Forms.TextBox();
            this.textDiaChi = new System.Windows.Forms.TextBox();
            this.textHoten = new System.Windows.Forms.TextBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.goiTap = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.DimGray;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.Window;
            this.Label4.Location = new System.Drawing.Point(510, 251);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(68, 20);
            this.Label4.TabIndex = 47;
            this.Label4.Text = "Địa chỉ";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.DimGray;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.Window;
            this.Label3.Location = new System.Drawing.Point(488, 201);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(90, 20);
            this.Label3.TabIndex = 46;
            this.Label3.Text = "Họ và tên";
            // 
            // nutHuy
            // 
            this.nutHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.nutHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nutHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nutHuy.Location = new System.Drawing.Point(605, 439);
            this.nutHuy.Name = "nutHuy";
            this.nutHuy.Size = new System.Drawing.Size(155, 45);
            this.nutHuy.TabIndex = 36;
            this.nutHuy.Text = "Hủy";
            this.nutHuy.UseVisualStyleBackColor = false;
            this.nutHuy.Click += new System.EventHandler(this.nutHuy_Click);
            // 
            // nutLuu
            // 
            this.nutLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.nutLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nutLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nutLuu.Location = new System.Drawing.Point(778, 439);
            this.nutLuu.Name = "nutLuu";
            this.nutLuu.Size = new System.Drawing.Size(213, 45);
            this.nutLuu.TabIndex = 35;
            this.nutLuu.Text = "Lưu";
            this.nutLuu.UseVisualStyleBackColor = false;
            this.nutLuu.Click += new System.EventHandler(this.nutLuu_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.DimGray;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.Window;
            this.Label2.Location = new System.Drawing.Point(532, 296);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(46, 20);
            this.Label2.TabIndex = 45;
            this.Label2.Text = "SDT";
            // 
            // textSDT
            // 
            this.textSDT.Location = new System.Drawing.Point(605, 296);
            this.textSDT.Name = "textSDT";
            this.textSDT.Size = new System.Drawing.Size(386, 22);
            this.textSDT.TabIndex = 41;
            this.textSDT.TextChanged += new System.EventHandler(this.textSDT_TextChanged);
            // 
            // textDiaChi
            // 
            this.textDiaChi.Location = new System.Drawing.Point(605, 249);
            this.textDiaChi.Name = "textDiaChi";
            this.textDiaChi.Size = new System.Drawing.Size(386, 22);
            this.textDiaChi.TabIndex = 40;
            this.textDiaChi.TextChanged += new System.EventHandler(this.textDiaChi_TextChanged);
            // 
            // textHoten
            // 
            this.textHoten.Location = new System.Drawing.Point(605, 201);
            this.textHoten.Name = "textHoten";
            this.textHoten.Size = new System.Drawing.Size(386, 22);
            this.textHoten.TabIndex = 39;
            this.textHoten.TextChanged += new System.EventHandler(this.textHoten_TextChanged);
            // 
            // DataGridView1
            // 
            this.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(442, 141);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(590, 403);
            this.DataGridView1.TabIndex = 38;
            this.DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DimGray;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(503, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "Gói Tập";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(114, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(467, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 72;
            this.label1.Text = "Nhập thông tin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(167, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 60;
            this.label8.Text = "Ảnh cá nhân";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Garamond", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.Location = new System.Drawing.Point(25, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(395, 68);
            this.label10.TabIndex = 73;
            this.label10.Text = "ⒼⓎⓂ  ⓅⓁⓊⓈⓈ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goiTap
            // 
            this.goiTap.FormattingEnabled = true;
            this.goiTap.Location = new System.Drawing.Point(605, 367);
            this.goiTap.Name = "goiTap";
            this.goiTap.Size = new System.Drawing.Size(212, 24);
            this.goiTap.TabIndex = 74;
            this.goiTap.SelectedIndexChanged += new System.EventHandler(this.goiTap_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyPhongGYMv1.Properties.Resources.risen_wang_20jX9b35r_M_unsplash__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1186, 654);
            this.Controls.Add(this.goiTap);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.nutHuy);
            this.Controls.Add(this.nutLuu);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.textSDT);
            this.Controls.Add(this.textDiaChi);
            this.Controls.Add(this.textHoten);
            this.Controls.Add(this.DataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "GYM CITY";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button nutHuy;
        internal System.Windows.Forms.Button nutLuu;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox textSDT;
        internal System.Windows.Forms.TextBox textDiaChi;
        internal System.Windows.Forms.TextBox textHoten;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox goiTap;
    }
}

