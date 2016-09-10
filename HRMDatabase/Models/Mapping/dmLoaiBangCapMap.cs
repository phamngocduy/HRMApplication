using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases.Models.Mapping
{
    public class dmLoaiBangCapMap : EntityTypeConfiguration<dmLoaiBangCap>
    {
        public dmLoaiBangCapMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.maLoaiBangCap)
                .HasMaxLength(10);

            this.Property(t => t.tenLoaiBangCap)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("dmLoaiBangCap");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stt).HasColumnName("stt");
            this.Property(t => t.maLoaiBangCap).HasColumnName("maLoaiBangCap");
            this.Property(t => t.tenLoaiBangCap).HasColumnName("tenLoaiBangCap");
            this.Property(t => t.idTrinhDo).HasColumnName("idTrinhDo");

            // Relationships
            this.HasOptional(t => t.dmTrinhDo)
                .WithMany(t => t.dmLoaiBangCaps)
                .HasForeignKey(d => d.idTrinhDo)
				.WillCascadeOnDelete(false);

        }
    }
}
