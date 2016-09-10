using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmHocHamMap : EntityTypeConfiguration<dmHocHam>
    {
        public dmHocHamMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maHocHam)
                .HasMaxLength(10);

            this.Property(t => t.tenHocHam)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dmHocHam");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maHocHam).HasColumnName("maHocHam");
            this.Property(t => t.tenHocHam).HasColumnName("tenHocHam");
            this.Property(t => t.doUuTien).HasColumnName("doUuTien");
        }
    }
}
