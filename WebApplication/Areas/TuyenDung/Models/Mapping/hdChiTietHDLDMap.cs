using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases_TuyenDung.Models.Mapping
{
    public class hdChiTietHDLDMap : EntityTypeConfiguration<hdChiTietHDLD>
    {
        public hdChiTietHDLDMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.HotenNLD)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.soCMND)
                .IsFixedLength()
                .HasMaxLength(15);

            this.Property(t => t.ChucvutruongDV)
                .HasMaxLength(100);

            this.Property(t => t.SoHD)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.LoaiHD)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Mucluongchinh)
                .HasMaxLength(15);

            this.Property(t => t.HSLuong)
                .HasMaxLength(50);

            this.Property(t => t.Bac)
                .HasMaxLength(50);

            this.Property(t => t.Ngach)
                .HasMaxLength(50);

            this.Property(t => t.Nhom)
                .HasMaxLength(50);

            this.Property(t => t.MaNhom)
                .HasMaxLength(50);

            this.Property(t => t.QT_NLDky)
                .HasMaxLength(1);

            this.Property(t => t.QT_TrinhHT)
                .HasMaxLength(1);

            this.Property(t => t.QT_HTky)
                .HasMaxLength(1);

            this.Property(t => t.QT_LuuHS)
                .HasMaxLength(1);

            this.Property(t => t.QT_TraNLD)
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("hdChiTietHDLD");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NLD_id).HasColumnName("NLD_id");
            this.Property(t => t.HotenNLD).HasColumnName("HotenNLD");
            this.Property(t => t.Gioitinh_id).HasColumnName("Gioitinh_id");
            this.Property(t => t.Quoctich_id).HasColumnName("Quoctich_id");
            this.Property(t => t.Ngaysinh).HasColumnName("Ngaysinh");
            this.Property(t => t.Noisinh).HasColumnName("Noisinh");
            this.Property(t => t.Nghenghiep_id).HasColumnName("Nghenghiep_id");
            this.Property(t => t.NgheNghiep).HasColumnName("NgheNghiep");
            this.Property(t => t.Diachithuongtru).HasColumnName("Diachithuongtru");
            this.Property(t => t.soCMND).HasColumnName("soCMND");
            this.Property(t => t.cmndNgaycap).HasColumnName("cmndNgaycap");
            this.Property(t => t.cmndNoicap).HasColumnName("cmndNoicap");
            this.Property(t => t.Donvi_id).HasColumnName("Donvi_id");
            this.Property(t => t.DonVi).HasColumnName("DonVi");
            this.Property(t => t.ChucvutruongDV).HasColumnName("ChucvutruongDV");
            this.Property(t => t.Chucdanh_id).HasColumnName("Chucdanh_id");
            this.Property(t => t.ChucDanh).HasColumnName("ChucDanh");
            this.Property(t => t.Chucvu_id).HasColumnName("Chucvu_id");
            this.Property(t => t.ChucVu).HasColumnName("ChucVu");
            this.Property(t => t.SoHD).HasColumnName("SoHD");
            this.Property(t => t.LoaiHD).HasColumnName("LoaiHD");
            this.Property(t => t.ThoihanHD_id).HasColumnName("ThoihanHD_id");
            this.Property(t => t.ThoiHanHD).HasColumnName("ThoiHanHD");
            this.Property(t => t.NgayHL).HasColumnName("NgayHL");
            this.Property(t => t.NgayhetHL).HasColumnName("NgayhetHL");
            this.Property(t => t.Congviec).HasColumnName("Congviec");
            this.Property(t => t.ThoigioLV_id).HasColumnName("ThoigioLV_id");
            this.Property(t => t.ThoiGioLV).HasColumnName("ThoiGioLV");
            this.Property(t => t.BHXH).HasColumnName("BHXH");
            this.Property(t => t.Mucluongchinh).HasColumnName("Mucluongchinh");
            this.Property(t => t.Tyleluong).HasColumnName("Tyleluong");
            this.Property(t => t.HSLuong_id).HasColumnName("HSLuong_id");
            this.Property(t => t.HSLuong).HasColumnName("HSLuong");
            this.Property(t => t.Bac_id).HasColumnName("Bac_id");
            this.Property(t => t.Bac).HasColumnName("Bac");
            this.Property(t => t.Ngach_id).HasColumnName("Ngach_id");
            this.Property(t => t.Ngach).HasColumnName("Ngach");
            this.Property(t => t.Nhom_id).HasColumnName("Nhom_id");
            this.Property(t => t.Nhom).HasColumnName("Nhom");
            this.Property(t => t.MaNhom).HasColumnName("MaNhom");
            this.Property(t => t.Bangluong_id).HasColumnName("Bangluong_id");
            this.Property(t => t.QT_NLDky).HasColumnName("QT_NLDky");
            this.Property(t => t.QT_TrinhHT).HasColumnName("QT_TrinhHT");
            this.Property(t => t.QT_HTky).HasColumnName("QT_HTky");
            this.Property(t => t.QT_LuuHS).HasColumnName("QT_LuuHS");
            this.Property(t => t.QT_TraNLD).HasColumnName("QT_TraNLD");
            this.Property(t => t.QT_NgayNLDky).HasColumnName("QT_NgayNLDky");
            this.Property(t => t.QT_NgayTrinhHT).HasColumnName("QT_NgayTrinhHT");
            this.Property(t => t.QT_NgayHTky).HasColumnName("QT_NgayHTky");
            this.Property(t => t.QT_NgayLuuHS).HasColumnName("QT_NgayLuuHS");
            this.Property(t => t.QT_NgayTraNLD).HasColumnName("QT_NgayTraNLD");
            this.Property(t => t.Ghichu).HasColumnName("Ghichu");

            // Relationships
            this.HasRequired(t => t.dmThoiGioLamViec)
                .WithMany(t => t.hdChiTietHDLDs)
                .HasForeignKey(d => d.ThoigioLV_id)
				.WillCascadeOnDelete(false);
            this.HasRequired(t => t.dmThoiHanHD)
                .WithMany(t => t.hdChiTietHDLDs)
                .HasForeignKey(d => d.ThoihanHD_id)
				.WillCascadeOnDelete(false);
            this.HasRequired(t => t.hdNLD1)
                .WithMany(t => t.hdChiTietHDLDs)
                .HasForeignKey(d => d.NLD_id)
				.WillCascadeOnDelete(false);

        }
    }
}
