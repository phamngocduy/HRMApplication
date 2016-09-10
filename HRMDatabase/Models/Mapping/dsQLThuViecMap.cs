using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dsQLThuViecMap : EntityTypeConfiguration<dsQLThuViec>
    {
        public dsQLThuViecMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.HoVaTen, t.maThuViec, t.ThoiGianBatDau, t.SoNgayThuViec });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HoVaTen)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.maThuViec)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.SoNgayThuViec)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GhiChu)
                .HasMaxLength(150);

            this.Property(t => t.MaNV)
                .HasMaxLength(10);

            this.Property(t => t.maDonVi)
                .HasMaxLength(10);

            this.Property(t => t.tenDonVi)
                .HasMaxLength(100);

            this.Property(t => t.maChucDanh)
                .HasMaxLength(10);

            this.Property(t => t.tenChucDanh)
                .HasMaxLength(50);

            this.Property(t => t.maChucDanhChuyenMon)
                .HasMaxLength(10);

            this.Property(t => t.tenChucDanhChuyenMon)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dsQLThuViec");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.HoVaTen).HasColumnName("HoVaTen");
            this.Property(t => t.maThuViec).HasColumnName("maThuViec");
            this.Property(t => t.ThoiGianBatDau).HasColumnName("ThoiGianBatDau");
            this.Property(t => t.ThoiGianKetThuc).HasColumnName("ThoiGianKetThuc");
            this.Property(t => t.SoNgayThuViec).HasColumnName("SoNgayThuViec");
            this.Property(t => t.NgayNhanHoSo).HasColumnName("NgayNhanHoSo");
            this.Property(t => t.NgayLapToTrinh).HasColumnName("NgayLapToTrinh");
            this.Property(t => t.NgayThongBao).HasColumnName("NgayThongBao");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.DonVi_id).HasColumnName("DonVi_id");
            this.Property(t => t.ChucDanh_id).HasColumnName("ChucDanh_id");
            this.Property(t => t.ChucDanhChucVu_id).HasColumnName("ChucDanhChucVu_id");
            this.Property(t => t.MaNV).HasColumnName("MaNV");
            this.Property(t => t.ThoiGianDenHan).HasColumnName("ThoiGianDenHan");
            this.Property(t => t.SoNgayLamViec).HasColumnName("SoNgayLamViec");
            this.Property(t => t.maDonVi).HasColumnName("maDonVi");
            this.Property(t => t.tenDonVi).HasColumnName("tenDonVi");
            this.Property(t => t.sttDonVi).HasColumnName("sttDonVi");
            this.Property(t => t.maChucDanh).HasColumnName("maChucDanh");
            this.Property(t => t.tenChucDanh).HasColumnName("tenChucDanh");
            this.Property(t => t.sttChucDanh).HasColumnName("sttChucDanh");
            this.Property(t => t.maChucDanhChuyenMon).HasColumnName("maChucDanhChuyenMon");
            this.Property(t => t.tenChucDanhChuyenMon).HasColumnName("tenChucDanhChuyenMon");
            this.Property(t => t.sttChucDanhChuyenMon).HasColumnName("sttChucDanhChuyenMon");
        }
    }
}
