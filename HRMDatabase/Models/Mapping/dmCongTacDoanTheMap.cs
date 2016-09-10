using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmCongTacDoanTheMap : EntityTypeConfiguration<dmCongTacDoanThe>
    {
        public dmCongTacDoanTheMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maCongTacDoanThe)
                .HasMaxLength(10);

            this.Property(t => t.tenCongTacDoanThe)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dmCongTacDoanThe");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maCongTacDoanThe).HasColumnName("maCongTacDoanThe");
            this.Property(t => t.tenCongTacDoanThe).HasColumnName("tenCongTacDoanThe");
        }
    }
}
