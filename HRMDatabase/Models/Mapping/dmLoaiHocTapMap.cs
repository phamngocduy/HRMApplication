using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmLoaiHocTapMap : EntityTypeConfiguration<dmLoaiHocTap>
    {
        public dmLoaiHocTapMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maLoaiHocTap)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dmLoaiHocTap");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maLoaiHocTap).HasColumnName("maLoaiHocTap");
            this.Property(t => t.tenLoaiHocTap).HasColumnName("tenLoaiHocTap");
        }
    }
}
