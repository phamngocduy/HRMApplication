using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.QLVayMuon.Models.Mapping
{
    public class dmNoiKCBMap : EntityTypeConfiguration<dmNoiKCB>
    {
        public dmNoiKCBMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.MaBV)
                .HasMaxLength(10);

            this.Property(t => t.GhiChu)
                .HasMaxLength(200);

            this.Property(t => t.TenBV)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("dmNoiKCB");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.MaBV).HasColumnName("MaBV");
            this.Property(t => t.GhiChu).HasColumnName("GhiChu");
            this.Property(t => t.Stt).HasColumnName("Stt");
            this.Property(t => t.TenBV).HasColumnName("TenBV");
        }
    }
}
