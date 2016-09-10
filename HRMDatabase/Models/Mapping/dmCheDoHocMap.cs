using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmCheDoHocMap : EntityTypeConfiguration<dmCheDoHoc>
    {
        public dmCheDoHocMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maCheDoHoc)
                .HasMaxLength(50);

            this.Property(t => t.tenCheDoHoc)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("dmCheDoHoc");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maCheDoHoc).HasColumnName("maCheDoHoc");
            this.Property(t => t.tenCheDoHoc).HasColumnName("tenCheDoHoc");
        }
    }
}
