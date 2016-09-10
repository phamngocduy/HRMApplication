using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases_HDLaoDong.Models.Mapping
{
    public class tdQuaTrinhTuyenDungMap : EntityTypeConfiguration<tdQuaTrinhTuyenDung>
    {
        public tdQuaTrinhTuyenDungMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.HinhThucPhongVan)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("tdQuaTrinhTuyenDung");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.UngVien_id).HasColumnName("UngVien_id");
            this.Property(t => t.QuanLyLH_id).HasColumnName("QuanLyLH_id");
            this.Property(t => t.NgayPhongVanGiangThu).HasColumnName("NgayPhongVanGiangThu");
            this.Property(t => t.DonViPhongVan).HasColumnName("DonViPhongVan");
            this.Property(t => t.HinhThucPhongVan).HasColumnName("HinhThucPhongVan");
            this.Property(t => t.NhanXet).HasColumnName("NhanXet");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");

            // Relationships
            this.HasRequired(t => t.tdTTUngCuVien)
                .WithMany(t => t.tdQuaTrinhTuyenDungs)
                .HasForeignKey(d => d.UngVien_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.tdXemVaXepLichHen)
                .WithMany(t => t.tdQuaTrinhTuyenDungs)
                .HasForeignKey(d => d.QuanLyLH_id)
				.WillCascadeOnDelete(false);

        }
    }
}
