using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class nvQTChungChiMap : EntityTypeConfiguration<nvQTChungChi>
    {
        public nvQTChungChiMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.KinhPhiHoTro)
                .HasMaxLength(50);

            this.Property(t => t.HocPhi)
                .HasMaxLength(50);

            this.Property(t => t.ChiPhiKhac)
                .HasMaxLength(50);

            this.Property(t => t.GhiChu)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("nvQTChungChi");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.DonVi_id).HasColumnName("DonVi_id");
            this.Property(t => t.LoaiChungChi_id).HasColumnName("LoaiChungChi_id");
            this.Property(t => t.TenKhoaHoc).HasColumnName("TenKhoaHoc");
            this.Property(t => t.TenTruong).HasColumnName("TenTruong");
            this.Property(t => t.NoiHoc_id).HasColumnName("NoiHoc_id");
            this.Property(t => t.QuocGia_id).HasColumnName("QuocGia_id");
            this.Property(t => t.ThoiGianBatDau).HasColumnName("ThoiGianBatDau");
            this.Property(t => t.ThoiGianKetThucDuKien).HasColumnName("ThoiGianKetThucDuKien");
            this.Property(t => t.ThoiGianKetThucChinhThuc).HasColumnName("ThoiGianKetThucChinhThuc");
            this.Property(t => t.KetQua).HasColumnName("KetQua");
            this.Property(t => t.SoQuyetDinh).HasColumnName("SoQuyetDinh");
            this.Property(t => t.NgayCapQD).HasColumnName("NgayCapQD");
            this.Property(t => t.KinhPhiHoTro).HasColumnName("KinhPhiHoTro");
            this.Property(t => t.HocPhi).HasColumnName("HocPhi");
            this.Property(t => t.ChiPhiKhac).HasColumnName("ChiPhiKhac");
            this.Property(t => t.HienTrang_id).HasColumnName("HienTrang_id");
            this.Property(t => t.CheDo_id).HasColumnName("CheDo_id");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.Xoa).HasColumnName("Xoa");

            // Relationships
            this.HasOptional(t => t.dmCheDoHoc)
                .WithMany(t => t.nvQTChungChis)
                .HasForeignKey(d => d.CheDo_id)
				.WillCascadeOnDelete(false);
            this.HasRequired(t => t.dmDonVi)
                .WithMany(t => t.nvQTChungChis)
                .HasForeignKey(d => d.DonVi_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.dmHienTrangDiHoc)
                .WithMany(t => t.nvQTChungChis)
                .HasForeignKey(d => d.HienTrang_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.dmLoaiChungChi)
                .WithMany(t => t.nvQTChungChis)
                .HasForeignKey(d => d.LoaiChungChi_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.dmNoiHoc)
                .WithMany(t => t.nvQTChungChis)
                .HasForeignKey(d => d.NoiHoc_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.dmQuocGia)
                .WithMany(t => t.nvQTChungChis)
                .HasForeignKey(d => d.QuocGia_id)
				.WillCascadeOnDelete(false);
            this.HasOptional(t => t.NhanVien)
                .WithMany(t => t.nvQTChungChis)
                .HasForeignKey(d => d.NV_id)
				.WillCascadeOnDelete(false);

        }
    }
}
