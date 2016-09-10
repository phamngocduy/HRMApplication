using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases_TuyenDung.Models.Mapping
{
    public class hdCanTaoHDLDMap : EntityTypeConfiguration<hdCanTaoHDLD>
    {
        public hdCanTaoHDLDMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.MaNV)
                .HasMaxLength(50);

            this.Property(t => t.MaTD)
                .HasMaxLength(50);

            this.Property(t => t.Hoten)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.soCMND)
                .IsFixedLength()
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("hdCanTaoHDLD");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.MaNV).HasColumnName("MaNV");
            this.Property(t => t.MaTD).HasColumnName("MaTD");
            this.Property(t => t.Hoten).HasColumnName("Hoten");
            this.Property(t => t.GioiTinh_id).HasColumnName("GioiTinh_id");
            this.Property(t => t.Quoctich_id).HasColumnName("Quoctich_id");
            this.Property(t => t.Ngaysinh).HasColumnName("Ngaysinh");
            this.Property(t => t.Noisinh).HasColumnName("Noisinh");
            this.Property(t => t.Diachithuongtru).HasColumnName("Diachithuongtru");
            this.Property(t => t.soCMND).HasColumnName("soCMND");
            this.Property(t => t.cmndNgaycap).HasColumnName("cmndNgaycap");
            this.Property(t => t.cmndNoicap).HasColumnName("cmndNoicap");
            this.Property(t => t.VitriCT_id).HasColumnName("VitriCT_id");
            this.Property(t => t.Donvi_id).HasColumnName("Donvi_id");
            this.Property(t => t.Nghenghiep_id).HasColumnName("Nghenghiep_id");
            this.Property(t => t.Lydo).HasColumnName("Lydo");
        }
    }
}
