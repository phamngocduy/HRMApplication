using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HRM.QLBHXH.Models.Mapping
{
    public class dmLaiSuatTruyThuMap : EntityTypeConfiguration<dmLaiSuatTruyThu>
    {
        public dmLaiSuatTruyThuMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("dmLaiSuatTruyThu");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.NgayApDung).HasColumnName("NgayApDung");
            this.Property(t => t.NgayKetThuc).HasColumnName("NgayKetThuc");
            this.Property(t => t.BHXH).HasColumnName("BHXH");
            this.Property(t => t.BHYT).HasColumnName("BHYT");
            this.Property(t => t.BHTN).HasColumnName("BHTN");
            this.Property(t => t.STT).HasColumnName("STT");
        }
    }
}
