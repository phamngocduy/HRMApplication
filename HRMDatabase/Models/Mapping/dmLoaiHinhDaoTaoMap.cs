using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmLoaiHinhDaoTaoMap : EntityTypeConfiguration<dmLoaiHinhDaoTao>
    {
        public dmLoaiHinhDaoTaoMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maLoaiHinhDaoTao)
                .HasMaxLength(10);

            this.Property(t => t.tenLoaiHinhDaoTao)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("dmLoaiHinhDaoTao");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maLoaiHinhDaoTao).HasColumnName("maLoaiHinhDaoTao");
            this.Property(t => t.tenLoaiHinhDaoTao).HasColumnName("tenLoaiHinhDaoTao");
        }
    }
}
