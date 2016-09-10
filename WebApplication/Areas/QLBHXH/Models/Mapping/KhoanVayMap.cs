using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.QLBHXH.Models.Mapping
{
    public class KhoanVayMap : EntityTypeConfiguration<KhoanVay>
    {
        public KhoanVayMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.SoChungTu)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.DienGiai)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("KhoanVay");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.idNhanVienVayMuon).HasColumnName("idNhanVienVayMuon");
            this.Property(t => t.idMucDichSuDung).HasColumnName("idMucDichSuDung");
            this.Property(t => t.SoChungTu).HasColumnName("SoChungTu");
            this.Property(t => t.NgayChungTu).HasColumnName("NgayChungTu");
            this.Property(t => t.DienGiai).HasColumnName("DienGiai");
            this.Property(t => t.DinhMuc).HasColumnName("DinhMuc");
            this.Property(t => t.SoTienVay).HasColumnName("SoTienVay");
            this.Property(t => t.SoThang).HasColumnName("SoThang");
            this.Property(t => t.SoNgay).HasColumnName("SoNgay");
            this.Property(t => t.TraTuThang).HasColumnName("TraTuThang");
            this.Property(t => t.TraDenThang).HasColumnName("TraDenThang");
            this.Property(t => t.DatraXong).HasColumnName("DatraXong");
            this.Property(t => t.SttMucDich).HasColumnName("SttMucDich");

            // Relationships
            this.HasRequired(t => t.dmMucDichSuDung)
                .WithMany(t => t.KhoanVays)
                .HasForeignKey(d => d.idMucDichSuDung)
				.WillCascadeOnDelete(false);
            this.HasRequired(t => t.NhanVienVayMuon)
                .WithMany(t => t.KhoanVays)
                .HasForeignKey(d => d.idNhanVienVayMuon)
				.WillCascadeOnDelete(true);

        }
    }
}
