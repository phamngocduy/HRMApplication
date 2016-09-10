using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class nvQLThuViecMap : EntityTypeConfiguration<nvQLThuViec>
    {
        public nvQLThuViecMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.HoVaTen)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.maThuViec)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.GhiChu)
                .HasMaxLength(150);

            this.Property(t => t.MaNV)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("nvQLThuViec");
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

            // Relationships
            this.HasOptional(t => t.ChucDanh)
                .WithMany(t => t.nvQLThuViecs)
                .HasForeignKey(d => d.ChucDanh_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.ChucDanhChuyenMon)
                .WithMany(t => t.nvQLThuViecs)
                .HasForeignKey(d => d.ChucDanhChucVu_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.DonVi)
                .WithMany(t => t.nvQLThuViecs)
                .HasForeignKey(d => d.DonVi_id)
				.WillCascadeOnDelete(false);

        }
    }
}
