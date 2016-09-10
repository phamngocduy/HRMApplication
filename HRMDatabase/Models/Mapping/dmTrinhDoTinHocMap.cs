using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmTrinhDoTinHocMap : EntityTypeConfiguration<dmTrinhDoTinHoc>
    {
        public dmTrinhDoTinHocMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maTrinhDoTinHoc)
                .HasMaxLength(10);

            this.Property(t => t.tenTrinhDoTinHoc)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dmTrinhDoTinHoc");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maTrinhDoTinHoc).HasColumnName("maTrinhDoTinHoc");
            this.Property(t => t.tenTrinhDoTinHoc).HasColumnName("tenTrinhDoTinHoc");
        }
    }
}
