using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases_HDLaoDong.Models
{
    public partial class hdPhuLucHD2
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int HD_id { get; set; }
		[Required]
        public System.DateTime NgaylapPL { get; set; }
		[StringLength(10)]
        public string HSLuong { get; set; }
		[StringLength(15)]
        public string Mucluongtoithieu { get; set; }
		[StringLength(15)]
        public string CSTienluong { get; set; }
		[StringLength(10)]
        public string HSCDCM { get; set; }
		[StringLength(10)]
        public string HSNhiemvu { get; set; }
		[StringLength(10)]
        public string HSThamnien { get; set; }
		[StringLength(10)]
        public string HSKLCV1 { get; set; }
		[StringLength(10)]
        public string HSSLSV2 { get; set; }
		[StringLength(10)]
        public string HSHQCVdonvi { get; set; }
		[StringLength(10)]
        public string HSHQCVcanhan { get; set; }
		[StringLength(15)]
        public string Thulao { get; set; }
		[StringLength(15)]
        public string Thunhap { get; set; }
        public string Ghichu { get; set; }
        public Nullable<bool> Daky { get; set; }
		[StringLength(10)]
        public string HQCV { get; set; }

		[ForeignKey("HD_id")]
        public virtual hdChiTietHDLD hdChiTietHDLD { get; set; }
    }
}
