using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmLoaiNghiNganHan
    {
        public dmLoaiNghiNganHan()
        {
            this.nvQTNghiNganHans = new List<nvQTNghiNganHan>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<int> stt { get; set; }
		[StringLength(10)]
        public string maLoaiNghiNganHan { get; set; }
		[Required]
		[StringLength(50)]
        public string tenLoaiNghiNganHan { get; set; }
		[Required]
        public bool tinhThamNien { get; set; }
		[Required]
        public bool khongHuongLuong { get; set; }

        public virtual ICollection<nvQTNghiNganHan> nvQTNghiNganHans { get; set; }
    }
}
