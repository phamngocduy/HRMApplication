using System;
using System.Linq;
using System.Data;
using System.Collections.Generic;
using System.Collections.Specialized;
using HRM.Webpages.Helpers;
namespace HRM.QLThinhGiang.Models
{
    public static class DataTableExt
    {
        public static DataTable SqlQuery(this HRMDB_Entities db, string sql, params object[] parameters)
        {
            return db.Database.SqlQuery(sql, parameters);
        }

        public static string SqlCreate(this HRMDB_Entities db, string name, NameValueCollection form)
        {
            return db.Database.SqlCreate(name, form);
        }

        public static string SqlUpdate(this HRMDB_Entities db, string name, NameValueCollection form)
        {
            return db.Database.SqlUpdate(name, form);
        }

        public static int SqlExecute(this HRMDB_Entities db, string query, params object[] parameters)
        {
            return db.Database.SqlExecute(query, parameters);
        }

        public static string SqlDelete(this HRMDB_Entities db, string name, int id)
        {
            return db.Database.SqlDelete(name, id);
        }
    }
}