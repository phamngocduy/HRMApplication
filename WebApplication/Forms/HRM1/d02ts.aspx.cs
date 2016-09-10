using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;
using HRM.Webpages.Forms.HRM1.Utils;
namespace HRM.Webpages
{
    public partial class d02ts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReportDocument rptDoc = new ReportDocument();
            CrystalReportViewer1.Visible = true;
            rptDoc.Load(Server.MapPath("crystal/MauDO2TS.rpt"));
            rptDoc.LoadConnectionString(); // Fix bug
            //rptDoc.SetDatabaseLogon("sa", "123456");
            CrystalReportViewer1.ReportSource = rptDoc;
            CrystalReportViewer1.HasExportButton = true;
            CrystalReportViewer1.HasPrintButton = true;
        }

        protected void CrystalReportViewer1_Init(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}