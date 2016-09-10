using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases_HDLaoDong.Models.Mapping
{
    public class tdThongTinLienHeMap : EntityTypeConfiguration<tdThongTinLienHe>
    {
        public tdThongTinLienHeMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.DTDiDong1)
                .HasMaxLength(15);

            this.Property(t => t.DTDiDong2)
                .HasMaxLength(15);

            this.Property(t => t.DTNha)
                .HasMaxLength(15);

            this.Property(t => t.Email)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tdThongTinLienHe");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.UngVien_id).HasColumnName("UngVien_id");
            this.Property(t => t.DTDiDong1).HasColumnName("DTDiDong1");
            this.Property(t => t.DTDiDong2).HasColumnName("DTDiDong2");
            this.Property(t => t.DTNha).HasColumnName("DTNha");
            this.Property(t => t.Email).HasColumnName("Email");

            // Relationships
            this.HasRequired(t => t.tdTTUngCuVien)
                .WithMany(t => t.tdThongTinLienHes)
                .HasForeignKey(d => d.UngVien_id)
				.WillCascadeOnDelete(false);

        }
    }
}
