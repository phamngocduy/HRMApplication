using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class nvTTKyLuatTruocMap : EntityTypeConfiguration<nvTTKyLuatTruoc>
    {
        public nvTTKyLuatTruocMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.SoQuyetDinh)
                .HasMaxLength(20);

            this.Property(t => t.CapQuyetDinh)
                .HasMaxLength(50);

            this.Property(t => t.NoiCapQuyetDinh)
                .HasMaxLength(100);

            this.Property(t => t.LyDoKyLuat)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("nvTTKyLuatTruoc");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.SoQuyetDinh).HasColumnName("SoQuyetDinh");
            this.Property(t => t.NgayQuyetDinh).HasColumnName("NgayQuyetDinh");
            this.Property(t => t.CapQuyetDinh).HasColumnName("CapQuyetDinh");
            this.Property(t => t.NoiCapQuyetDinh).HasColumnName("NoiCapQuyetDinh");
            this.Property(t => t.LyDoKyLuat).HasColumnName("LyDoKyLuat");
            this.Property(t => t.TrangThai).HasColumnName("TrangThai");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");

            // Relationships
            this.HasRequired(t => t.NhanVien)
                .WithMany(t => t.nvTTKyLuatTruocs)
                .HasForeignKey(d => d.NV_id)
				.WillCascadeOnDelete(false);

        }
    }
}
