using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases_TuyenDung.Models.Mapping
{
    public class tdTTUngCuVienMap : EntityTypeConfiguration<tdTTUngCuVien>
    {
        public tdTTUngCuVienMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.HoVaTen)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.TTHonNhan)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tdTTUngCuVien");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.HoVaTen).HasColumnName("HoVaTen");
            this.Property(t => t.GioiTinh_id).HasColumnName("GioiTinh_id");
            this.Property(t => t.NgaySinh).HasColumnName("NgaySinh");
            this.Property(t => t.TTHonNhan).HasColumnName("TTHonNhan");
            this.Property(t => t.TPGiaDinh_id).HasColumnName("TPGiaDinh_id");
            this.Property(t => t.DanToc_id).HasColumnName("DanToc_id");
            this.Property(t => t.TonGiao_id).HasColumnName("TonGiao_id");
            this.Property(t => t.QuocTich_id).HasColumnName("QuocTich_id");
            this.Property(t => t.hidden).HasColumnName("hidden");
            this.Property(t => t.KetQuaTuyenDung).HasColumnName("KetQuaTuyenDung");
        }
    }
}
