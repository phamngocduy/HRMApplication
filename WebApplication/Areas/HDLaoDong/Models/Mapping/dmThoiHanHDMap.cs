using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases_HDLaoDong.Models.Mapping
{
    public class dmThoiHanHDMap : EntityTypeConfiguration<dmThoiHanHD>
    {
        public dmThoiHanHDMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.tenThoiHanHD)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.loaiHopDong)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dmThoiHanHD");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.tenThoiHanHD).HasColumnName("tenThoiHanHD");
            this.Property(t => t.valThoiHanHD).HasColumnName("valThoiHanHD");
            this.Property(t => t.Duoi).HasColumnName("Duoi");
            this.Property(t => t.loaiHopDong).HasColumnName("loaiHopDong");
        }
    }
}
