using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases_HDLaoDong.Models.Mapping
{
    public class dmMauHopDongMap : EntityTypeConfiguration<dmMauHopDong>
    {
        public dmMauHopDongMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.tenMauHD)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.hdNoiDung)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("dmMauHopDong");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.tenMauHD).HasColumnName("tenMauHD");
            this.Property(t => t.hdNoiDung).HasColumnName("hdNoiDung");
        }
    }
}
