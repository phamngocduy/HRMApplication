using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmTrinhDoChinhTriMap : EntityTypeConfiguration<dmTrinhDoChinhTri>
    {
        public dmTrinhDoChinhTriMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maTrinhDoChinhTri)
                .HasMaxLength(10);

            this.Property(t => t.tenTrinhDoChinhTri)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dmTrinhDoChinhTri");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maTrinhDoChinhTri).HasColumnName("maTrinhDoChinhTri");
            this.Property(t => t.tenTrinhDoChinhTri).HasColumnName("tenTrinhDoChinhTri");
        }
    }
}
