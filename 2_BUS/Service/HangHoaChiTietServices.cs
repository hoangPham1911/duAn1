﻿using _1.DAL.IRepostiories;
using _1.DAL.Repostiores;
using _1_DAL.IRepositories;
using _1_DAL.IRepostiories;
using _1_DAL.Models;
using _1_DAL.Repositores;
using _1_DAL.Repostiores;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.Service
{
    public class HangHoaChiTietServices
    {
        IProductDetailRepository _IHangHoaChiTietRepository;
        IProductRepository _iHangHoaRepository;
        IQuocGiaRepository _iQuocgiaRepository;
        INsxRepository _iNsxRepository;
        ISizeShoseRepository _iSizeshoesRepository;
        ILoaiGiayRepository _iLoaiGiayRepository;
        IChatLieuRepository _iChatLieuRepository;
        IImageRepositoriy _iAnhRepositoriy;

        public HangHoaChiTietServices()
        {
            _IHangHoaChiTietRepository = new ProductDetailRepositores();
            _iHangHoaRepository = new ProductRepositores();
            _iQuocgiaRepository = new QuocGiaRepositores();
            _iNsxRepository = new NsxRepositores();
            _iSizeshoesRepository = new SizeShoseRepositores();
            _iLoaiGiayRepository = new LoaiGiayRepositores();
            _iChatLieuRepository = new ChatLieuRepositores();
            _iAnhRepositoriy = new ImageRepositoriy();
        }

        public List<HangHoaChiTietViewModels> GetAllHangHoa()
        {
            return (from a in _IHangHoaChiTietRepository.getAll()
                    join b in _iHangHoaRepository.getAll() on a.IdSp equals b.Id
                    join c in _iQuocgiaRepository.getAll() on a.IdQuocGia equals c.Id
                    join d in _iNsxRepository.getAll() on b.IdNsx equals d.Id
                    join e in _iSizeshoesRepository.getAll() on a.IdSizeGiay equals e.Id
                    join f in _iLoaiGiayRepository.getAll() on a.IdLoaiGiay equals f.Id
                    join g in _iChatLieuRepository.getAll() on a.IdChatLieu equals g.Id
                    join h in _iAnhRepositoriy.getAll() on a.IdAnh equals h.ID
                    select new HangHoaChiTietViewModels
                    {
                        IdSp = b.Id,
                        IdQuocGia= c.Id,
                        IdNsx = d.Id,
                        IdSizeGiay= e.Id,
                        IdLoaiGiay= f.Id,
                        IdChatLieu= g.Id,
                        IdAnh = h.ID,
                        Ma = b.Ma,
                        Ten= b.Ten,
                        TrangThai = b.TrangThai,
                        NamBh = a.NamBh,
                        MoTa = a.MoTa,
                        SoLuongTon = a.SoLuongTon,
                        GiaBan = a.GiaBan,
                        GiaNhap = a.GiaNhap

                    }).ToList();
        }

        public bool ThemHangHoa(HangHoaChiTietThemViewModels HangHoas)
        {
            ChiTietHangHoa chiTietHangHoa = new ChiTietHangHoa();
            HangHoa hangHoa = new HangHoa();
            chiTietHangHoa.IdQuocGia = HangHoas.IdQuocGia;
            hangHoa.IdNsx = HangHoas.IdNsx;
            chiTietHangHoa.IdSizeGiay = HangHoas.IdSizeGiay;
            chiTietHangHoa.IdLoaiGiay = HangHoas.IdLoaiGiay;
            chiTietHangHoa.IdChatLieu = HangHoas.IdChatLieu;
            chiTietHangHoa.IdAnh = HangHoas.IdAnh;
            hangHoa.Ma = HangHoas.Ma;
            hangHoa.Ten = HangHoas.Ten;
            hangHoa.TrangThai = HangHoas.TrangThai;
            chiTietHangHoa.NamBh = HangHoas.NamBh;
            chiTietHangHoa.SoLuongTon = HangHoas.SoLuongTon;
            chiTietHangHoa.MoTa = HangHoas.MoTa;
            chiTietHangHoa.GiaNhap = HangHoas.GiaNhap;
            chiTietHangHoa.GiaBan = HangHoas.GiaBan;
            if (_IHangHoaChiTietRepository.add(chiTietHangHoa) && _iHangHoaRepository.add(hangHoa))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SuaHangHoa(HangHoaChiTietUpdateViewModels HangHoas)
        {
            ChiTietHangHoa chiTietHangHoa = new ChiTietHangHoa();
            HangHoa hangHoa = new HangHoa();
            chiTietHangHoa.IdQuocGia = HangHoas.IdQuocGia;
            hangHoa.IdNsx = HangHoas.IdNsx;
            chiTietHangHoa.IdSizeGiay = HangHoas.IdSizeGiay;
            chiTietHangHoa.IdLoaiGiay = HangHoas.IdLoaiGiay;
            chiTietHangHoa.IdChatLieu = HangHoas.IdChatLieu;
            chiTietHangHoa.IdAnh = HangHoas.IdAnh;
            hangHoa.Ma = HangHoas.Ma;
            hangHoa.Ten = HangHoas.Ten;
            hangHoa.TrangThai = HangHoas.TrangThai;
            chiTietHangHoa.NamBh = HangHoas.NamBh;
            chiTietHangHoa.SoLuongTon = HangHoas.SoLuongTon;
            chiTietHangHoa.MoTa = HangHoas.MoTa;
            chiTietHangHoa.GiaNhap = HangHoas.GiaNhap;
            chiTietHangHoa.GiaBan = HangHoas.GiaBan;
            if (_IHangHoaChiTietRepository.update(chiTietHangHoa) && _iHangHoaRepository.update(hangHoa))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool XoaHangHoa(Guid hanghoactid, HangHoa hanghoaid)
        {
            if (_IHangHoaChiTietRepository.remove(hanghoactid) && _iHangHoaRepository.remove(hanghoaid)) return true;
            return false;
        }

    }
}