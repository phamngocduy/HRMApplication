using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmTrinhDoQuanLyMap : EntityTypeConfiguration<dmTrinhDoQuanLy>
    {
        public dmTrinhDoQuanLyMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maTrinhDoQuanLy)
                .HasMaxLength(10);

            this.Property(t => t.tenTrinhDoQuanLy)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dmTrinhDoQuanLy");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maTrinhDoQuanLy).HasColumnName("maTrinhDoQuanLy");
            this.Property(t => t.tenTrinhDoQuanLy).HasColumnName("tenTrinhDoQuanLy");
        }
    }
}
