using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class nvCTDoanTheMap : EntityTypeConfiguration<nvCTDoanThe>
    {
        public nvCTDoanTheMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.NoiKetNap)
                .HasMaxLength(100);

            this.Property(t => t.ChiBo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("nvCTDoanThe");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.NgayVaoDuBi).HasColumnName("NgayVaoDuBi");
            this.Property(t => t.NgayVaoChinhThuc).HasColumnName("NgayVaoChinhThuc");
            this.Property(t => t.NoiKetNap).HasColumnName("NoiKetNap");
            this.Property(t => t.ChiBo).HasColumnName("ChiBo");
            this.Property(t => t.NgayBatDau).HasColumnName("NgayBatDau");
            this.Property(t => t.NgayKetThuc).HasColumnName("NgayKetThuc");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.ChucVu_id).HasColumnName("ChucVu_id");
            this.Property(t => t.DonVi).HasColumnName("DonVi");

            // Relationships
            this.HasRequired(t => t.dmChucVuDoanThe)
                .WithMany(t => t.nvCTDoanThes)
                .HasForeignKey(d => d.ChucVu_id)
				.WillCascadeOnDelete(false);
            this.HasRequired(t => t.NhanVien)
                .WithMany(t => t.nvCTDoanThes)
                .HasForeignKey(d => d.NV_id)
				.WillCascadeOnDelete(false);

        }
    }
}
