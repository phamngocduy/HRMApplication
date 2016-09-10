using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmQuyetDinhMap : EntityTypeConfiguration<dmQuyetDinh>
    {
        public dmQuyetDinhMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.MaQuyetDinh)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("dmQuyetDinh");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.LoaiQuyetDinh_id).HasColumnName("LoaiQuyetDinh_id");
            this.Property(t => t.MaQuyetDinh).HasColumnName("MaQuyetDinh");
            this.Property(t => t.NgayKy).HasColumnName("NgayKy");
            this.Property(t => t.NgayApDung).HasColumnName("NgayApDung");
            this.Property(t => t.NgayKetThuc).HasColumnName("NgayKetThuc");
            this.Property(t => t.NoiDung).HasColumnName("NoiDung");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.TepDinhKem).HasColumnName("TepDinhKem");

            // Relationships
            this.HasRequired(t => t.dmLoaiQuyetDinh)
                .WithMany(t => t.dmQuyetDinhs)
                .HasForeignKey(d => d.LoaiQuyetDinh_id)
				.WillCascadeOnDelete(false);

        }
    }
}
