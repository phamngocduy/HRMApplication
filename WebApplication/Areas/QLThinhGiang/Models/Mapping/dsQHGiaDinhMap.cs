using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.QLThinhGiang.Models.Mapping
{
    public class dsQHGiaDinhMap : EntityTypeConfiguration<dsQHGiaDinh>
    {
        public dsQHGiaDinhMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.NV_id, t.HoTen, t.QuanHe_id });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NV_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HoTen)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.QuanHe_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DiaChi)
                .HasMaxLength(100);

            this.Property(t => t.MaSoThue)
                .HasMaxLength(20);

            this.Property(t => t.tenMoiQuanHe)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("dsQHGiaDinh");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.HoTen).HasColumnName("HoTen");
            this.Property(t => t.NgaySinh).HasColumnName("NgaySinh");
            this.Property(t => t.QuanHe_id).HasColumnName("QuanHe_id");
            this.Property(t => t.DiaChi).HasColumnName("DiaChi");
            this.Property(t => t.NgheNghiep).HasColumnName("NgheNghiep");
            this.Property(t => t.MaSoThue).HasColumnName("MaSoThue");
            this.Property(t => t.CoQuan).HasColumnName("CoQuan");
            this.Property(t => t.tenMoiQuanHe).HasColumnName("tenMoiQuanHe");
        }
    }
}
