using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class tdXuatExcel
    {
        public string HoTenUngVien { get; set; }
        public string GioiTinh { get; set; }
        public string NgaySinh { get; set; }
        public string NoiSinh { get; set; }
        public string SoTheDinhDanh { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public string DiaChiLienLac { get; set; }
        public List<String> BangCap { get; set; }
        public string ViTriUngTuyen { get; set; }
        public string DonViUngTuyen { get; set; }
        public string KinhNghiemLamViec { get; set; }
        public string KetQuaTuyenDung { get; set; }
        public string NhanXet { get; set; }
    }
}
