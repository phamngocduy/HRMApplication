using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmThanhPhanGiaDinhMap : EntityTypeConfiguration<dmThanhPhanGiaDinh>
    {
        public dmThanhPhanGiaDinhMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maThanhPhanGiaDinh)
                .HasMaxLength(10);

            this.Property(t => t.tenThanhPhanGiaDinh)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dmThanhPhanGiaDinh");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maThanhPhanGiaDinh).HasColumnName("maThanhPhanGiaDinh");
            this.Property(t => t.tenThanhPhanGiaDinh).HasColumnName("tenThanhPhanGiaDinh");
        }
    }
}
