﻿namespace _3_PL.View
{
    partial class FrmHangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHangHoa));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chaasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiGiàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeGiàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtXứToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàSảnXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ảnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.cbo_loc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgrid_sanpham = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_sanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Thistle;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chaasToolStripMenuItem,
            this.loạiGiàyToolStripMenuItem,
            this.sizeGiàyToolStripMenuItem,
            this.xuấtXứToolStripMenuItem,
            this.nhàSảnXuấtToolStripMenuItem,
            this.ảnhToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1712, 37);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chaasToolStripMenuItem
            // 
            this.chaasToolStripMenuItem.Name = "chaasToolStripMenuItem";
            this.chaasToolStripMenuItem.Size = new System.Drawing.Size(96, 29);
            this.chaasToolStripMenuItem.Text = "Chất liệu";
            this.chaasToolStripMenuItem.Click += new System.EventHandler(this.chaasToolStripMenuItem_Click);
            // 
            // loạiGiàyToolStripMenuItem
            // 
            this.loạiGiàyToolStripMenuItem.Name = "loạiGiàyToolStripMenuItem";
            this.loạiGiàyToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.loạiGiàyToolStripMenuItem.Text = "Loại Giày";
            this.loạiGiàyToolStripMenuItem.Click += new System.EventHandler(this.loạiGiàyToolStripMenuItem_Click);
            // 
            // sizeGiàyToolStripMenuItem
            // 
            this.sizeGiàyToolStripMenuItem.Name = "sizeGiàyToolStripMenuItem";
            this.sizeGiàyToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.sizeGiàyToolStripMenuItem.Text = "Size Giày";
            this.sizeGiàyToolStripMenuItem.Click += new System.EventHandler(this.sizeGiàyToolStripMenuItem_Click);
            // 
            // xuấtXứToolStripMenuItem
            // 
            this.xuấtXứToolStripMenuItem.Name = "xuấtXứToolStripMenuItem";
            this.xuấtXứToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.xuấtXứToolStripMenuItem.Text = "Xuất xứ";
            this.xuấtXứToolStripMenuItem.Click += new System.EventHandler(this.xuấtXứToolStripMenuItem_Click);
            // 
            // nhàSảnXuấtToolStripMenuItem
            // 
            this.nhàSảnXuấtToolStripMenuItem.Name = "nhàSảnXuấtToolStripMenuItem";
            this.nhàSảnXuấtToolStripMenuItem.Size = new System.Drawing.Size(130, 29);
            this.nhàSảnXuấtToolStripMenuItem.Text = "Nhà sản xuất";
            this.nhàSảnXuấtToolStripMenuItem.Click += new System.EventHandler(this.nhàSảnXuấtToolStripMenuItem_Click);
            // 
            // ảnhToolStripMenuItem
            // 
            this.ảnhToolStripMenuItem.Name = "ảnhToolStripMenuItem";
            this.ảnhToolStripMenuItem.Size = new System.Drawing.Size(60, 29);
            this.ảnhToolStripMenuItem.Text = "Ảnh";
            this.ảnhToolStripMenuItem.Click += new System.EventHandler(this.ảnhToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.btn_them);
            this.panel2.Controls.Add(this.txt_timkiem);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.cbo_loc);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1872, 96);
            this.panel2.TabIndex = 86;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1299, 24);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(108, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 96;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.Peru;
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_them.Font = new System.Drawing.Font("Poor Richard", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_them.Location = new System.Drawing.Point(978, 24);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(194, 36);
            this.btn_them.TabIndex = 95;
            this.btn_them.Text = "Thêm Hàng Hóa";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(8, 31);
            this.txt_timkiem.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.PlaceholderText = "Tìm Kiếm Theo Mã Sản Phẩm";
            this.txt_timkiem.Size = new System.Drawing.Size(258, 31);
            this.txt_timkiem.TabIndex = 94;
            this.txt_timkiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_timkiem_KeyUp);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(316, 20);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(71, 46);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 93;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1416, 24);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(108, 45);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 91;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(1181, 24);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(108, 45);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 91;
            this.pictureBox5.TabStop = false;
            // 
            // cbo_loc
            // 
            this.cbo_loc.FormattingEnabled = true;
            this.cbo_loc.Location = new System.Drawing.Point(410, 31);
            this.cbo_loc.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cbo_loc.Name = "cbo_loc";
            this.cbo_loc.Size = new System.Drawing.Size(188, 33);
            this.cbo_loc.TabIndex = 3;
            this.cbo_loc.SelectedIndexChanged += new System.EventHandler(this.cbo_loc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(1549, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nháy Đúp 1 Dòng Để Xem Chi Tiết";
            // 
            // dgrid_sanpham
            // 
            this.dgrid_sanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_sanpham.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgrid_sanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_sanpham.Location = new System.Drawing.Point(0, 134);
            this.dgrid_sanpham.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.dgrid_sanpham.Name = "dgrid_sanpham";
            this.dgrid_sanpham.RowHeadersWidth = 51;
            this.dgrid_sanpham.RowTemplate.Height = 29;
            this.dgrid_sanpham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_sanpham.Size = new System.Drawing.Size(1872, 1054);
            this.dgrid_sanpham.TabIndex = 85;
            this.dgrid_sanpham.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_sanpham_CellDoubleClick);
            // 
            // FrmHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(1712, 1050);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgrid_sanpham);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "FrmHangHoa";
            this.Text = "FrmHangHoa";
            this.Load += new System.EventHandler(this.FrmHangHoa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_sanpham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem chaasToolStripMenuItem;
        private ToolStripMenuItem loạiGiàyToolStripMenuItem;
        private ToolStripMenuItem sizeGiàyToolStripMenuItem;
        private ToolStripMenuItem xuấtXứToolStripMenuItem;
        private Panel panel2;
        private TextBox txt_timkiem;
        private PictureBox pictureBox6;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private ComboBox cbo_loc;
        private Label label1;
        private DataGridView dgrid_sanpham;
        private Button btn_them;
        private ToolStripMenuItem nhàSảnXuấtToolStripMenuItem;
        private ToolStripMenuItem ảnhToolStripMenuItem;
        private PictureBox pictureBox3;
    }
}