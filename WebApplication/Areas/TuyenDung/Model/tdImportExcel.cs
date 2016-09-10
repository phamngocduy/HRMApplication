using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public class tdImportExcel
    {
        public string HoVaTen { get; set; }
        public string GioiTinh { get; set; }
        public string NgaySinh { get; set; }
        public string NoiSinh { get; set; }
        public string LoaiTheDinhDanh { get; set; }
        public string SoThe { get; set; }
        public string NoiCap { get; set; }
        public string NgayCap { get; set; }
        public string NgayHetHan { get; set; }
        public string DTDiDong { get; set; }
        public string DTNha { get; set; }
        public string Email { get; set; }
        public string DiaChiLienHe { get; set; }
        public List<string> BangCap { get; set; }
        public string ViTriUngTuyen { get; set; }
        public string DonViUngTuyen { get; set; }
        public string NgayNhanHoSo { get; set; }
        public bool? KetQuaTuyenDung { get; set; }
        public string GhiChu { get; set; }
    }
}