using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.QLBHXH.Models.Mapping
{
    public class nvbhDanhSachDieuChinhChucDanhMap : EntityTypeConfiguration<nvbhDanhSachDieuChinhChucDanh>
    {
        public nvbhDanhSachDieuChinhChucDanhMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.ChucVuCu)
                .HasMaxLength(200);

            this.Property(t => t.ChucVuMoi)
                .HasMaxLength(200);

            this.Property(t => t.GhiChu)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("nvbhDanhSachDieuChinhChucDanh");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.idLoaiDieuChinh).HasColumnName("idLoaiDieuChinh");
            this.Property(t => t.idnvbhNhanVienBHXH).HasColumnName("idnvbhNhanVienBHXH");
            this.Property(t => t.NgayPhatSinh).HasColumnName("NgayPhatSinh");
            this.Property(t => t.ChucVuCu).HasColumnName("ChucVuCu");
            this.Property(t => t.ChucVuMoi).HasColumnName("ChucVuMoi");
            this.Property(t => t.TuThangNam).HasColumnName("TuThangNam");
            this.Property(t => t.DenThangNam).HasColumnName("DenThangNam");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");

            // Relationships
            this.HasOptional(t => t.dmLoaiDieuChinh)
                .WithMany(t => t.nvbhDanhSachDieuChinhChucDanhs)
                .HasForeignKey(d => d.idLoaiDieuChinh)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.nvbhNhanVienBHXH)
                .WithMany(t => t.nvbhDanhSachDieuChinhChucDanhs)
                .HasForeignKey(d => d.idnvbhNhanVienBHXH)
				.WillCascadeOnDelete(false);

        }
    }
}
