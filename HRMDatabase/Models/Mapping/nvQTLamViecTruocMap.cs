using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class nvQTLamViecTruocMap : EntityTypeConfiguration<nvQTLamViecTruoc>
    {
        public nvQTLamViecTruocMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.DonViCongTac)
                .IsRequired();

            this.Property(t => t.ThoiGianBatDau)
                .HasMaxLength(50);

            this.Property(t => t.ThoiGianKetThuc)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("nvQTLamViecTruoc");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.DonViCongTac).HasColumnName("DonViCongTac");
            this.Property(t => t.ChucDanhChucVu).HasColumnName("ChucDanhChucVu");
            this.Property(t => t.ThoiGianBatDau).HasColumnName("ThoiGianBatDau");
            this.Property(t => t.ThoiGianKetThuc).HasColumnName("ThoiGianKetThuc");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");

            // Relationships
            this.HasRequired(t => t.NhanVien)
                .WithMany(t => t.nvQTLamViecTruocs)
                .HasForeignKey(d => d.NV_id)
				.WillCascadeOnDelete(false);

        }
    }
}
