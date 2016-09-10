using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class nvTTThongKeMap : EntityTypeConfiguration<nvTTThongKe>
    {
        public nvTTThongKeMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("nvTTThongKe");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.PhanLoaiCBGVNV).HasColumnName("PhanLoaiCBGVNV");
            this.Property(t => t.KhoaGiangDayChinh).HasColumnName("KhoaGiangDayChinh");
            this.Property(t => t.NganhGiangDayChinh).HasColumnName("NganhGiangDayChinh");

            // Relationships
            this.HasOptional(t => t.dmKhoaGiangDay)
                .WithMany(t => t.nvTTThongKes)
                .HasForeignKey(d => d.KhoaGiangDayChinh)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.dmNganhGiangDay)
                .WithMany(t => t.nvTTThongKes)
                .HasForeignKey(d => d.NganhGiangDayChinh)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.dmPhanLoaiCBGVNV)
                .WithMany(t => t.nvTTThongKes)
                .HasForeignKey(d => d.PhanLoaiCBGVNV)
				.WillCascadeOnDelete(false);
            this.HasRequired(t => t.NhanVien)
                .WithMany(t => t.nvTTThongKes)
                .HasForeignKey(d => d.NV_id)
				.WillCascadeOnDelete(false);

        }
    }
}
