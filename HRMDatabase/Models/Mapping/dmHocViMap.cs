using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmHocViMap : EntityTypeConfiguration<dmHocVi>
    {
        public dmHocViMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maHocVi)
                .HasMaxLength(10);

            this.Property(t => t.tenHocVi)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dmHocVi");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maHocVi).HasColumnName("maHocVi");
            this.Property(t => t.tenHocVi).HasColumnName("tenHocVi");
            this.Property(t => t.idTrinhDo).HasColumnName("idTrinhDo");

            // Relationships
            this.HasOptional(t => t.dmTrinhDo)
                .WithMany(t => t.dmHocVis)
                .HasForeignKey(d => d.idTrinhDo)
				.WillCascadeOnDelete(false);

        }
    }
}
