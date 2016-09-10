using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmLoaiChungChiMap : EntityTypeConfiguration<dmLoaiChungChi>
    {
        public dmLoaiChungChiMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maLoaiChungChi)
                .HasMaxLength(10);

            this.Property(t => t.tenLoaiChungChi)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dmLoaiChungChi");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maLoaiChungChi).HasColumnName("maLoaiChungChi");
            this.Property(t => t.tenLoaiChungChi).HasColumnName("tenLoaiChungChi");
        }
    }
}
