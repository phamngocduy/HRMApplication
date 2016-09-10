using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmChucDanhGiangVien
    {
        public dmChucDanhGiangVien()
        {
            this.nvChucDanhGiangViens = new List<nvChucDanhGiangVien>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<int> stt { get; set; }
		[StringLength(10)]
        public string maChucDanhGiangVien { get; set; }
		[Required]
		[StringLength(50)]
        public string tenChucDanhGiangVien { get; set; }
		[Required]
        public byte doUuTien { get; set; }

        public virtual ICollection<nvChucDanhGiangVien> nvChucDanhGiangViens { get; set; }
    }
}
