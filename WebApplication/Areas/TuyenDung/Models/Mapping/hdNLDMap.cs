using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases_TuyenDung.Models.Mapping
{
    public class hdNLDMap : EntityTypeConfiguration<hdNLD>
    {
        public hdNLDMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.NV_id)
                .HasMaxLength(50);

            this.Property(t => t.TD_id)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("hdNLD");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.TD_id).HasColumnName("TD_id");
            this.Property(t => t.hidden).HasColumnName("hidden");
        }
    }
}
