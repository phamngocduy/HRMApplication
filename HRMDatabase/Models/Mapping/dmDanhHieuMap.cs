using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmDanhHieuMap : EntityTypeConfiguration<dmDanhHieu>
    {
        public dmDanhHieuMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maDanhHieu)
                .HasMaxLength(10);

            this.Property(t => t.tenDanhHieu)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dmDanhHieu");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maDanhHieu).HasColumnName("maDanhHieu");
            this.Property(t => t.tenDanhHieu).HasColumnName("tenDanhHieu");
            this.Property(t => t.idHocVi).HasColumnName("idHocVi");

            // Relationships
            this.HasOptional(t => t.dmHocVi)
                .WithMany(t => t.dmDanhHieux)
                .HasForeignKey(d => d.idHocVi)
				.WillCascadeOnDelete(false);

        }
    }
}
