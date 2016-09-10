using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.QLVayMuon.Models.Mapping
{
    public class HoSoVayMuonMap : EntityTypeConfiguration<HoSoVayMuon>
    {
        public HoSoVayMuonMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.URLFile)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("HoSoVayMuon");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.idGiayTo).HasColumnName("idGiayTo");
            this.Property(t => t.idKhoanVay).HasColumnName("idKhoanVay");
            this.Property(t => t.TrangThai).HasColumnName("TrangThai");
            this.Property(t => t.URLFile).HasColumnName("URLFile");

            // Relationships
            this.HasRequired(t => t.dmGiayTo)
                .WithMany(t => t.HoSoVayMuons)
                .HasForeignKey(d => d.idGiayTo);
            this.HasRequired(t => t.KhoanVay)
                .WithMany(t => t.HoSoVayMuons)
                .HasForeignKey(d => d.idKhoanVay);

        }
    }
}
