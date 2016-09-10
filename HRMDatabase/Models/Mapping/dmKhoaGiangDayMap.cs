using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmKhoaGiangDayMap : EntityTypeConfiguration<dmKhoaGiangDay>
    {
        public dmKhoaGiangDayMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maKhoaGiangDay)
                .HasMaxLength(10);

            this.Property(t => t.tenKhoaGiangDay)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dmKhoaGiangDay");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maKhoaGiangDay).HasColumnName("maKhoaGiangDay");
            this.Property(t => t.tenKhoaGiangDay).HasColumnName("tenKhoaGiangDay");
        }
    }
}
