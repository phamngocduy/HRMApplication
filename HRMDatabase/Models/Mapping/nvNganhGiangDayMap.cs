using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class nvNganhGiangDayMap : EntityTypeConfiguration<nvNganhGiangDay>
    {
        public nvNganhGiangDayMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("nvNganhGiangDay");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.NganhGiangDay).HasColumnName("NganhGiangDay");
            this.Property(t => t.ThoiGianBatDau).HasColumnName("ThoiGianBatDau");
            this.Property(t => t.ThoiGianKetThuc).HasColumnName("ThoiGianKetThuc");
            this.Property(t => t.KhoaGiangDay).HasColumnName("KhoaGiangDay");

            // Relationships
            this.HasRequired(t => t.dmDonVi)
                .WithMany(t => t.nvNganhGiangDays)
                .HasForeignKey(d => d.KhoaGiangDay)
				.WillCascadeOnDelete(false);
            this.HasRequired(t => t.dmNganhGiangDay)
                .WithMany(t => t.nvNganhGiangDays)
                .HasForeignKey(d => d.NganhGiangDay)
				.WillCascadeOnDelete(false);
            this.HasRequired(t => t.NhanVien)
                .WithMany(t => t.nvNganhGiangDays)
                .HasForeignKey(d => d.NV_id)
				.WillCascadeOnDelete(false);

        }
    }
}
