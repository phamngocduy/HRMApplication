using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class CTNganHan
    {
        public CTNganHan()
        {
            this.nvCTNganHans = new List<nvCTNganHan>();
        }

		[Required]
        public int id { get; set; }
		[Required]
        public int LoaiCT_id { get; set; }
        public string NoiDung { get; set; }
        public string DiaDiem { get; set; }
		[Required]
        public bool NuocNgoai { get; set; }
        public Nullable<System.DateTime> ThoiGianBatDau { get; set; }
        public Nullable<System.DateTime> ThoiGianKetThuc { get; set; }
		[StringLength(50)]
        public string SoQuyetDinh { get; set; }
        public Nullable<System.DateTime> NgayCapQuyetDinh { get; set; }
        public Nullable<int> KinhPhiHoTro { get; set; }
		[StringLength(150)]
        public string GhiChu { get; set; }

        public virtual ICollection<nvCTNganHan> nvCTNganHans { get; set; }
		[ForeignKey("LoaiCT_id")]
        public virtual dmLoaiCongTac LoaiCongTac { get; set; }
    }
}
