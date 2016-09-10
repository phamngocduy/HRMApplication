using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmChucDanhChuyenMon
    {
        public dmChucDanhChuyenMon()
        {
            this.nvQLThuViecs = new List<nvQLThuViec>();
            this.nvQTLamViecs = new List<nvQTLamViec>();
            this.nvTrangThaiLuongs = new List<nvTrangThaiLuong>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<int> stt { get; set; }
		[StringLength(10)]
        public string maChucDanhChuyenMon { get; set; }
		[Required]
		[StringLength(50)]
        public string tenChucDanhChuyenMon { get; set; }
		[Required]
        public bool laDayHoc { get; set; }
		[Required]
        public bool qlTapSu { get; set; }

        public virtual ICollection<nvQLThuViec> nvQLThuViecs { get; set; }
        public virtual ICollection<nvQTLamViec> nvQTLamViecs { get; set; }
        public virtual ICollection<nvTrangThaiLuong> nvTrangThaiLuongs { get; set; }
    }
}
