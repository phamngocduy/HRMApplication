using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases_HDLaoDong.Models.Mapping
{
    public class tdHoKhauThuongTruMap : EntityTypeConfiguration<tdHoKhauThuongTru>
    {
        public tdHoKhauThuongTruMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tdHoKhauThuongTru");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.TTLienHe_id).HasColumnName("TTLienHe_id");
            this.Property(t => t.hkQuocGia_id).HasColumnName("hkQuocGia_id");
            this.Property(t => t.hkTinhThanh_id).HasColumnName("hkTinhThanh_id");
            this.Property(t => t.hkQuanHuyen_id).HasColumnName("hkQuanHuyen_id");
            this.Property(t => t.hkPhuongXa_id).HasColumnName("hkPhuongXa_id");
            this.Property(t => t.hkTenDuong).HasColumnName("hkTenDuong");

            // Relationships
            this.HasRequired(t => t.tdThongTinLienHe)
                .WithMany(t => t.tdHoKhauThuongTrus)
                .HasForeignKey(d => d.TTLienHe_id)
				.WillCascadeOnDelete(false);

        }
    }
}
