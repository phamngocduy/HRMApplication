using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmDonViMap : EntityTypeConfiguration<dmDonVi>
    {
        public dmDonViMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maDonVi)
                .HasMaxLength(10);

            this.Property(t => t.tenDonVi)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Khoa_BoMon)
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("dmDonVi");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.maDonVi).HasColumnName("maDonVi");
            this.Property(t => t.tenDonVi).HasColumnName("tenDonVi");
            this.Property(t => t.idDonViChuQuan).HasColumnName("idDonViChuQuan");
            this.Property(t => t.Khoa_BoMon).HasColumnName("Khoa_BoMon");
            this.Property(t => t.stt).HasColumnName("stt");

            // Relationships
            this.HasOptional(t => t.DonViChuQuan)
                .WithMany(t => t.dmDonVi1)
                .HasForeignKey(d => d.idDonViChuQuan)
				.WillCascadeOnDelete(false);

        }
    }
}
