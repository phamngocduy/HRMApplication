using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dsGiuBacLuongMap : EntityTypeConfiguration<dsGiuBacLuong>
    {
        public dsGiuBacLuongMap()
        {
            // Primary Key
            this.HasKey(t => t.HSL_id);

            // Properties
            this.Property(t => t.HSL_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("dsGiuBacLuong");
            this.Property(t => t.HSL_id).HasColumnName("HSL_id");
            this.Property(t => t.SoThangThayDoi).HasColumnName("SoThangThayDoi");
        }
    }
}
