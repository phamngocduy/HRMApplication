using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.QLBHXH.Models.Mapping
{
    public class dmGiayToMap : EntityTypeConfiguration<dmGiayTo>
    {
        public dmGiayToMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.MaGiayTo)
                .HasMaxLength(10);

            this.Property(t => t.TenGiayTo)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("dmGiayTo");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.idMucDichSuDung).HasColumnName("idMucDichSuDung");
            this.Property(t => t.MaGiayTo).HasColumnName("MaGiayTo");
            this.Property(t => t.TenGiayTo).HasColumnName("TenGiayTo");
            this.Property(t => t.stt).HasColumnName("stt");

            // Relationships
            this.HasOptional(t => t.MucDichSuDung)
                .WithMany(t => t.dmGiayToes)
                .HasForeignKey(d => d.idMucDichSuDung)
				.WillCascadeOnDelete(false);

        }
    }
}
