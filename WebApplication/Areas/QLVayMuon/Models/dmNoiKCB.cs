using System;
using System.Collections.Generic;

namespace HRM.QLVayMuon.Models
{
    public partial class dmNoiKCB
    {
        public dmNoiKCB()
        {
            this.nvbhNhanVienBHXHs = new List<nvbhNhanVienBHXH>();
        }

        public int id { get; set; }
        public string MaBV { get; set; }
        public string GhiChu { get; set; }
        public Nullable<int> Stt { get; set; }
        public string TenBV { get; set; }
        public virtual ICollection<nvbhNhanVienBHXH> nvbhNhanVienBHXHs { get; set; }
    }
}
