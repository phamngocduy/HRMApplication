using System;
using System.Linq;
//using System.Data.Entity;
using System.Collections.Generic;

namespace HRM.Databases.Models
{
    public class HRMDBEntities : HRM.Databases.Models.HRMDB0Entities
    {
        public new int SaveChanges()
        {
            return base.SaveChanges(true);
        }
    }
}
