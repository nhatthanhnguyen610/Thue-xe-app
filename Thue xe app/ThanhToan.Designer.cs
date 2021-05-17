
namespace Thue_xe_app
{
    partial class ThanhToan
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
            this.dataGridView_ThanhToan = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.bt_TimKiem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ThanhToan)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GreenYellow;
            this.label1.Location = new System.Drawing.Point(219, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "THANH TOÁN";
            // 
            // btnVe
            // 
            this.btnVe.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVe.Location = new System.Drawing.Point(664, 398);
            this.btnVe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVe.Name = "btnVe";
            this.btnVe.Size = new System.Drawing.Size(124, 41);
            this.btnVe.TabIndex = 3;
            this.btnVe.Text = "Về trang chủ";
            this.btnVe.UseVisualStyleBackColor = false;
            this.btnVe.Click += new System.EventHandler(this.btnVe_Click);
            // 
            // dataGridView_ThanhToan
            // 
            this.dataGridView_ThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ThanhToan.Location = new System.Drawing.Point(16, 120);
            this.dataGridView_ThanhToan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_ThanhToan.Name = "dataGridView_ThanhToan";
            this.dataGridView_ThanhToan.RowHeadersWidth = 51;
            this.dataGridView_ThanhToan.Size = new System.Drawing.Size(772, 261);
            this.dataGridView_ThanhToan.TabIndex = 4;
            this.dataGridView_ThanhToan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ThanhToan_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nhập từ khóa: ";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(230, 11);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(285, 22);
            this.txt_TimKiem.TabIndex = 6;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // bt_TimKiem
            // 
            this.bt_TimKiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_TimKiem.Location = new System.Drawing.Point(553, 7);
            this.bt_TimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_TimKiem.Name = "bt_TimKiem";
            this.bt_TimKiem.Size = new System.Drawing.Size(100, 28);
            this.bt_TimKiem.TabIndex = 7;
            this.bt_TimKiem.Text = "Tìm kiếm";
            this.bt_TimKiem.UseVisualStyleBackColor = false;
            this.bt_TimKiem.Click += new System.EventHandler(this.bt_TimKiem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.bt_TimKiem);
            this.panel1.Controls.Add(this.txt_TimKiem);
            this.panel1.Location = new System.Drawing.Point(16, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 42);
            this.panel1.TabIndex = 8;
            // 
            // ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Thue_xe_app.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_ThanhToan);
            this.Controls.Add(this.btnVe);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThanhToan";
            this.Load += new System.EventHandler(this.ThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ThanhToan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVe;
        private System.Windows.Forms.DataGridView dataGridView_ThanhToan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button bt_TimKiem;
        private System.Windows.Forms.Panel panel1;
    }
}