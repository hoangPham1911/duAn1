﻿using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IService
{
    public interface IHoaDonChiTietService
    {
        bool ThemHoaDonChiTiet(HoaDonChiTietThemViewModel Hoadonnew);
        bool SuaHoaDonChiTiet(HoaDonChiTietUpdateView Hoadonold);
        bool XoaHoaDonChiTiet(Guid Hoadonold);
       public List<HoaDonChiTietViewModel> GetAllHoaDonDB();
       public List<SanPhamTrongHoaDonViewModels> GetAllProductInReceipt();
    }
}