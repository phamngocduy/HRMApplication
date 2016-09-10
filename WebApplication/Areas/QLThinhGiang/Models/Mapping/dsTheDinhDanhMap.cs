using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.QLThinhGiang.Models.Mapping
{
    public class dsTheDinhDanhMap : EntityTypeConfiguration<dsTheDinhDanh>
    {
        public dsTheDinhDanhMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.NV_id, t.LoaiThe_id, t.SoThe });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NV_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LoaiThe_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SoThe)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.tenLoaiTheDinhDanh)
                .HasMaxLength(50);

            this.Property(t => t.tenTinhThanh)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dsTheDinhDanh");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NV_id).HasColumnName("NV_id");
            this.Property(t => t.LoaiThe_id).HasColumnName("LoaiThe_id");
            this.Property(t => t.SoThe).HasColumnName("SoThe");
            this.Property(t => t.NgayCap).HasColumnName("NgayCap");
            this.Property(t => t.NoiCap_id).HasColumnName("NoiCap_id");
            this.Property(t => t.NgayHetHan).HasColumnName("NgayHetHan");
            this.Property(t => t.tenLoaiTheDinhDanh).HasColumnName("tenLoaiTheDinhDanh");
            this.Property(t => t.tenTinhThanh).HasColumnName("tenTinhThanh");
        }
    }
}
