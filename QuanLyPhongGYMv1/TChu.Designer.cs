using System.Drawing;

namespace QuanLyPhongGYMv1
{
    partial class TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            this.Label5 = new System.Windows.Forms.Label();
            this.nutDangNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label5
            // 
            this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Garamond", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Label5.Location = new System.Drawing.Point(143, 20);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(917, 135);
            this.Label5.TabIndex = 71;
            this.Label5.Text = "ⒼⓎⓂ      ⓅⓁⓊⓈⓈ";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nutDangNhap
            // 
            this.nutDangNhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nutDangNhap.AutoSize = true;
            this.nutDangNhap.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.nutDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nutDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nutDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nutDangNhap.ForeColor = System.Drawing.Color.Red;
            this.nutDangNhap.Location = new System.Drawing.Point(400, 352);
            this.nutDangNhap.Name = "nutDangNhap";
            this.nutDangNhap.Size = new System.Drawing.Size(324, 58);
            this.nutDangNhap.TabIndex = 95;
            this.nutDangNhap.Text = "Đăng nhập";
            this.nutDangNhap.UseVisualStyleBackColor = false;
            this.nutDangNhap.Click += new System.EventHandler(this.nutDangNhap_Click);
            this.nutDangNhap.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.nutDangNhap.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::QuanLyPhongGYMv1.Properties.Resources.anastase_maragos_7kEpUPB8vNk_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1186, 654);
            this.Controls.Add(this.nutDangNhap);
            this.Controls.Add(this.Label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrangChu";
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Button nutDangNhap;
    }
}