using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases_HDLaoDong.Models.Mapping
{
    public class dmLoaiHopDongMap : EntityTypeConfiguration<dmLoaiHopDong>
    {
        public dmLoaiHopDongMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maLoaiHD)
                .HasMaxLength(10);

            this.Property(t => t.tenLoaiHD)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dmLoaiHopDong");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maLoaiHD).HasColumnName("maLoaiHD");
            this.Property(t => t.tenLoaiHD).HasColumnName("tenLoaiHD");
        }
    }
}
