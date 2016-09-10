using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmTrinhDoMap : EntityTypeConfiguration<dmTrinhDo>
    {
        public dmTrinhDoMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maTrinhDo)
                .HasMaxLength(50);

            this.Property(t => t.tenTrinhDo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dmTrinhDo");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maTrinhDo).HasColumnName("maTrinhDo");
            this.Property(t => t.tenTrinhDo).HasColumnName("tenTrinhDo");
            this.Property(t => t.doUuTien).HasColumnName("doUuTien");
        }
    }
}
