using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dsTTKyLuat
    {
		[Required]
        public int id { get; set; }
		[Required]
        public int NV_id { get; set; }
		[Required]
        public int HinhThuc_id { get; set; }
		[Required]
		[StringLength(20)]
        public string SoQuyetDinh { get; set; }
		[Required]
        public System.DateTime NgayQuyetDinh { get; set; }
		[StringLength(50)]
        public string CapRaQuyetDinh { get; set; }
		[Required]
		[StringLength(50)]
        public string DonViRaKyLuat { get; set; }
		[StringLength(100)]
        public string LyDoKyLuat { get; set; }
		[StringLength(50)]
        public string MucBoiThuong { get; set; }
        public Nullable<bool> TrangThai { get; set; }
        public string GhiChu { get; set; }
		[StringLength(10)]
        public string maHinhThucKyLuat { get; set; }
		[StringLength(50)]
        public string tenHinhThucKyLuat { get; set; }
        public Nullable<int> sttHinhThucKyLuat { get; set; }

    }
}
