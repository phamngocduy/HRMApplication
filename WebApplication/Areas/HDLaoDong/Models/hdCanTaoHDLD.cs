using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases_HDLaoDong.Models
{
    public partial class hdCanTaoHDLD
    {
		[Required]
        public int id { get; set; }
		[Required]
		[StringLength(50)]
        public string MaNV { get; set; }
		[StringLength(50)]
        public string MaTD { get; set; }
		[Required]
		[StringLength(50)]
        public string Hoten { get; set; }
        public Nullable<int> GioiTinh_id { get; set; }
        public Nullable<int> Quoctich_id { get; set; }
        public Nullable<System.DateTime> Ngaysinh { get; set; }
        public string Noisinh { get; set; }
        public string Diachithuongtru { get; set; }
		[StringLength(15)]
        public string soCMND { get; set; }
        public Nullable<System.DateTime> cmndNgaycap { get; set; }
        public Nullable<int> cmndNoicap { get; set; }
        public Nullable<int> VitriCT_id { get; set; }
        public Nullable<int> Donvi_id { get; set; }
        public Nullable<int> Nghenghiep_id { get; set; }
        public string Lydo { get; set; }

    }
}
