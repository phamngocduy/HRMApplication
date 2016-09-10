using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class nvQHGiaDinhMap : EntityTypeConfiguration<nvQHGiaDinh>
    {
        public nvQHGiaDinhMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.HoTen)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DiaChi)
                .HasMaxLength(100);

            this.Property(t => t.MaSoThue)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("nvQHGiaDinh");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.HoTen).HasColumnName("HoTen");
            this.Property(t => t.NgaySinh).HasColumnName("NgaySinh");
            this.Property(t => t.QuanHe_id).HasColumnName("QuanHe_id");
            this.Property(t => t.DiaChi).HasColumnName("DiaChi");
            this.Property(t => t.NgheNghiep).HasColumnName("NgheNghiep");
            this.Property(t => t.MaSoThue).HasColumnName("MaSoThue");
            this.Property(t => t.CoQuan).HasColumnName("CoQuan");

            // Relationships
            this.HasRequired(t => t.dmMoiQuanHe)
                .WithMany(t => t.nvQHGiaDinhs)
                .HasForeignKey(d => d.QuanHe_id)
				.WillCascadeOnDelete(false);
            this.HasRequired(t => t.NhanVien)
                .WithMany(t => t.nvQHGiaDinhs)
                .HasForeignKey(d => d.NV_id)
				.WillCascadeOnDelete(false);

        }
    }
}
