using System;
using System.Collections.Generic;

namespace HRM.QLVayMuon.Models
{
    public partial class v_ChucDanh
    {
        public int id { get; set; }
        public int idchucdanh { get; set; }
        public Nullable<int> NV_id { get; set; }
        public string CVMoi { get; set; }
        public string GhiChu { get; set; }
        public System.DateTime TuThangNam { get; set; }
        public string HoVaTen { get; set; }
        public Nullable<int> SoBHXH { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public Nullable<bool> Nu { get; set; }
        public int idLoaiDieuChinh { get; set; }
        public int MoiNhat { get; set; }
        public string CVCu { get; set; }
        public Nullable<System.DateTime> DenThangNam { get; set; }
        public Nullable<System.DateTime> NgayPhatSinh { get; set; }
    }
}
