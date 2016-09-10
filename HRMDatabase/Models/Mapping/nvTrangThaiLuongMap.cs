using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class nvTrangThaiLuongMap : EntityTypeConfiguration<nvTrangThaiLuong>
    {
        public nvTrangThaiLuongMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("nvTrangThaiLuong");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.HocHam_id).HasColumnName("HocHam_id");
            this.Property(t => t.HocVi_id).HasColumnName("HocVi_id");
            this.Property(t => t.ChucDanh_id).HasColumnName("ChucDanh_id");
            this.Property(t => t.ChucDanhChucVu_id).HasColumnName("ChucDanhChucVu_id");
            this.Property(t => t.NgheNghiep_id).HasColumnName("NgheNghiep_id");

            // Relationships
            this.HasOptional(t => t.ChucDanh)
                .WithMany(t => t.nvTrangThaiLuongs)
                .HasForeignKey(d => d.ChucDanh_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.dmChucDanhChuyenMon)
                .WithMany(t => t.nvTrangThaiLuongs)
                .HasForeignKey(d => d.ChucDanhChucVu_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.HocHam)
                .WithMany(t => t.nvTrangThaiLuongs)
                .HasForeignKey(d => d.HocHam_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.HocVi)
                .WithMany(t => t.nvTrangThaiLuongs)
                .HasForeignKey(d => d.HocVi_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.NgheNghiep)
                .WithMany(t => t.nvTrangThaiLuongs)
                .HasForeignKey(d => d.NgheNghiep_id)
				.WillCascadeOnDelete(false);
            this.HasRequired(t => t.NhanVien)
                .WithMany(t => t.nvTrangThaiLuongs)
                .HasForeignKey(d => d.NV_id)
				.WillCascadeOnDelete(false);

        }
    }
}
