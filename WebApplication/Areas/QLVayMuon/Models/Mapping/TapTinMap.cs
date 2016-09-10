using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.QLVayMuon.Models.Mapping
{
    public class TapTinMap : EntityTypeConfiguration<TapTin>
    {
        public TapTinMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.tenThuMuc)
                .HasMaxLength(50);

            this.Property(t => t.tepDinhKem)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.tengiayto)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("TapTin");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.idTapTin).HasColumnName("idTapTin");
            this.Property(t => t.tenThuMuc).HasColumnName("tenThuMuc");
            this.Property(t => t.tepDinhKem).HasColumnName("tepDinhKem");
            this.Property(t => t.laThuMuc).HasColumnName("laThuMuc");
            this.Property(t => t.tengiayto).HasColumnName("tengiayto");

            // Relationships
            this.HasOptional(t => t.TapTin2)
                .WithMany(t => t.TapTin1)
                .HasForeignKey(d => d.idTapTin);

        }
    }
}
