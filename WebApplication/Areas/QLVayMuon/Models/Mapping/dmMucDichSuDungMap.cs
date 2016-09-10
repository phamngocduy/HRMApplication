using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.QLVayMuon.Models.Mapping
{
    public class dmMucDichSuDungMap : EntityTypeConfiguration<dmMucDichSuDung>
    {
        public dmMucDichSuDungMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.MaMucDich)
                .HasMaxLength(10);

            this.Property(t => t.TenMucDich)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.DonViThoiGian)
                .HasMaxLength(50);

            this.Property(t => t.GhiChu)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("dmMucDichSuDung");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.MaMucDich).HasColumnName("MaMucDich");
            this.Property(t => t.TenMucDich).HasColumnName("TenMucDich");
            this.Property(t => t.HanMucToiDa).HasColumnName("HanMucToiDa");
            this.Property(t => t.ThoiGianHoanTien).HasColumnName("ThoiGianHoanTien");
            this.Property(t => t.DonViThoiGian).HasColumnName("DonViThoiGian");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.stt).HasColumnName("stt");
        }
    }
}
