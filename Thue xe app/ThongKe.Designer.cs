
namespace Thue_xe_app
{
    partial class ThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVe = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Thang = new System.Windows.Forms.TextBox();
            this.txt_Nam = new System.Windows.Forms.TextBox();
            this.bt_ThongKe = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_DoanhThu = new System.Windows.Forms.TextBox();
            this.chart_ThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ThongKe)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GreenYellow;
            this.label1.Location = new System.Drawing.Point(257, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ";
            // 
            // btnVe
            // 
            this.btnVe.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVe.Location = new System.Drawing.Point(664, 398);
            this.btnVe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVe.Name = "btnVe";
            this.btnVe.Size = new System.Drawing.Size(124, 41);
            this.btnVe.TabIndex = 1;
            this.btnVe.Text = "Về trang chủ";
            this.btnVe.UseVisualStyleBackColor = false;
            this.btnVe.Click += new System.EventHandler(this.btnVe_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tháng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(237, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Năm:";
            // 
            // txt_Thang
            // 
            this.txt_Thang.Location = new System.Drawing.Point(142, 22);
            this.txt_Thang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Thang.Name = "txt_Thang";
            this.txt_Thang.Size = new System.Drawing.Size(87, 22);
            this.txt_Thang.TabIndex = 4;
            // 
            // txt_Nam
            // 
            this.txt_Nam.Location = new System.Drawing.Point(307, 22);
            this.txt_Nam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Nam.Name = "txt_Nam";
            this.txt_Nam.Size = new System.Drawing.Size(111, 22);
            this.txt_Nam.TabIndex = 5;
            // 
            // bt_ThongKe
            // 
            this.bt_ThongKe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_ThongKe.Location = new System.Drawing.Point(492, 19);
            this.bt_ThongKe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_ThongKe.Name = "bt_ThongKe";
            this.bt_ThongKe.Size = new System.Drawing.Size(100, 28);
            this.bt_ThongKe.TabIndex = 6;
            this.bt_ThongKe.Text = "Thống Kê";
            this.bt_ThongKe.UseVisualStyleBackColor = false;
            this.bt_ThongKe.Click += new System.EventHandler(this.bt_ThongKe_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Doanh Thu:";
            // 
            // txt_DoanhThu
            // 
            this.txt_DoanhThu.Enabled = false;
            this.txt_DoanhThu.Location = new System.Drawing.Point(142, 75);
            this.txt_DoanhThu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_DoanhThu.Name = "txt_DoanhThu";
            this.txt_DoanhThu.Size = new System.Drawing.Size(393, 22);
            this.txt_DoanhThu.TabIndex = 8;
            this.txt_DoanhThu.TextChanged += new System.EventHandler(this.ThongKe_Load);
            // 
            // chart_ThongKe
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_ThongKe.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_ThongKe.Legends.Add(legend1);
            this.chart_ThongKe.Location = new System.Drawing.Point(13, 183);
            this.chart_ThongKe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart_ThongKe.Name = "chart_ThongKe";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Doanh thu";
            this.chart_ThongKe.Series.Add(series1);
            this.chart_ThongKe.Size = new System.Drawing.Size(627, 253);
            this.chart_ThongKe.TabIndex = 9;
            this.chart_ThongKe.Text = "DoanhThu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_DoanhThu);
            this.panel1.Controls.Add(this.txt_Thang);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_Nam);
            this.panel1.Controls.Add(this.bt_ThongKe);
            this.panel1.Location = new System.Drawing.Point(12, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 116);
            this.panel1.TabIndex = 10;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Thue_xe_app.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart_ThongKe);
            this.Controls.Add(this.btnVe);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongKe";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_ThongKe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Thang;
        private System.Windows.Forms.TextBox txt_Nam;
        private System.Windows.Forms.Button bt_ThongKe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_DoanhThu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_ThongKe;
        private System.Windows.Forms.Panel panel1;
    }
}