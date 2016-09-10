using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class nvHeSoLuongMap : EntityTypeConfiguration<nvHeSoLuong>
    {
        public nvHeSoLuongMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.BacLuong)
                .HasMaxLength(4);

            this.Property(t => t.LyDoThayDoi)
                .HasMaxLength(50);

            this.Property(t => t.GhiChu)
                .HasMaxLength(50);

            this.Property(t => t.SoQuyetDinh)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("nvHeSoLuong");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.NgayBatDau).HasColumnName("NgayBatDau");
            this.Property(t => t.NgayKetThuc).HasColumnName("NgayKetThuc");
            this.Property(t => t.ThoiGianGiuBac).HasColumnName("ThoiGianGiuBac");
            this.Property(t => t.NhomNgach_id).HasColumnName("NhomNgach_id");
            this.Property(t => t.Ngach_id).HasColumnName("Ngach_id");
            this.Property(t => t.BacLuong).HasColumnName("BacLuong");
            this.Property(t => t.HeSoLuong).HasColumnName("HeSoLuong");
            this.Property(t => t.PhuCap).HasColumnName("PhuCap");
            this.Property(t => t.LyDoThayDoi).HasColumnName("LyDoThayDoi");
            this.Property(t => t.User_id).HasColumnName("User_id");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.SoQuyetDinh).HasColumnName("SoQuyetDinh");

            // Relationships
            this.HasOptional(t => t.NgachVC)
                .WithMany(t => t.nvHeSoLuongs)
                .HasForeignKey(d => d.Ngach_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.NhomNgach)
                .WithMany(t => t.nvHeSoLuongs)
                .HasForeignKey(d => d.NhomNgach_id)
				.WillCascadeOnDelete(false);
            this.HasRequired(t => t.NhanVien)
                .WithMany(t => t.nvHeSoLuongs)
                .HasForeignKey(d => d.NV_id)
				.WillCascadeOnDelete(false);

        }
    }
}
