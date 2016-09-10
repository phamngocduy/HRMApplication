using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class nvHeSoLuong
    {
        public nvHeSoLuong()
        {
            this.NhanViens = new List<NhanVien>();
            this.nvGiuBacLuongs = new List<nvGiuBacLuong>();
            this.nvQLHoSoHSLs = new List<nvQLHoSoHSL>();
        }

		[Required]
        public int id { get; set; }
		[Required]
        public int NV_id { get; set; }
		[Required]
        public System.DateTime NgayBatDau { get; set; }
        public Nullable<System.DateTime> NgayKetThuc { get; set; }
		[Required]
        public int ThoiGianGiuBac { get; set; }
        public Nullable<int> NhomNgach_id { get; set; }
        public Nullable<int> Ngach_id { get; set; }
		[StringLength(4)]
        public string BacLuong { get; set; }
		[Required]
        public double HeSoLuong { get; set; }
		[Required]
        public int PhuCap { get; set; }
		[StringLength(50)]
        public string LyDoThayDoi { get; set; }
		[Required]
        public int User_id { get; set; }
		[StringLength(50)]
        public string GhiChu { get; set; }
		[StringLength(20)]
        public string SoQuyetDinh { get; set; }

		[ForeignKey("Ngach_id")]
        public virtual dmNgachVienChuc NgachVC { get; set; }
		[ForeignKey("NhomNgach_id")]
        public virtual dmNhomNgachVienChuc NhomNgach { get; set; }
        public virtual ICollection<NhanVien> NhanViens { get; set; }
		[ForeignKey("NV_id")]
        public virtual NhanVien NhanVien { get; set; }
        public virtual ICollection<nvGiuBacLuong> nvGiuBacLuongs { get; set; }
        public virtual ICollection<nvQLHoSoHSL> nvQLHoSoHSLs { get; set; }
    }
}
