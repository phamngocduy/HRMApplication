using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmLoaiBaoLuuHSLMap : EntityTypeConfiguration<dmLoaiBaoLuuHSL>
    {
        public dmLoaiBaoLuuHSLMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maLoaiBaoLuuHSL)
                .HasMaxLength(10);

            this.Property(t => t.tenLoaiBaoLuuHSL)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dmLoaiBaoLuuHSL");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maLoaiBaoLuuHSL).HasColumnName("maLoaiBaoLuuHSL");
            this.Property(t => t.tenLoaiBaoLuuHSL).HasColumnName("tenLoaiBaoLuuHSL");
        }
    }
}
