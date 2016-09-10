using System;
using System.Collections.Generic;

namespace HRM.QLVayMuon.Models
{
    public partial class v_nvbhDanhSachDieuChinhTangGiam1
    {
        public int id { get; set; }
        public int MoiNhat { get; set; }
        public bool XacNhan { get; set; }
        public bool KhongTraThe { get; set; }
        public string idLoaiTangGiam { get; set; }
        public int idLoaiDieuChinh { get; set; }
        public Nullable<int> idnvbhNhanVienBHXH { get; set; }
        public Nullable<System.DateTime> NgayPhatSinh { get; set; }
        public string ChucVuCongViec { get; set; }
        public Nullable<long> TienLuongMDC { get; set; }
        public Nullable<long> PCChucVuMDC { get; set; }
        public Nullable<long> PCThamNienVuotKhungMDC { get; set; }
        public Nullable<long> PCThamNienNgheMDC { get; set; }
        public Nullable<long> PCKhacMDC { get; set; }
        public Nullable<long> TienLuongMDM { get; set; }
        public Nullable<long> PCChucVuMDM { get; set; }
        public Nullable<long> PCThamNienVuotKhungMDM { get; set; }
        public Nullable<long> PCThamNienNgheMDM { get; set; }
        public Nullable<long> PCKhacMDM { get; set; }
        public System.DateTime TuThangNam { get; set; }
        public Nullable<System.DateTime> DenThangNam { get; set; }
        public Nullable<double> TyLeDong { get; set; }
        public string GhiChu { get; set; }
        public Nullable<int> DonVi_id { get; set; }
        public Nullable<bool> TGBHTN { get; set; }
        public string LoaiDieuChinh { get; set; }
        public string HoVaTen { get; set; }
        public Nullable<int> SoBHXH { get; set; }
        public Nullable<double> tldong { get; set; }
    }
}
