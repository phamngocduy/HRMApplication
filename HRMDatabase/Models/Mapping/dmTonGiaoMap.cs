using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmTonGiaoMap : EntityTypeConfiguration<dmTonGiao>
    {
        public dmTonGiaoMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maTonGiao)
                .HasMaxLength(10);

            this.Property(t => t.tenTonGiao)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dmTonGiao");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maTonGiao).HasColumnName("maTonGiao");
            this.Property(t => t.tenTonGiao).HasColumnName("tenTonGiao");
        }
    }
}
