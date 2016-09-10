using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class nvDiaChiNhaMap : EntityTypeConfiguration<nvDiaChiNha>
    {
        public nvDiaChiNhaMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("nvDiaChiNha");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.DiaChi).HasColumnName("DiaChi");
            this.Property(t => t.PhuongXa_id).HasColumnName("PhuongXa_id");
            this.Property(t => t.QuanHuyen_id).HasColumnName("QuanHuyen_id");
            this.Property(t => t.TinhThanh_id).HasColumnName("TinhThanh_id");

            // Relationships
            this.HasOptional(t => t.dmPhuongXa)
                .WithMany(t => t.nvDiaChiNhas)
                .HasForeignKey(d => d.PhuongXa_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.dmQuanHuyen)
                .WithMany(t => t.nvDiaChiNhas)
                .HasForeignKey(d => d.QuanHuyen_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.dmTinhThanh)
                .WithMany(t => t.nvDiaChiNhas)
                .HasForeignKey(d => d.TinhThanh_id)
				.WillCascadeOnDelete(false);
            this.HasRequired(t => t.NhanVien)
                .WithMany(t => t.nvDiaChiNhas)
                .HasForeignKey(d => d.NV_id)
				.WillCascadeOnDelete(false);

        }
    }
}
