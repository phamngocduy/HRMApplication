using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmTrinhDoNgoaiNguMap : EntityTypeConfiguration<dmTrinhDoNgoaiNgu>
    {
        public dmTrinhDoNgoaiNguMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maTrinhDoNgoaiNgu)
                .HasMaxLength(10);

            this.Property(t => t.tenTrinhDoNgoaiNgu)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dmTrinhDoNgoaiNgu");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maTrinhDoNgoaiNgu).HasColumnName("maTrinhDoNgoaiNgu");
            this.Property(t => t.tenTrinhDoNgoaiNgu).HasColumnName("tenTrinhDoNgoaiNgu");
        }
    }
}
