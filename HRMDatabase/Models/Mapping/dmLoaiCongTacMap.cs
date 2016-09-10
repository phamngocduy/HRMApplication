using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmLoaiCongTacMap : EntityTypeConfiguration<dmLoaiCongTac>
    {
        public dmLoaiCongTacMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maLoaiCongTac)
                .HasMaxLength(10);

            this.Property(t => t.tenLoaiCongTac)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dmLoaiCongTac");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maLoaiCongTac).HasColumnName("maLoaiCongTac");
            this.Property(t => t.tenLoaiCongTac).HasColumnName("tenLoaiCongTac");
        }
    }
}
