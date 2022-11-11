﻿using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepostiories
{
    public interface IreceiptDetailRepository
    {
        bool add(HoaDonChiTiet rd);
        bool remove(Guid IdSpCt);
        bool update(HoaDonChiTiet rd);

        List<HoaDonChiTiet> GetAll();
    }
}