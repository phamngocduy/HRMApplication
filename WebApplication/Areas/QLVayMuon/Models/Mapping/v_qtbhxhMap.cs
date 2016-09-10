using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.QLVayMuon.Models.Mapping
{
    public class v_qtbhxhMap : EntityTypeConfiguration<v_qtbhxh>
    {
        public v_qtbhxhMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GhiChu1)
                .HasMaxLength(200);

            this.Property(t => t.GhiChu2)
                .HasMaxLength(200);

            this.Property(t => t.HoVaTen)
                .HasMaxLength(100);

            this.Property(t => t.MANV)
                .HasMaxLength(50);

            this.Property(t => t.DonVi)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("v_qtbhxh");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.idNVBHXH).HasColumnName("idNVBHXH");
            this.Property(t => t.ThoiGianBatDau).HasColumnName("ThoiGianBatDau");
            this.Property(t => t.ThoiGianKetThuc).HasColumnName("ThoiGianKetThuc");
            this.Property(t => t.MucLuongDongBHXH).HasColumnName("MucLuongDongBHXH");
            this.Property(t => t.MucDongBHXH).HasColumnName("MucDongBHXH");
            this.Property(t => t.MucDongBHTN).HasColumnName("MucDongBHTN");
            this.Property(t => t.HeSoTienLuongDongBHXH).HasColumnName("HeSoTienLuongDongBHXH");
            this.Property(t => t.MucDongToiThieu).HasColumnName("MucDongToiThieu");
            this.Property(t => t.GhiChu1).HasColumnName("GhiChu1");
            this.Property(t => t.GhiChu2).HasColumnName("GhiChu2");
            this.Property(t => t.NV_ID).HasColumnName("NV_ID");
            this.Property(t => t.TG_ID).HasColumnName("TG_ID");
            this.Property(t => t.TienLuong).HasColumnName("TienLuong");
            this.Property(t => t.HSL).HasColumnName("HSL");
            this.Property(t => t.HoVaTen).HasColumnName("HoVaTen");
            this.Property(t => t.MANV).HasColumnName("MANV");
            this.Property(t => t.DonVi).HasColumnName("DonVi");
            this.Property(t => t.SoBHXH).HasColumnName("SoBHXH");
            this.Property(t => t.SoKCB).HasColumnName("SoKCB");
            this.Property(t => t.TLBHYT).HasColumnName("TLBHYT");
            this.Property(t => t.TLBHTN).HasColumnName("TLBHTN");
            this.Property(t => t.TLBHXH).HasColumnName("TLBHXH");
            this.Property(t => t.MLTTC).HasColumnName("MLTTC");
            this.Property(t => t.MLTTV).HasColumnName("MLTTV");
        }
    }
}
