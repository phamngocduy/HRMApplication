using System;
using System.Collections.Generic;

namespace HRM.QLVayMuon.Models
{
    public partial class nvbhDanhSachDieuChinhTangGiam
    {
        public int id { get; set; }
        public int MoiNhat { get; set; }
        public bool XacNhan { get; set; }
        public bool KhongTraThe { get; set; }
        public string idLoaiTangGiam { get; set; }
        public int idLoaiDieuChinh { get; set; }
        public Nullable<int> idnvbhNhanVienBHXH { get; set; }
        public Nullable<System.DateTime> NgayPhatSinh { get; set; }
        public System.DateTime TuThangNam { get; set; }
        public Nullable<System.DateTime> DenThangNam { get; set; }
        public string ChucVuCongViec { get; set; }
        public Nullable<long> TienLuongMDC { get; set; }
        public Nullable<long> TienLuongMDM { get; set; }
        public Nullable<long> PCChucVuMDC { get; set; }
        public Nullable<long> PCThamNienVuotKhungMDC { get; set; }
        public Nullable<long> PCThamNienNgheMDC { get; set; }
        public Nullable<long> PCKhacMDC { get; set; }
        public Nullable<long> PCChucVuMDM { get; set; }
        public Nullable<long> PCThamNienVuotKhungMDM { get; set; }
        public Nullable<long> PCThamNienNgheMDM { get; set; }
        public Nullable<long> PCKhacMDM { get; set; }
        public Nullable<double> TyLeDong { get; set; }
        public string GhiChu { get; set; }
        public string Tang { get; set; }
        public string CVCu { get; set; }
        public string CVMoi { get; set; }
        public Nullable<int> NV_id { get; set; }
        public Nullable<int> DonVi_id { get; set; }
        public Nullable<bool> TGBHTN { get; set; }
        public Nullable<long> TienLuong { get; set; }
        public Nullable<double> HSL { get; set; }
        public Nullable<long> MLTTV { get; set; }
        public Nullable<long> MLTTC { get; set; }
        public Nullable<double> TLBHXH { get; set; }
        public Nullable<double> TLBHTN { get; set; }
        public Nullable<double> TLBHYT { get; set; }
        public Nullable<int> QTID { get; set; }
        public virtual dmLoaiDieuChinh dmLoaiDieuChinh { get; set; }
    }
}
