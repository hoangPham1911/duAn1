﻿using _1_DAL.Models;
using _2_BUS.IService;
using _2_BUS.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_PL.View
{
    public partial class Frm_ThongTinNguoiDung : Form
    {
        private INhanVienServices inhanvien;
        private IChucVuServices ichucvu;
        public Frm_ThongTinNguoiDung()
        {
            InitializeComponent();
            inhanvien = new NhanVienServices();
            ichucvu = new ChucVuServices();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        public Image ConvertByteArrayToImg(byte[] data)
        {
            if (data == null) return null;
            else
            {
                using (MemoryStream ms = new MemoryStream(data))
                {
                    if (ms == null) return null;
                    else
                        return Image.FromStream(ms);
                }
            }
        }
        private void Frm_ThongTinNguoiDung_Load(object sender, EventArgs e)
        {
            var nv = inhanvien.GetAll().FirstOrDefault(p => p.Id == FrmDangNhap._IdStaff);
            if (nv != null)
            {
                lb_maNguoid.Text = nv.Ma;
                lb_hoten.Text = nv.Ho + nv.TenDem + nv.Ten;
                lb_ngaysinh.Text = nv.NamSinh.ToString();
                lb_quequan.Text = nv.QueQuan;
                lb_sdt.Text = nv.Sdt;
                lb_email.Text = nv.Email;
                lb_cccd.Text = nv.CMND;
                lb_gioitinh.Text = nv.GioiTinh;
                this.ptb_anh.Image = ConvertByteArrayToImg(nv.Anh);
            }

            var cv = ichucvu.GetChucVu().FirstOrDefault(p => p.IdNv == FrmDangNhap._IdStaff);
            if (cv != null)
            {
                lb_CV.Text = cv.Ten;
            }     
                
        }
    }
}
