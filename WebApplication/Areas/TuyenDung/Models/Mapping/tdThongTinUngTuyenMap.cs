using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases_TuyenDung.Models.Mapping
{
    public class tdThongTinUngTuyenMap : EntityTypeConfiguration<tdThongTinUngTuyen>
    {
        public tdThongTinUngTuyenMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.NguonTuyenDung)
                .HasMaxLength(150);

            this.Property(t => t.MucLuongYeuCau)
                .HasMaxLength(15);

            this.Property(t => t.ChucDanhTT)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("tdThongTinUngTuyen");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.UngVien_id).HasColumnName("UngVien_id");
            this.Property(t => t.ViTriUngTuyen_id).HasColumnName("ViTriUngTuyen_id");
            this.Property(t => t.DonViUngTuyen_id).HasColumnName("DonViUngTuyen_id");
            this.Property(t => t.NgayNhanHS).HasColumnName("NgayNhanHS");
            this.Property(t => t.NguonTuyenDung).HasColumnName("NguonTuyenDung");
            this.Property(t => t.KinhNghiemLamViec).HasColumnName("KinhNghiemLamViec");
            this.Property(t => t.MucLuongYeuCau).HasColumnName("MucLuongYeuCau");
            this.Property(t => t.NgayBatDauLamViec).HasColumnName("NgayBatDauLamViec");
            this.Property(t => t.MucLuongTT).HasColumnName("MucLuongTT");
            this.Property(t => t.NgayBatDauLamViecTT).HasColumnName("NgayBatDauLamViecTT");
            this.Property(t => t.SoNgayThuViec).HasColumnName("SoNgayThuViec");
            this.Property(t => t.ChucDanhTT).HasColumnName("ChucDanhTT");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");

            // Relationships
            this.HasRequired(t => t.tdTTUngCuVien)
                .WithMany(t => t.tdThongTinUngTuyens)
                .HasForeignKey(d => d.UngVien_id)
				.WillCascadeOnDelete(false);

        }
    }
}
