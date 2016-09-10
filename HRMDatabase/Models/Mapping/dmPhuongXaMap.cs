using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmPhuongXaMap : EntityTypeConfiguration<dmPhuongXa>
    {
        public dmPhuongXaMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maPhuongXa)
                .HasMaxLength(10);

            this.Property(t => t.tenPhuongXa)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dmPhuongXa");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maPhuongXa).HasColumnName("maPhuongXa");
            this.Property(t => t.tenPhuongXa).HasColumnName("tenPhuongXa");
            this.Property(t => t.idQuanHuyen).HasColumnName("idQuanHuyen");

            // Relationships
            this.HasRequired(t => t.dmQuanHuyen)
                .WithMany(t => t.dmPhuongXas)
                .HasForeignKey(d => d.idQuanHuyen)
				.WillCascadeOnDelete(false);

        }
    }
}
