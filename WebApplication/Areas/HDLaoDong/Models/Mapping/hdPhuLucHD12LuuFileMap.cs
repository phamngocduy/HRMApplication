using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.Databases_HDLaoDong.Models.Mapping
{
    public class hdPhuLucHD12LuuFileMap : EntityTypeConfiguration<hdPhuLucHD12LuuFile>
    {
        public hdPhuLucHD12LuuFileMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.LoaiPL)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TenPL)
                .HasMaxLength(100);

            this.Property(t => t.FileAnh)
                .IsRequired();

            this.Property(t => t.MimeType)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FileName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("hdPhuLucHD12LuuFile");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.LoaiPL).HasColumnName("LoaiPL");
            this.Property(t => t.HD_id).HasColumnName("HD_id");
            this.Property(t => t.TenPL).HasColumnName("TenPL");
            this.Property(t => t.NgaylapPL).HasColumnName("NgaylapPL");
            this.Property(t => t.FileAnh).HasColumnName("FileAnh");
            this.Property(t => t.MimeType).HasColumnName("MimeType");
            this.Property(t => t.FileName).HasColumnName("FileName");
            this.Property(t => t.Ghichu).HasColumnName("Ghichu");

            // Relationships
            this.HasRequired(t => t.hdChiTietHDLD)
                .WithMany(t => t.hdPhuLucHD12LuuFile)
                .HasForeignKey(d => d.HD_id)
				.WillCascadeOnDelete(false);

        }
    }
}
