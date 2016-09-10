using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.QLBHXH.Models
{
    public partial class dmLoaiDieuChinh
    {
        public dmLoaiDieuChinh()
        {
            this.dmLoaiTangGiams = new List<dmLoaiTangGiam>();
            this.nvbhDanhSachDieuChinhChucDanhs = new List<nvbhDanhSachDieuChinhChucDanh>();
            this.nvbhDanhSachDieuChinhTangGiams = new List<nvbhDanhSachDieuChinhTangGiam>();
        }

		[Required]
        public int id { get; set; }
		[StringLength(200)]
        public string LoaiDieuChinh { get; set; }
		[StringLength(200)]
        public string GhiChu { get; set; }
        public Nullable<int> STT { get; set; }

        public virtual ICollection<dmLoaiTangGiam> dmLoaiTangGiams { get; set; }
        public virtual ICollection<nvbhDanhSachDieuChinhChucDanh> nvbhDanhSachDieuChinhChucDanhs { get; set; }
        public virtual ICollection<nvbhDanhSachDieuChinhTangGiam> nvbhDanhSachDieuChinhTangGiams { get; set; }
    }
}
