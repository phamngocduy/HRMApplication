using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.QLThinhGiang.Models
{
    public partial class nvDiaChiNha
    {
        public nvDiaChiNha()
        {
            this.NhanViens = new List<NhanVien>();
            this.nvSoYeuLyLiches = new List<nvSoYeuLyLich>();
            this.nvSoYeuLyLiches1 = new List<nvSoYeuLyLich>();
        }

		[Required]
        public int id { get; set; }
		[Required]
        public int NV_id { get; set; }
        public string DiaChi { get; set; }
        public Nullable<int> PhuongXa_id { get; set; }
        public Nullable<int> QuanHuyen_id { get; set; }
        public Nullable<int> TinhThanh_id { get; set; }

        public virtual ICollection<NhanVien> NhanViens { get; set; }
		[ForeignKey("NV_id")]
        public virtual NhanVien NhanVien { get; set; }
        public virtual ICollection<nvSoYeuLyLich> nvSoYeuLyLiches { get; set; }
        public virtual ICollection<nvSoYeuLyLich> nvSoYeuLyLiches1 { get; set; }
    }
}
