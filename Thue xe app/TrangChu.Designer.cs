
namespace Thue_xe_app
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
            this.btnDangxuat = new System.Windows.Forms.Button();
            this.btnDanhSachXe = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnDanhSachNguoiThue = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDangxuat
            // 
            this.btnDangxuat.Location = new System.Drawing.Point(677, 12);
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.Size = new System.Drawing.Size(111, 41);
            this.btnDangxuat.TabIndex = 0;
            this.btnDangxuat.Text = "Đăng xuất";
            this.btnDangxuat.UseVisualStyleBackColor = true;
            this.btnDangxuat.Click += new System.EventHandler(this.btnDangxuat_Click);
            // 
            // btnDanhSachXe
            // 
            this.btnDanhSachXe.Location = new System.Drawing.Point(305, 46);
            this.btnDanhSachXe.Name = "btnDanhSachXe";
            this.btnDanhSachXe.Size = new System.Drawing.Size(145, 45);
            this.btnDanhSachXe.TabIndex = 2;
            this.btnDanhSachXe.Text = "Xem danh sách xe";
            this.btnDanhSachXe.UseVisualStyleBackColor = true;
            this.btnDanhSachXe.Click += new System.EventHandler(this.btnDanhSachXe_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(305, 375);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(145, 45);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnDanhSachNguoiThue
            // 
            this.btnDanhSachNguoiThue.Location = new System.Drawing.Point(305, 149);
            this.btnDanhSachNguoiThue.Name = "btnDanhSachNguoiThue";
            this.btnDanhSachNguoiThue.Size = new System.Drawing.Size(145, 45);
            this.btnDanhSachNguoiThue.TabIndex = 4;
            this.btnDanhSachNguoiThue.Text = "Xem danh sách người thuê";
            this.btnDanhSachNguoiThue.UseVisualStyleBackColor = true;
            this.btnDanhSachNguoiThue.Click += new System.EventHandler(this.btnDanhSachNguoiThue_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(305, 255);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(145, 45);
            this.btnThanhToan.TabIndex = 5;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(677, 397);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(111, 41);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnDanhSachNguoiThue);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnDanhSachXe);
            this.Controls.Add(this.btnDangxuat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrangChu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDangxuat;
        private System.Windows.Forms.Button btnDanhSachXe;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnDanhSachNguoiThue;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnThoat;
    }
}