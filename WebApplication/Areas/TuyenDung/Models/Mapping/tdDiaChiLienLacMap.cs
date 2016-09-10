using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases_TuyenDung.Models.Mapping
{
    public class tdDiaChiLienLacMap : EntityTypeConfiguration<tdDiaChiLienLac>
    {
        public tdDiaChiLienLacMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tdDiaChiLienLac");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.TTLienHe_id).HasColumnName("TTLienHe_id");
            this.Property(t => t.llQuocGia_id).HasColumnName("llQuocGia_id");
            this.Property(t => t.llTinhThanh_id).HasColumnName("llTinhThanh_id");
            this.Property(t => t.llQuanHuyen_id).HasColumnName("llQuanHuyen_id");
            this.Property(t => t.llPhuongXa_id).HasColumnName("llPhuongXa_id");
            this.Property(t => t.llTenDuong).HasColumnName("llTenDuong");

            // Relationships
            this.HasRequired(t => t.tdThongTinLienHe)
                .WithMany(t => t.tdDiaChiLienLacs)
                .HasForeignKey(d => d.TTLienHe_id)
				.WillCascadeOnDelete(false);

        }
    }
}
