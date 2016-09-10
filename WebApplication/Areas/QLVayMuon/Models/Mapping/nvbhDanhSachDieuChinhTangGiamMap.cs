using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.QLVayMuon.Models.Mapping
{
    public class nvbhDanhSachDieuChinhTangGiamMap : EntityTypeConfiguration<nvbhDanhSachDieuChinhTangGiam>
    {
        public nvbhDanhSachDieuChinhTangGiamMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.idLoaiTangGiam)
                .HasMaxLength(5);

            this.Property(t => t.ChucVuCongViec)
                .HasMaxLength(50);

            this.Property(t => t.GhiChu)
                .HasMaxLength(200);

            this.Property(t => t.Tang)
                .HasMaxLength(200);

            this.Property(t => t.CVCu)
                .HasMaxLength(200);

            this.Property(t => t.CVMoi)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("nvbhDanhSachDieuChinhTangGiam");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.MoiNhat).HasColumnName("MoiNhat");
            this.Property(t => t.XacNhan).HasColumnName("XacNhan");
            this.Property(t => t.KhongTraThe).HasColumnName("KhongTraThe");
            this.Property(t => t.idLoaiTangGiam).HasColumnName("idLoaiTangGiam");
            this.Property(t => t.idLoaiDieuChinh).HasColumnName("idLoaiDieuChinh");
            this.Property(t => t.idnvbhNhanVienBHXH).HasColumnName("idnvbhNhanVienBHXH");
            this.Property(t => t.NgayPhatSinh).HasColumnName("NgayPhatSinh");
            this.Property(t => t.TuThangNam).HasColumnName("TuThangNam");
            this.Property(t => t.DenThangNam).HasColumnName("DenThangNam");
            this.Property(t => t.ChucVuCongViec).HasColumnName("ChucVuCongViec");
            this.Property(t => t.TienLuongMDC).HasColumnName("TienLuongMDC");
            this.Property(t => t.TienLuongMDM).HasColumnName("TienLuongMDM");
            this.Property(t => t.PCChucVuMDC).HasColumnName("PCChucVuMDC");
            this.Property(t => t.PCThamNienVuotKhungMDC).HasColumnName("PCThamNienVuotKhungMDC");
            this.Property(t => t.PCThamNienNgheMDC).HasColumnName("PCThamNienNgheMDC");
            this.Property(t => t.PCKhacMDC).HasColumnName("PCKhacMDC");
            this.Property(t => t.PCChucVuMDM).HasColumnName("PCChucVuMDM");
            this.Property(t => t.PCThamNienVuotKhungMDM).HasColumnName("PCThamNienVuotKhungMDM");
            this.Property(t => t.PCThamNienNgheMDM).HasColumnName("PCThamNienNgheMDM");
            this.Property(t => t.PCKhacMDM).HasColumnName("PCKhacMDM");
            this.Property(t => t.TyLeDong).HasColumnName("TyLeDong");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.Tang).HasColumnName("Tang");
            this.Property(t => t.CVCu).HasColumnName("CVCu");
            this.Property(t => t.CVMoi).HasColumnName("CVMoi");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.DonVi_id).HasColumnName("DonVi_id");
            this.Property(t => t.TGBHTN).HasColumnName("TGBHTN");
            this.Property(t => t.TienLuong).HasColumnName("TienLuong");
            this.Property(t => t.HSL).HasColumnName("HSL");
            this.Property(t => t.MLTTV).HasColumnName("MLTTV");
            this.Property(t => t.MLTTC).HasColumnName("MLTTC");
            this.Property(t => t.TLBHXH).HasColumnName("TLBHXH");
            this.Property(t => t.TLBHTN).HasColumnName("TLBHTN");
            this.Property(t => t.TLBHYT).HasColumnName("TLBHYT");
            this.Property(t => t.QTID).HasColumnName("QTID");

            // Relationships
            this.HasRequired(t => t.dmLoaiDieuChinh)
                .WithMany(t => t.nvbhDanhSachDieuChinhTangGiams)
                .HasForeignKey(d => d.idLoaiDieuChinh);

        }
    }
}
