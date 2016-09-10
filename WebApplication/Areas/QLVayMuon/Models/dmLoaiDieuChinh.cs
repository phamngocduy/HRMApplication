using System;
using System.Collections.Generic;

namespace HRM.QLVayMuon.Models
{
    public partial class dmLoaiDieuChinh
    {
        public dmLoaiDieuChinh()
        {
            this.dmLoaiTangGiams = new List<dmLoaiTangGiam>();
            this.nvbhDanhSachDieuChinhChucDanhs = new List<nvbhDanhSachDieuChinhChucDanh>();
            this.nvbhDanhSachDieuChinhTangGiams = new List<nvbhDanhSachDieuChinhTangGiam>();
        }

        public int id { get; set; }
        public string LoaiDieuChinh { get; set; }
        public string GhiChu { get; set; }
        public Nullable<int> STT { get; set; }
        public virtual ICollection<dmLoaiTangGiam> dmLoaiTangGiams { get; set; }
        public virtual ICollection<nvbhDanhSachDieuChinhChucDanh> nvbhDanhSachDieuChinhChucDanhs { get; set; }
        public virtual ICollection<nvbhDanhSachDieuChinhTangGiam> nvbhDanhSachDieuChinhTangGiams { get; set; }
    }
}
