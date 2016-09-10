using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class adHeSoLuongMap : EntityTypeConfiguration<adHeSoLuong>
    {
        public adHeSoLuongMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ThoiGianGiuBac, t.HeSoLuong, t.PhuCap, t.id });

            // Properties
            this.Property(t => t.ThoiGianGiuBac)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BacLuong)
                .HasMaxLength(4);

            this.Property(t => t.PhuCap)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("adHeSoLuong");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.NgayBatDau).HasColumnName("NgayBatDau");
            this.Property(t => t.ThoiGianGiuBac).HasColumnName("ThoiGianGiuBac");
            this.Property(t => t.NhomNgach_id).HasColumnName("NhomNgach_id");
            this.Property(t => t.Ngach_id).HasColumnName("Ngach_id");
            this.Property(t => t.BacLuong).HasColumnName("BacLuong");
            this.Property(t => t.HeSoLuong).HasColumnName("HeSoLuong");
            this.Property(t => t.PhuCap).HasColumnName("PhuCap");
            this.Property(t => t.id).HasColumnName("id");
        }
    }
}
