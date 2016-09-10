using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmPhanLoaiCBGVNVMap : EntityTypeConfiguration<dmPhanLoaiCBGVNV>
    {
        public dmPhanLoaiCBGVNVMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maPhanLoaiCBGVNV)
                .HasMaxLength(10);

            this.Property(t => t.tenPhanLoaiCBGVNV)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dmPhanLoaiCBGVNV");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maPhanLoaiCBGVNV).HasColumnName("maPhanLoaiCBGVNV");
            this.Property(t => t.tenPhanLoaiCBGVNV).HasColumnName("tenPhanLoaiCBGVNV");
        }
    }
}
