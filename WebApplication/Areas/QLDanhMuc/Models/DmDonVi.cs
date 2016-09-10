using System;

using HRM.Databases.Models;
namespace HRM.QLDanhMuc.Models
{
    public static class dmDonViExt
    {
        public static dmDonVi getDonViChuQuan(this dmDonVi donvi)
        {
            return donvi.DonViChuQuan;
        }

        public static string tenDonViChuQuan(this dmDonVi donvi)
        {
            if (donvi.getDonViChuQuan() == null)
                return String.Empty;
            else return donvi.getDonViChuQuan().tenDonVi;
        }
    }
}