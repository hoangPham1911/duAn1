﻿namespace _3_PL.View
{
    partial class Frm_NSX
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
            this.tb_ma = new System.Windows.Forms.TextBox();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_showsize = new System.Windows.Forms.DataGridView();
            this.rdb_ngung = new System.Windows.Forms.RadioButton();
            this.rdb_con = new System.Windows.Forms.RadioButton();
            this.tb_sosize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mã = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showsize)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã ";
            // 
            // tb_ma
            // 
            this.tb_ma.Location = new System.Drawing.Point(136, 46);
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.Size = new System.Drawing.Size(341, 31);
            this.tb_ma.TabIndex = 0;
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Location = new System.Drawing.Point(191, 266);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(482, 31);
            this.tb_timkiem.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tìm kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trạng thái";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_showsize);
            this.groupBox3.Location = new System.Drawing.Point(55, 324);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(957, 289);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin nhà sản xuất";
            // 
            // dgv_showsize
            // 
            this.dgv_showsize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_showsize.Location = new System.Drawing.Point(35, 39);
            this.dgv_showsize.Name = "dgv_showsize";
            this.dgv_showsize.RowHeadersWidth = 62;
            this.dgv_showsize.RowTemplate.Height = 33;
            this.dgv_showsize.Size = new System.Drawing.Size(882, 225);
            this.dgv_showsize.TabIndex = 0;
            // 
            // rdb_ngung
            // 
            this.rdb_ngung.AutoSize = true;
            this.rdb_ngung.Location = new System.Drawing.Point(343, 166);
            this.rdb_ngung.Name = "rdb_ngung";
            this.rdb_ngung.Size = new System.Drawing.Size(163, 29);
            this.rdb_ngung.TabIndex = 8;
            this.rdb_ngung.TabStop = true;
            this.rdb_ngung.Text = "Ngừng sản xuất";
            this.rdb_ngung.UseVisualStyleBackColor = true;
            // 
            // rdb_con
            // 
            this.rdb_con.AutoSize = true;
            this.rdb_con.Location = new System.Drawing.Point(154, 166);
            this.rdb_con.Name = "rdb_con";
            this.rdb_con.Size = new System.Drawing.Size(139, 29);
            this.rdb_con.TabIndex = 7;
            this.rdb_con.TabStop = true;
            this.rdb_con.Text = "Còn sản xuất";
            this.rdb_con.UseVisualStyleBackColor = true;
            // 
            // tb_sosize
            // 
            this.tb_sosize.Location = new System.Drawing.Point(136, 102);
            this.tb_sosize.Name = "tb_sosize";
            this.tb_sosize.Size = new System.Drawing.Size(341, 31);
            this.tb_sosize.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_sua);
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Location = new System.Drawing.Point(688, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 300);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(45, 129);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(240, 57);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(45, 201);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(239, 57);
            this.btn_xoa.TabIndex = 1;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(45, 57);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(239, 57);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_ngung);
            this.groupBox1.Controls.Add(this.rdb_con);
            this.groupBox1.Controls.Add(this.tb_sosize);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_ma);
            this.groupBox1.Location = new System.Drawing.Point(55, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 218);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết nhà sản xuất";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // ID
            // 
            this.ID.HeaderText = "Column1";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Width = 150;
            // 
            // Mã
            // 
            this.Mã.HeaderText = "Mã";
            this.Mã.MinimumWidth = 8;
            this.Mã.Name = "Mã";
            this.Mã.Width = 150;
            // 
            // Frm_NSX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 623);
            this.Controls.Add(this.tb_timkiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_NSX";
            this.Text = "Frm_NSX";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showsize)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tb_ma;
        private TextBox tb_timkiem;
        private Label label3;
        private Label label2;
        private GroupBox groupBox3;
        private DataGridView dgv_showsize;
        private RadioButton rdb_ngung;
        private RadioButton rdb_con;
        private TextBox tb_sosize;
        private Label label4;
        private GroupBox groupBox2;
        private Button btn_sua;
        private Button btn_xoa;
        private Button btn_them;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Mã;
    }
}