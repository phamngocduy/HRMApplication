using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using HRM.Webpages.Forms.HRM1.Utils;
namespace HRM.Webpages
{
    public partial class A01_TS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack == false)
            {

                CrystalReportViewer1.Visible = false;
            }
            //khi bam export se load lai report
            else
            {
                reportload();

            }


        }
        //bam nut xem bao cao
        protected void Button1_Click(object sender, EventArgs e)
        {

            reportload();

        }
        //load report
        public void reportload()
        {

            string id = ComboBox1.SelectedValue;

           



            ////sub report para




            ReportDocument rptDoc = new ReportDocument();
            rptDoc.Load(Server.MapPath("~/Forms/HRM1/crystal/A01-TS.rpt"));
            rptDoc.LoadConnectionString(); // Fix bug
            //rptDoc.SetDatabaseLogon("sa", "123456");
            CrystalReportViewer1.ReportSource = rptDoc;

            rptDoc.SetParameterValue("@IDNV", id);


           
            CrystalReportViewer1.Visible = true;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}