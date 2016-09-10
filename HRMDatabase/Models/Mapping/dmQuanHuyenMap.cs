using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmQuanHuyenMap : EntityTypeConfiguration<dmQuanHuyen>
    {
        public dmQuanHuyenMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maQuanHuyen)
                .HasMaxLength(10);

            this.Property(t => t.tenQuanHuyen)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dmQuanHuyen");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maQuanHuyen).HasColumnName("maQuanHuyen");
            this.Property(t => t.tenQuanHuyen).HasColumnName("tenQuanHuyen");
            this.Property(t => t.idTinhThanh).HasColumnName("idTinhThanh");

            // Relationships
            this.HasRequired(t => t.dmTinhThanh)
                .WithMany(t => t.dmQuanHuyens)
                .HasForeignKey(d => d.idTinhThanh)
				.WillCascadeOnDelete(false);

        }
    }
}
