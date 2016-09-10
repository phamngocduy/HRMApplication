using System;
using System.Collections.Generic;

namespace HRM.QLVayMuon.Models
{
    public partial class HoSoVayMuon
    {
        public int id { get; set; }
        public int idGiayTo { get; set; }
        public int idKhoanVay { get; set; }
        public bool TrangThai { get; set; }
        public string URLFile { get; set; }
        public virtual dmGiayTo dmGiayTo { get; set; }
        public virtual KhoanVay KhoanVay { get; set; }
    }
}
