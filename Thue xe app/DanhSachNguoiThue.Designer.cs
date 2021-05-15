
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(642, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH NGƯỜI THUÊ";
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
            // DanhSachNguoiThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVe);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DanhSachNguoiThue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanhSachNguoiThue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVe;
    }
}