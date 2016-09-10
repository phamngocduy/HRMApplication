using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmTrinhDoHocVanMap : EntityTypeConfiguration<dmTrinhDoHocVan>
    {
        public dmTrinhDoHocVanMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maTrinhDoHocVan)
                .HasMaxLength(10);

            this.Property(t => t.tenTrinhDoHocVan)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dmTrinhDoHocVan");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maTrinhDoHocVan).HasColumnName("maTrinhDoHocVan");
            this.Property(t => t.tenTrinhDoHocVan).HasColumnName("tenTrinhDoHocVan");
        }
    }
}
