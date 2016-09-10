using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dsHocHamMap : EntityTypeConfiguration<dsHocHam>
    {
        public dsHocHamMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.NV_id, t.HocHam_id, t.NgayBatDau });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NV_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HocHam_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HoVaTen)
                .HasMaxLength(50);

            this.Property(t => t.maHocHam)
                .HasMaxLength(10);

            this.Property(t => t.tenHocHam)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dsHocHam");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.HocHam_id).HasColumnName("HocHam_id");
            this.Property(t => t.NgayBatDau).HasColumnName("NgayBatDau");
            this.Property(t => t.HoVaTen).HasColumnName("HoVaTen");
            this.Property(t => t.maHocHam).HasColumnName("maHocHam");
            this.Property(t => t.tenHocHam).HasColumnName("tenHocHam");
            this.Property(t => t.doUuTien).HasColumnName("doUuTien");
            this.Property(t => t.sttHocHam).HasColumnName("sttHocHam");
        }
    }
}
