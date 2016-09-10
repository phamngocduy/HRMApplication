using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.QLVayMuon.Models.Mapping
{
    public class v_ChucDanhMap : EntityTypeConfiguration<v_ChucDanh>
    {
        public v_ChucDanhMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.idchucdanh, t.TuThangNam, t.idLoaiDieuChinh, t.MoiNhat });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.idchucdanh)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CVMoi)
                .HasMaxLength(200);

            this.Property(t => t.GhiChu)
                .HasMaxLength(200);

            this.Property(t => t.HoVaTen)
                .HasMaxLength(100);

            this.Property(t => t.idLoaiDieuChinh)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MoiNhat)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CVCu)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("v_ChucDanh");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.idchucdanh).HasColumnName("idchucdanh");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.CVMoi).HasColumnName("CVMoi");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.TuThangNam).HasColumnName("TuThangNam");
            this.Property(t => t.HoVaTen).HasColumnName("HoVaTen");
            this.Property(t => t.SoBHXH).HasColumnName("SoBHXH");
            this.Property(t => t.NgaySinh).HasColumnName("NgaySinh");
            this.Property(t => t.Nu).HasColumnName("Nu");
            this.Property(t => t.idLoaiDieuChinh).HasColumnName("idLoaiDieuChinh");
            this.Property(t => t.MoiNhat).HasColumnName("MoiNhat");
            this.Property(t => t.CVCu).HasColumnName("CVCu");
            this.Property(t => t.DenThangNam).HasColumnName("DenThangNam");
            this.Property(t => t.NgayPhatSinh).HasColumnName("NgayPhatSinh");
        }
    }
}
