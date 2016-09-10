using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class nvGiuBacLuongMap : EntityTypeConfiguration<nvGiuBacLuong>
    {
        public nvGiuBacLuongMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.SoQuyetDinh)
                .HasMaxLength(50);

            this.Property(t => t.LyDoThayDoi)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("nvGiuBacLuong");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.HSL_id).HasColumnName("HSL_id");
            this.Property(t => t.SoThangThayDoi).HasColumnName("SoThangThayDoi");
            this.Property(t => t.SoQuyetDinh).HasColumnName("SoQuyetDinh");
            this.Property(t => t.LyDoThayDoi).HasColumnName("LyDoThayDoi");
            this.Property(t => t.LoaiThayDoi_id).HasColumnName("LoaiThayDoi_id");
            this.Property(t => t.NghiKL_id).HasColumnName("NghiKL_id");

            // Relationships
            this.HasRequired(t => t.LoaiBaoLuu)
                .WithMany(t => t.nvGiuBacLuongs)
                .HasForeignKey(d => d.LoaiThayDoi_id)
				.WillCascadeOnDelete(false);
            this.HasRequired(t => t.HeSoLuong)
                .WithMany(t => t.nvGiuBacLuongs)
                .HasForeignKey(d => d.HSL_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.nvQLNghiViec)
                .WithMany(t => t.nvGiuBacLuongs)
                .HasForeignKey(d => d.NghiKL_id)
				.WillCascadeOnDelete(false);

        }
    }
}
