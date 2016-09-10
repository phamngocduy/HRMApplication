using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class hvBangCap1Map : EntityTypeConfiguration<hvBangCap1>
    {
        public hvBangCap1Map()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.NV_id, t.LoaiBangCap_id, t.ChuyenNganh_id, t.LoaiHinhDaoTao_id, t.ChuyenNganhChinh, t.NoiHoc_id, t.QuocGia_id, t.DanhHieuChinh, t.Xoa });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NV_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LoaiBangCap_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TenTruong)
                .HasMaxLength(50);

            this.Property(t => t.ChuyenNganh_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LoaiHinhDaoTao_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NoiHoc_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.QuocGia_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HoVaTen)
                .HasMaxLength(50);

            this.Property(t => t.maLoaiBangCap)
                .HasMaxLength(10);

            this.Property(t => t.tenLoaiBangCap)
                .HasMaxLength(50);

            this.Property(t => t.maTrinhDo)
                .HasMaxLength(50);

            this.Property(t => t.tenTrinhDo)
                .HasMaxLength(50);

            this.Property(t => t.maDanhHieu)
                .HasMaxLength(10);

            this.Property(t => t.tenDanhHieu)
                .HasMaxLength(50);

            this.Property(t => t.maHocVi)
                .HasMaxLength(10);

            this.Property(t => t.tenHocVi)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("hvBangCap1");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.LoaiBangCap_id).HasColumnName("LoaiBangCap_id");
            this.Property(t => t.DanhHieu_id).HasColumnName("DanhHieu_id");
            this.Property(t => t.TenTruong).HasColumnName("TenTruong");
            this.Property(t => t.ChuyenNganh_id).HasColumnName("ChuyenNganh_id");
            this.Property(t => t.ChuyenNganh).HasColumnName("ChuyenNganh");
            this.Property(t => t.LoaiHinhDaoTao_id).HasColumnName("LoaiHinhDaoTao_id");
            this.Property(t => t.NgayTN).HasColumnName("NgayTN");
            this.Property(t => t.XepLoaiTotNghiep_id).HasColumnName("XepLoaiTotNghiep_id");
            this.Property(t => t.ChuyenNganhChinh).HasColumnName("ChuyenNganhChinh");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.NoiHoc_id).HasColumnName("NoiHoc_id");
            this.Property(t => t.QuocGia_id).HasColumnName("QuocGia_id");
            this.Property(t => t.DanhHieuChinh).HasColumnName("DanhHieuChinh");
            this.Property(t => t.Xoa).HasColumnName("Xoa");
            this.Property(t => t.SauKhiVeTruong).HasColumnName("SauKhiVeTruong");
            this.Property(t => t.HoTro).HasColumnName("HoTro");
            this.Property(t => t.HoVaTen).HasColumnName("HoVaTen");
            this.Property(t => t.maLoaiBangCap).HasColumnName("maLoaiBangCap");
            this.Property(t => t.tenLoaiBangCap).HasColumnName("tenLoaiBangCap");
            this.Property(t => t.sttLoaiBangCap).HasColumnName("sttLoaiBangCap");
            this.Property(t => t.idTrinhDo).HasColumnName("idTrinhDo");
            this.Property(t => t.doUuTien).HasColumnName("doUuTien");
            this.Property(t => t.maTrinhDo).HasColumnName("maTrinhDo");
            this.Property(t => t.tenTrinhDo).HasColumnName("tenTrinhDo");
            this.Property(t => t.sttTrinhDo).HasColumnName("sttTrinhDo");
            this.Property(t => t.maDanhHieu).HasColumnName("maDanhHieu");
            this.Property(t => t.tenDanhHieu).HasColumnName("tenDanhHieu");
            this.Property(t => t.sttDanhHieu).HasColumnName("sttDanhHieu");
            this.Property(t => t.idHocVi).HasColumnName("idHocVi");
            this.Property(t => t.maHocVi).HasColumnName("maHocVi");
            this.Property(t => t.tenHocVi).HasColumnName("tenHocVi");
            this.Property(t => t.sttHocVi).HasColumnName("sttHocVi");
            this.Property(t => t.stt).HasColumnName("stt");
        }
    }
}
