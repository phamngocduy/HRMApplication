using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace HRM.Webpages.Forms.HRM1.Utils
{
    public static class Utilities
    {
        public static void LoadConnectionString(this ReportDocument report)
        {
            var builder = new SqlConnectionStringBuilder(
                WebConfigurationManager.ConnectionStrings["HRMDB1Entities"].ConnectionString);
            report.DataSourceConnections[0].SetConnection(
                builder.DataSource, builder.InitialCatalog, builder.UserID, builder.Password);
        }
    }
}