using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmNganhGiangDayMap : EntityTypeConfiguration<dmNganhGiangDay>
    {
        public dmNganhGiangDayMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maNganhGiangDay)
                .HasMaxLength(10);

            this.Property(t => t.tenNganhGiangDay)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dmNganhGiangDay");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maNganhGiangDay).HasColumnName("maNganhGiangDay");
            this.Property(t => t.tenNganhGiangDay).HasColumnName("tenNganhGiangDay");
        }
    }
}
