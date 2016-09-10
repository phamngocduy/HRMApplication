using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dsQLTapSuMap : EntityTypeConfiguration<dsQLTapSu>
    {
        public dsQLTapSuMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.CT_id });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CT_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HoVaTen)
                .HasMaxLength(50);

            this.Property(t => t.tenDonVi)
                .HasMaxLength(100);

            this.Property(t => t.maDonVi)
                .HasMaxLength(10);

            this.Property(t => t.tenChucDanhChuyenMon)
                .HasMaxLength(50);

            this.Property(t => t.maChucDanhChuyenMon)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("dsQLTapSu");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.CT_id).HasColumnName("CT_id");
            this.Property(t => t.ThoiGianDenHan).HasColumnName("ThoiGianDenHan");
            this.Property(t => t.NgayThongBao).HasColumnName("NgayThongBao");
            this.Property(t => t.NgayNhanHoSo).HasColumnName("NgayNhanHoSo");
            this.Property(t => t.NgayLapToTrinh).HasColumnName("NgayLapToTrinh");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.HoVaTen).HasColumnName("HoVaTen");
            this.Property(t => t.tenDonVi).HasColumnName("tenDonVi");
            this.Property(t => t.maDonVi).HasColumnName("maDonVi");
            this.Property(t => t.sttDonVi).HasColumnName("sttDonVi");
            this.Property(t => t.tenChucDanhChuyenMon).HasColumnName("tenChucDanhChuyenMon");
            this.Property(t => t.maChucDanhChuyenMon).HasColumnName("maChucDanhChuyenMon");
            this.Property(t => t.sttChucDanhChuyenMon).HasColumnName("sttChucDanhChuyenMon");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.ThoiGianBatDau).HasColumnName("ThoiGianBatDau");
            this.Property(t => t.ThoiGianKetThuc).HasColumnName("ThoiGianKetThuc");
            this.Property(t => t.NgayTuyenDung).HasColumnName("NgayTuyenDung");
        }
    }
}
