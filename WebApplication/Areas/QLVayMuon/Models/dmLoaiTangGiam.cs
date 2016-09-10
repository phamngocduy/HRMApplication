using System;
using System.Collections.Generic;

namespace HRM.QLVayMuon.Models
{
    public partial class dmLoaiTangGiam
    {
        public int id { get; set; }
        public string Ma { get; set; }
        public string LoaiTangGiam { get; set; }
        public string GhiChu { get; set; }
        public Nullable<int> STT { get; set; }
        public Nullable<int> idLoaiDieuChinh { get; set; }
        public virtual dmLoaiDieuChinh dmLoaiDieuChinh { get; set; }
    }
}
