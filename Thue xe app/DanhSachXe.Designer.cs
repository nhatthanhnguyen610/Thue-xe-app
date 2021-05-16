
namespace Thue_xe_app
{
    partial class DanhSachXe
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
            this.btnVe = new System.Windows.Forms.Button();
            this.groupXe = new System.Windows.Forms.GroupBox();
            this.btnThueXe = new System.Windows.Forms.Button();
            this.lbTrangThai = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbBienSo = new System.Windows.Forms.Label();
            this.lbTenXe = new System.Windows.Forms.Label();
            this.lbMaXe = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnPhai = new System.Windows.Forms.Button();
            this.btnTrai = new System.Windows.Forms.Button();
            this.picXe = new System.Windows.Forms.PictureBox();
            this.groupHuongDan = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picXe)).BeginInit();
            this.groupHuongDan.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH XE";
            // 
            // btnVe
            // 
            this.btnVe.Location = new System.Drawing.Point(664, 397);
            this.btnVe.Name = "btnVe";
            this.btnVe.Size = new System.Drawing.Size(124, 41);
            this.btnVe.TabIndex = 3;
            this.btnVe.Text = "Về trang chủ";
            this.btnVe.UseVisualStyleBackColor = true;
            this.btnVe.Click += new System.EventHandler(this.btnVe_Click);
            // 
            // groupXe
            // 
            this.groupXe.Controls.Add(this.btnThueXe);
            this.groupXe.Controls.Add(this.lbTrangThai);
            this.groupXe.Controls.Add(this.label2);
            this.groupXe.Controls.Add(this.lbBienSo);
            this.groupXe.Controls.Add(this.lbTenXe);
            this.groupXe.Controls.Add(this.lbMaXe);
            this.groupXe.Controls.Add(this.btnTimKiem);
            this.groupXe.Controls.Add(this.txtTimKiem);
            this.groupXe.Controls.Add(this.btnPhai);
            this.groupXe.Controls.Add(this.btnTrai);
            this.groupXe.Controls.Add(this.picXe);
            this.groupXe.Location = new System.Drawing.Point(13, 79);
            this.groupXe.Name = "groupXe";
            this.groupXe.Size = new System.Drawing.Size(600, 359);
            this.groupXe.TabIndex = 4;
            this.groupXe.TabStop = false;
            this.groupXe.Text = "Xe";
            // 
            // btnThueXe
            // 
            this.btnThueXe.Location = new System.Drawing.Point(289, 299);
            this.btnThueXe.Name = "btnThueXe";
            this.btnThueXe.Size = new System.Drawing.Size(290, 40);
            this.btnThueXe.TabIndex = 10;
            this.btnThueXe.Text = "Thuê xe";
            this.btnThueXe.UseVisualStyleBackColor = true;
            this.btnThueXe.Click += new System.EventHandler(this.btnThueXe_Click);
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.AutoSize = true;
            this.lbTrangThai.BackColor = System.Drawing.Color.Black;
            this.lbTrangThai.Location = new System.Drawing.Point(392, 257);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(73, 17);
            this.lbTrangThai.TabIndex = 9;
            this.lbTrangThai.Text = "Trạng thái";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Trạng thái:";
            // 
            // lbBienSo
            // 
            this.lbBienSo.AutoSize = true;
            this.lbBienSo.Location = new System.Drawing.Point(289, 195);
            this.lbBienSo.Name = "lbBienSo";
            this.lbBienSo.Size = new System.Drawing.Size(55, 17);
            this.lbBienSo.TabIndex = 7;
            this.lbBienSo.Text = "Biển số";
            // 
            // lbTenXe
            // 
            this.lbTenXe.AutoSize = true;
            this.lbTenXe.Location = new System.Drawing.Point(289, 129);
            this.lbTenXe.Name = "lbTenXe";
            this.lbTenXe.Size = new System.Drawing.Size(51, 17);
            this.lbTenXe.TabIndex = 6;
            this.lbTenXe.Text = "Tên xe";
            // 
            // lbMaXe
            // 
            this.lbMaXe.AutoSize = true;
            this.lbMaXe.Location = new System.Drawing.Point(289, 66);
            this.lbMaXe.Name = "lbMaXe";
            this.lbMaXe.Size = new System.Drawing.Size(45, 17);
            this.lbMaXe.TabIndex = 5;
            this.lbMaXe.Text = "Mã xe";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(504, 22);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(289, 21);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(208, 22);
            this.txtTimKiem.TabIndex = 3;
            // 
            // btnPhai
            // 
            this.btnPhai.Location = new System.Drawing.Point(203, 281);
            this.btnPhai.Name = "btnPhai";
            this.btnPhai.Size = new System.Drawing.Size(58, 58);
            this.btnPhai.TabIndex = 2;
            this.btnPhai.Text = ">";
            this.btnPhai.UseVisualStyleBackColor = true;
            this.btnPhai.Click += new System.EventHandler(this.btnPhai_Click);
            // 
            // btnTrai
            // 
            this.btnTrai.Location = new System.Drawing.Point(7, 281);
            this.btnTrai.Name = "btnTrai";
            this.btnTrai.Size = new System.Drawing.Size(58, 58);
            this.btnTrai.TabIndex = 1;
            this.btnTrai.Text = "<";
            this.btnTrai.UseVisualStyleBackColor = true;
            this.btnTrai.Click += new System.EventHandler(this.btnTrai_Click);
            // 
            // picXe
            // 
            this.picXe.ErrorImage = null;
            this.picXe.Image = global::Thue_xe_app.Properties.Resources._null;
            this.picXe.InitialImage = null;
            this.picXe.Location = new System.Drawing.Point(6, 21);
            this.picXe.Name = "picXe";
            this.picXe.Size = new System.Drawing.Size(255, 253);
            this.picXe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picXe.TabIndex = 0;
            this.picXe.TabStop = false;
            // 
            // groupHuongDan
            // 
            this.groupHuongDan.Controls.Add(this.label4);
            this.groupHuongDan.Controls.Add(this.label3);
            this.groupHuongDan.Location = new System.Drawing.Point(620, 79);
            this.groupHuongDan.Name = "groupHuongDan";
            this.groupHuongDan.Size = new System.Drawing.Size(168, 312);
            this.groupHuongDan.TabIndex = 5;
            this.groupHuongDan.TabStop = false;
            this.groupHuongDan.Text = "Chú thích";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Green;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Khả dụng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(6, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Đã cho thuê";
            // 
            // DanhSachXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupHuongDan);
            this.Controls.Add(this.groupXe);
            this.Controls.Add(this.btnVe);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DanhSachXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanhSachXe";
            this.Load += new System.EventHandler(this.DanhSachXe_Load);
            this.groupXe.ResumeLayout(false);
            this.groupXe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picXe)).EndInit();
            this.groupHuongDan.ResumeLayout(false);
            this.groupHuongDan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVe;
        private System.Windows.Forms.GroupBox groupXe;
        private System.Windows.Forms.GroupBox groupHuongDan;
        private System.Windows.Forms.Label lbTrangThai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbBienSo;
        private System.Windows.Forms.Label lbTenXe;
        private System.Windows.Forms.Label lbMaXe;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnPhai;
        private System.Windows.Forms.Button btnTrai;
        private System.Windows.Forms.PictureBox picXe;
        private System.Windows.Forms.Button btnThueXe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}