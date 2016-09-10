using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class nvTTKhenThuongTruocMap : EntityTypeConfiguration<nvTTKhenThuongTruoc>
    {
        public nvTTKhenThuongTruocMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.ThangNamKhenThuong)
                .HasMaxLength(50);

            this.Property(t => t.NoiDungKhenThuong)
                .IsRequired();

            this.Property(t => t.NoiCapQuyetDinh)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("nvTTKhenThuongTruoc");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.ThangNamKhenThuong).HasColumnName("ThangNamKhenThuong");
            this.Property(t => t.NoiDungKhenThuong).HasColumnName("NoiDungKhenThuong");
            this.Property(t => t.NoiCapQuyetDinh).HasColumnName("NoiCapQuyetDinh");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");

            // Relationships
            this.HasRequired(t => t.NhanVien)
                .WithMany(t => t.nvTTKhenThuongTruocs)
                .HasForeignKey(d => d.NV_id)
				.WillCascadeOnDelete(false);

        }
    }
}
