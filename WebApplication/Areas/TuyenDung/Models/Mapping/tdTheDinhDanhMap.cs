using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases_TuyenDung.Models.Mapping
{
    public class tdTheDinhDanhMap : EntityTypeConfiguration<tdTheDinhDanh>
    {
        public tdTheDinhDanhMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.SoThe)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("tdTheDinhDanh");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.UngVien_id).HasColumnName("UngVien_id");
            this.Property(t => t.LoaiThe_id).HasColumnName("LoaiThe_id");
            this.Property(t => t.SoThe).HasColumnName("SoThe");
            this.Property(t => t.NgayCap).HasColumnName("NgayCap");
            this.Property(t => t.NoiCap_id).HasColumnName("NoiCap_id");
            this.Property(t => t.NgayHetHan).HasColumnName("NgayHetHan");

            // Relationships
            this.HasRequired(t => t.tdLoaiTheDinhDanh)
                .WithMany(t => t.tdTheDinhDanhs)
                .HasForeignKey(d => d.LoaiThe_id)
				.WillCascadeOnDelete(false);
            this.HasRequired(t => t.tdTTUngCuVien)
                .WithMany(t => t.tdTheDinhDanhs)
                .HasForeignKey(d => d.UngVien_id)
				.WillCascadeOnDelete(false);

        }
    }
}
