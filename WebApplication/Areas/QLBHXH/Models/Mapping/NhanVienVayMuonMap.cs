using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.QLBHXH.Models.Mapping
{
    public class NhanVienVayMuonMap : EntityTypeConfiguration<NhanVienVayMuon>
    {
        public NhanVienVayMuonMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.MaNV)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.HoVaTen)
                .HasMaxLength(100);

            this.Property(t => t.DonVi)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("NhanVienVayMuon");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.MaNV).HasColumnName("MaNV");
            this.Property(t => t.HoVaTen).HasColumnName("HoVaTen");
            this.Property(t => t.DonVi).HasColumnName("DonVi");
            this.Property(t => t.SoDuNoCuoiKy).HasColumnName("SoDuNoCuoiKy");
            this.Property(t => t.TongSoTienVay).HasColumnName("TongSoTienVay");
            this.Property(t => t.TongSoTienHoan).HasColumnName("TongSoTienHoan");
            this.Property(t => t.TongSoTienLai).HasColumnName("TongSoTienLai");
            this.Property(t => t.SoThangConLaiPhaiTra).HasColumnName("SoThangConLaiPhaiTra");
            this.Property(t => t.Hidden).HasColumnName("Hidden");
            this.Property(t => t.DonVi_id).HasColumnName("DonVi_id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.TrangThai).HasColumnName("TrangThai");
        }
    }
}
