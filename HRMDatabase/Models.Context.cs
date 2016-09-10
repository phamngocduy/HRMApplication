using System;
using System.Linq;
using System.Data.Entity;
using System.Collections.Generic;

namespace HRM.Databases.Models
{
    public class DbSet
    {
        public DbSet<NhanVien> All { get; set; }
    }

    public class HRMDB0Entities : HRM.Databases.Model1.HRMDBEntities
    {
        public DbSet NhanViens
        {
            get { return new DbSet() { All = base.NhanVien }; }
            set { base.NhanVien = value.All; }
        }

        public new IEnumerable<NhanVien> NhanVien
        {
            get { return base.NhanVien.ToList(); }
        }

        [Obsolete("This is not supported in this class.", true)]
        public new int SaveChanges()
        {
            throw new NotImplementedException("This is not supported in this class.");
        }
        protected int SaveChanges(bool ok)
        {
            return base.SaveChanges();
        }
    }
}
