
namespace Thue_xe_app
{
    partial class DanhSachNguoiThue
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
            this.dataGridViewNguoiThue = new System.Windows.Forms.DataGridView();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TimKiemNguoiThue = new System.Windows.Forms.TextBox();
            this.bt_TimKiem = new System.Windows.Forms.Button();
            this.bt_HienThiTatCa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TenNguoiThue = new System.Windows.Forms.TextBox();
            this.txt_CMND = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNguoiThue)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GreenYellow;
            this.label1.Location = new System.Drawing.Point(186, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH NGƯỜI THUÊ";
            // 
            // btnVe
            // 
            this.btnVe.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVe.Location = new System.Drawing.Point(664, 6);
            this.btnVe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVe.Name = "btnVe";
            this.btnVe.Size = new System.Drawing.Size(124, 41);
            this.btnVe.TabIndex = 3;
            this.btnVe.Text = "Về trang chủ";
            this.btnVe.UseVisualStyleBackColor = false;
            this.btnVe.Click += new System.EventHandler(this.btnVe_Click);
            // 
            // dataGridViewNguoiThue
            // 
            this.dataGridViewNguoiThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNguoiThue.Location = new System.Drawing.Point(13, 93);
            this.dataGridViewNguoiThue.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewNguoiThue.Name = "dataGridViewNguoiThue";
            this.dataGridViewNguoiThue.RowHeadersWidth = 51;
            this.dataGridViewNguoiThue.Size = new System.Drawing.Size(775, 204);
            this.dataGridViewNguoiThue.TabIndex = 4;
            this.dataGridViewNguoiThue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNguoiThue_CellContentClick);
            // 
            // bt_Sua
            // 
            this.bt_Sua.BackColor = System.Drawing.Color.Gold;
            this.bt_Sua.Location = new System.Drawing.Point(240, 91);
            this.bt_Sua.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(100, 28);
            this.bt_Sua.TabIndex = 5;
            this.bt_Sua.Text = "Sửa";
            this.bt_Sua.UseVisualStyleBackColor = false;
            this.bt_Sua.Click += new System.EventHandler(this.bt_Sua_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nhập từ khóa:";
            // 
            // txt_TimKiemNguoiThue
            // 
            this.txt_TimKiemNguoiThue.Location = new System.Drawing.Point(172, 7);
            this.txt_TimKiemNguoiThue.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TimKiemNguoiThue.Name = "txt_TimKiemNguoiThue";
            this.txt_TimKiemNguoiThue.Size = new System.Drawing.Size(217, 22);
            this.txt_TimKiemNguoiThue.TabIndex = 7;
            this.txt_TimKiemNguoiThue.TextChanged += new System.EventHandler(this.txt_TimKiemNguoiThue_TextChanged);
            // 
            // bt_TimKiem
            // 
            this.bt_TimKiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_TimKiem.Location = new System.Drawing.Point(432, 4);
            this.bt_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.bt_TimKiem.Name = "bt_TimKiem";
            this.bt_TimKiem.Size = new System.Drawing.Size(100, 28);
            this.bt_TimKiem.TabIndex = 8;
            this.bt_TimKiem.Text = "Tìm kiếm";
            this.bt_TimKiem.UseVisualStyleBackColor = false;
            this.bt_TimKiem.Click += new System.EventHandler(this.bt_TimKiem_Click);
            // 
            // bt_HienThiTatCa
            // 
            this.bt_HienThiTatCa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_HienThiTatCa.Location = new System.Drawing.Point(577, 4);
            this.bt_HienThiTatCa.Margin = new System.Windows.Forms.Padding(4);
            this.bt_HienThiTatCa.Name = "bt_HienThiTatCa";
            this.bt_HienThiTatCa.Size = new System.Drawing.Size(167, 28);
            this.bt_HienThiTatCa.TabIndex = 9;
            this.bt_HienThiTatCa.Text = "Hiển Thị Tất Cả";
            this.bt_HienThiTatCa.UseVisualStyleBackColor = false;
            this.bt_HienThiTatCa.Click += new System.EventHandler(this.bt_HienThiTatCa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên người thuê:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "CMND: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Địa chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "SDT:";
            // 
            // txt_TenNguoiThue
            // 
            this.txt_TenNguoiThue.Location = new System.Drawing.Point(148, 13);
            this.txt_TenNguoiThue.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenNguoiThue.Name = "txt_TenNguoiThue";
            this.txt_TenNguoiThue.Size = new System.Drawing.Size(200, 22);
            this.txt_TenNguoiThue.TabIndex = 14;
            // 
            // txt_CMND
            // 
            this.txt_CMND.Location = new System.Drawing.Point(148, 49);
            this.txt_CMND.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CMND.Name = "txt_CMND";
            this.txt_CMND.Size = new System.Drawing.Size(200, 22);
            this.txt_CMND.TabIndex = 15;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(465, 13);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(200, 22);
            this.txt_DiaChi.TabIndex = 16;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(465, 47);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(200, 22);
            this.txt_SDT.TabIndex = 17;
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.BackColor = System.Drawing.Color.OrangeRed;
            this.bt_Xoa.Location = new System.Drawing.Point(405, 91);
            this.bt_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(100, 28);
            this.bt_Xoa.TabIndex = 18;
            this.bt_Xoa.Text = "Xóa";
            this.bt_Xoa.UseVisualStyleBackColor = false;
            this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_TimKiemNguoiThue);
            this.panel1.Controls.Add(this.bt_TimKiem);
            this.panel1.Controls.Add(this.bt_HienThiTatCa);
            this.panel1.Location = new System.Drawing.Point(13, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 39);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_TenNguoiThue);
            this.panel2.Controls.Add(this.bt_Xoa);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.bt_Sua);
            this.panel2.Controls.Add(this.txt_SDT);
            this.panel2.Controls.Add(this.txt_DiaChi);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_CMND);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(13, 297);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 141);
            this.panel2.TabIndex = 20;
            // 
            // DanhSachNguoiThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Thue_xe_app.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewNguoiThue);
            this.Controls.Add(this.btnVe);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DanhSachNguoiThue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanhSachNguoiThue";
            this.Load += new System.EventHandler(this.DanhSachNguoiThue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNguoiThue)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVe;
        private System.Windows.Forms.DataGridView dataGridViewNguoiThue;
        private System.Windows.Forms.Button bt_Sua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TimKiemNguoiThue;
        private System.Windows.Forms.Button bt_TimKiem;
        private System.Windows.Forms.Button bt_HienThiTatCa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_TenNguoiThue;
        private System.Windows.Forms.TextBox txt_CMND;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}