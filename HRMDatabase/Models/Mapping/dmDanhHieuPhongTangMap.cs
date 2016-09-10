using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmDanhHieuPhongTangMap : EntityTypeConfiguration<dmDanhHieuPhongTang>
    {
        public dmDanhHieuPhongTangMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maDanhHieuPhongTang)
                .HasMaxLength(10);

            this.Property(t => t.tenDanhHieuPhongTang)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dmDanhHieuPhongTang");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maDanhHieuPhongTang).HasColumnName("maDanhHieuPhongTang");
            this.Property(t => t.tenDanhHieuPhongTang).HasColumnName("tenDanhHieuPhongTang");
        }
    }
}
