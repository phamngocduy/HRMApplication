using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class nvTTKhenThuongMap : EntityTypeConfiguration<nvTTKhenThuong>
    {
        public nvTTKhenThuongMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.SoQuyetDinh)
                .HasMaxLength(20);

            this.Property(t => t.CapKhenThuong)
                .IsRequired();

            this.Property(t => t.NoiDungKhenThuong)
                .IsRequired();

            this.Property(t => t.MucKhenThuong)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("nvTTKhenThuong");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.NgayQuyetDinh).HasColumnName("NgayQuyetDinh");
            this.Property(t => t.SoQuyetDinh).HasColumnName("SoQuyetDinh");
            this.Property(t => t.HinhThuc_id).HasColumnName("HinhThuc_id");
            this.Property(t => t.CapKhenThuong).HasColumnName("CapKhenThuong");
            this.Property(t => t.NoiDungKhenThuong).HasColumnName("NoiDungKhenThuong");
            this.Property(t => t.MucKhenThuong).HasColumnName("MucKhenThuong");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");

            // Relationships
            this.HasOptional(t => t.dmHinhThucKhenThuong)
                .WithMany(t => t.nvTTKhenThuongs)
                .HasForeignKey(d => d.HinhThuc_id)
				.WillCascadeOnDelete(false);
            this.HasRequired(t => t.NhanVien)
                .WithMany(t => t.nvTTKhenThuongs)
                .HasForeignKey(d => d.NV_id)
				.WillCascadeOnDelete(false);

        }
    }
}
