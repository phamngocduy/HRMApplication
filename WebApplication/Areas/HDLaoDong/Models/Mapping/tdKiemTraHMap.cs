using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases_HDLaoDong.Models.Mapping
{
    public class tdKiemTraHMap : EntityTypeConfiguration<tdKiemTraH>
    {
        public tdKiemTraHMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("tdKiemTraHS");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.UngVien_id).HasColumnName("UngVien_id");
            this.Property(t => t.DonXinViec).HasColumnName("DonXinViec");
            this.Property(t => t.SoYeuLyLich).HasColumnName("SoYeuLyLich");
            this.Property(t => t.TheDinhDanh).HasColumnName("TheDinhDanh");
            this.Property(t => t.SoHoKhau).HasColumnName("SoHoKhau");
            this.Property(t => t.GiayKhamSucKhoe).HasColumnName("GiayKhamSucKhoe");
            this.Property(t => t.BangCapBangDiem).HasColumnName("BangCapBangDiem");
            this.Property(t => t.Hinh).HasColumnName("Hinh");
            this.Property(t => t.GiayToKhac).HasColumnName("GiayToKhac");
            this.Property(t => t.GiayToKhac_Note).HasColumnName("GiayToKhac_Note");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");

            // Relationships
            this.HasRequired(t => t.tdTTUngCuVien)
                .WithMany(t => t.tdKiemTraHS)
                .HasForeignKey(d => d.UngVien_id)
				.WillCascadeOnDelete(false);

        }
    }
}
