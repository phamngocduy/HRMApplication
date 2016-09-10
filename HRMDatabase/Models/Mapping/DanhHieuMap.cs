using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class DanhHieuMap : EntityTypeConfiguration<DanhHieu>
    {
        public DanhHieuMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.SoQDCongNhan)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.NoiCap)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.GhiChu)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DanhHieu");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.TenDanhHieu_id).HasColumnName("TenDanhHieu_id");
            this.Property(t => t.NgayDatDanhHieu).HasColumnName("NgayDatDanhHieu");
            this.Property(t => t.SoQDCongNhan).HasColumnName("SoQDCongNhan");
            this.Property(t => t.NoiCap).HasColumnName("NoiCap");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");

            // Relationships
            this.HasRequired(t => t.dmDanhHieu)
                .WithMany(t => t.DanhHieux)
                .HasForeignKey(d => d.TenDanhHieu_id)
				.WillCascadeOnDelete(false);
            this.HasRequired(t => t.NhanVien)
                .WithMany(t => t.DanhHieux)
                .HasForeignKey(d => d.NV_id)
				.WillCascadeOnDelete(false);

        }
    }
}
