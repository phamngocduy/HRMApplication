using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class nvQTLamViecMap : EntityTypeConfiguration<nvQTLamViec>
    {
        public nvQTLamViecMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.SoQuyetDinh)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("nvQTLamViec");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.ThoiGianBatDau).HasColumnName("ThoiGianBatDau");
            this.Property(t => t.ThoiGianKetThuc).HasColumnName("ThoiGianKetThuc");
            this.Property(t => t.DonVi_id).HasColumnName("DonVi_id");
            this.Property(t => t.ChucDanh_id).HasColumnName("ChucDanh_id");
            this.Property(t => t.ChucDanhChucVu_id).HasColumnName("ChucDanhChucVu_id");
            this.Property(t => t.NgheNghiep_id).HasColumnName("NgheNghiep_id");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.SoQuyetDinh).HasColumnName("SoQuyetDinh");
            this.Property(t => t.ChucVu_id).HasColumnName("ChucVu_id");

            // Relationships
            this.HasOptional(t => t.ChucDanh)
                .WithMany(t => t.nvQTLamViecs)
                .HasForeignKey(d => d.ChucDanh_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.ChucDanhChuyenMon)
                .WithMany(t => t.nvQTLamViecs)
                .HasForeignKey(d => d.ChucDanhChucVu_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.dmChucVu)
                .WithMany(t => t.nvQTLamViecs)
                .HasForeignKey(d => d.ChucVu_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.DonVi)
                .WithMany(t => t.nvQTLamViecs)
                .HasForeignKey(d => d.DonVi_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.NgheNghiep)
                .WithMany(t => t.nvQTLamViecs)
                .HasForeignKey(d => d.NgheNghiep_id)
				.WillCascadeOnDelete(false);
            this.HasRequired(t => t.NhanVien)
                .WithMany(t => t.nvQTLamViecs)
                .HasForeignKey(d => d.NV_id)
				.WillCascadeOnDelete(false);

        }
    }
}
