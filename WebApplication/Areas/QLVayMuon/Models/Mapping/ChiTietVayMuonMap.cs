using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.QLVayMuon.Models.Mapping
{
    public class ChiTietVayMuonMap : EntityTypeConfiguration<ChiTietVayMuon>
    {
        public ChiTietVayMuonMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.SoChungTu)
                .HasMaxLength(10);

            this.Property(t => t.DienGiai)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("ChiTietVayMuon");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.idVm).HasColumnName("idVm");
            this.Property(t => t.IdNhanVienVayMuon).HasColumnName("IdNhanVienVayMuon");
            this.Property(t => t.NgayChungTu).HasColumnName("NgayChungTu");
            this.Property(t => t.SoChungTu).HasColumnName("SoChungTu");
            this.Property(t => t.DienGiai).HasColumnName("DienGiai");
            this.Property(t => t.MucDichSuDung).HasColumnName("MucDichSuDung");
            this.Property(t => t.Dinhmuc).HasColumnName("Dinhmuc");
            this.Property(t => t.SoTienVay).HasColumnName("SoTienVay");
            this.Property(t => t.SotienHoan).HasColumnName("SotienHoan");
            this.Property(t => t.SotienLai).HasColumnName("SotienLai");
            this.Property(t => t.idvay).HasColumnName("idvay");
            this.Property(t => t.idhoan).HasColumnName("idhoan");

            // Relationships
            this.HasOptional(t => t.dmMucDichSuDung)
                .WithMany(t => t.ChiTietVayMuons)
                .HasForeignKey(d => d.MucDichSuDung);

        }
    }
}
