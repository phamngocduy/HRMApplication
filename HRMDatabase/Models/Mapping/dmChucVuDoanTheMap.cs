using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmChucVuDoanTheMap : EntityTypeConfiguration<dmChucVuDoanThe>
    {
        public dmChucVuDoanTheMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maChucVuDoanThe)
                .HasMaxLength(10);

            this.Property(t => t.tenChucVuDoanThe)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dmChucVuDoanThe");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.idCongTacDoanThe).HasColumnName("idCongTacDoanThe");
            this.Property(t => t.maChucVuDoanThe).HasColumnName("maChucVuDoanThe");
            this.Property(t => t.tenChucVuDoanThe).HasColumnName("tenChucVuDoanThe");

            // Relationships
            this.HasRequired(t => t.dmCongTacDoanThe)
                .WithMany(t => t.dmChucVuDoanThes)
                .HasForeignKey(d => d.idCongTacDoanThe)
				.WillCascadeOnDelete(false);

        }
    }
}
