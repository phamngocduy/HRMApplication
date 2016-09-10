using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmNoiHocMap : EntityTypeConfiguration<dmNoiHoc>
    {
        public dmNoiHocMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maNoiHoc)
                .HasMaxLength(20);

            this.Property(t => t.tenNoiHoc)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("dmNoiHoc");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maNoiHoc).HasColumnName("maNoiHoc");
            this.Property(t => t.tenNoiHoc).HasColumnName("tenNoiHoc");
        }
    }
}
