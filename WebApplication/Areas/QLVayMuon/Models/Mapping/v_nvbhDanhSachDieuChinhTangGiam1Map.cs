using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.QLVayMuon.Models.Mapping
{
    public class v_nvbhDanhSachDieuChinhTangGiam1Map : EntityTypeConfiguration<v_nvbhDanhSachDieuChinhTangGiam1>
    {
        public v_nvbhDanhSachDieuChinhTangGiam1Map()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.MoiNhat, t.XacNhan, t.KhongTraThe, t.idLoaiDieuChinh, t.TuThangNam });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MoiNhat)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.idLoaiTangGiam)
                .HasMaxLength(5);

            this.Property(t => t.idLoaiDieuChinh)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ChucVuCongViec)
                .HasMaxLength(50);

            this.Property(t => t.GhiChu)
                .HasMaxLength(200);

            this.Property(t => t.LoaiDieuChinh)
                .HasMaxLength(200);

            this.Property(t => t.HoVaTen)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("v_nvbhDanhSachDieuChinhTangGiam1");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.MoiNhat).HasColumnName("MoiNhat");
            this.Property(t => t.XacNhan).HasColumnName("XacNhan");
            this.Property(t => t.KhongTraThe).HasColumnName("KhongTraThe");
            this.Property(t => t.idLoaiTangGiam).HasColumnName("idLoaiTangGiam");
            this.Property(t => t.idLoaiDieuChinh).HasColumnName("idLoaiDieuChinh");
            this.Property(t => t.idnvbhNhanVienBHXH).HasColumnName("idnvbhNhanVienBHXH");
            this.Property(t => t.NgayPhatSinh).HasColumnName("NgayPhatSinh");
            this.Property(t => t.ChucVuCongViec).HasColumnName("ChucVuCongViec");
            this.Property(t => t.TienLuongMDC).HasColumnName("TienLuongMDC");
            this.Property(t => t.PCChucVuMDC).HasColumnName("PCChucVuMDC");
            this.Property(t => t.PCThamNienVuotKhungMDC).HasColumnName("PCThamNienVuotKhungMDC");
            this.Property(t => t.PCThamNienNgheMDC).HasColumnName("PCThamNienNgheMDC");
            this.Property(t => t.PCKhacMDC).HasColumnName("PCKhacMDC");
            this.Property(t => t.TienLuongMDM).HasColumnName("TienLuongMDM");
            this.Property(t => t.PCChucVuMDM).HasColumnName("PCChucVuMDM");
            this.Property(t => t.PCThamNienVuotKhungMDM).HasColumnName("PCThamNienVuotKhungMDM");
            this.Property(t => t.PCThamNienNgheMDM).HasColumnName("PCThamNienNgheMDM");
            this.Property(t => t.PCKhacMDM).HasColumnName("PCKhacMDM");
            this.Property(t => t.TuThangNam).HasColumnName("TuThangNam");
            this.Property(t => t.DenThangNam).HasColumnName("DenThangNam");
            this.Property(t => t.TyLeDong).HasColumnName("TyLeDong");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.DonVi_id).HasColumnName("DonVi_id");
            this.Property(t => t.TGBHTN).HasColumnName("TGBHTN");
            this.Property(t => t.LoaiDieuChinh).HasColumnName("LoaiDieuChinh");
            this.Property(t => t.HoVaTen).HasColumnName("HoVaTen");
            this.Property(t => t.SoBHXH).HasColumnName("SoBHXH");
            this.Property(t => t.tldong).HasColumnName("tldong");
        }
    }
}
