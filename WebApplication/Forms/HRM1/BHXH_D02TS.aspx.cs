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
    public partial class BHXH_D02TS : System.Web.UI.Page
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

        protected void Button1_Click1(object sender, EventArgs e)
        {
            reportload();
        }

        //load report
        public void reportload()
        {
            string a = TextBox1.Text;
            int thanght, namht;
            bool thang = int.TryParse(a.Substring(0, 2), out thanght);
            bool nam = int.TryParse(a.Substring(3, 4), out namht);
           string ngaybd1 = "11";
            string ngaykt1 = "11";

            switch (thanght)
            {
                case 1: ngaybd1 = "12/21/" + (namht - 1); ngaykt1 = "01/20/" + namht; break;
                case 2: ngaybd1 = "01/21/" + namht; ngaykt1 = "02/20/" + namht; break;
                case 3: ngaybd1 = "02/21/" + namht; ngaykt1 = "03/20/" + namht; break;
                case 4: ngaybd1 = "03/21/" + namht; ngaykt1 = "04/20/" + namht; break;
                case 5: ngaybd1 = "04/21/" + namht; ngaykt1 = "05/20/" + namht; break;
                case 6: ngaybd1 = "05/21/" + namht; ngaykt1 = "06/20/" + namht; break;
                case 7: ngaybd1 = "06/21/" + (namht); ngaykt1 = "07/20/" + namht; break;
                case 8: ngaybd1 = "07/21/" + namht; ngaykt1 = "08/20/" + namht; break;
                case 9: ngaybd1 = "08/21/" + namht; ngaykt1 = "09/20/" + namht; break;
                case 10: ngaybd1 = "09/21/" + namht; ngaykt1 = "10/20/" + namht; break;
                case 11: ngaybd1 = "10/21/" + namht; ngaykt1 = "11/20/" + namht; break;
                case 12: ngaybd1 = "11/21/" + namht; ngaykt1 = "12/20/" + (namht + 1); break;
            }
           



            //neu khong chon ngay thi bao loi
           
              
                ParameterFields paramFields = new ParameterFields();
                ParameterValues Val1 = new ParameterValues();
                ParameterDiscreteValue discreteVal1 = new ParameterDiscreteValue();
                ParameterDiscreteValue discreteVal2 = new ParameterDiscreteValue();

                ////sub report para

                ReportDocument rptDoc = new ReportDocument();
                rptDoc.Load(Server.MapPath("~/Forms/HRM1/crystal/MauDO2TS.rpt"));
                rptDoc.LoadConnectionString(); // Fix bug
                //rptDoc.SetDatabaseLogon("sa", "123456");
                CrystalReportViewer1.ReportSource = rptDoc;



                discreteVal1.Value = ngaybd1;
                discreteVal2.Value = ngaykt1;



                //para
                ParameterField ngaybd = CrystalReportViewer1.ParameterFieldInfo[0];
                ParameterField ngaykt = CrystalReportViewer1.ParameterFieldInfo[1];


                ngaybd.CurrentValues.Add(discreteVal1);
                ngaykt.CurrentValues.Add(discreteVal2);



                //// Add the parameter to the parameter fields collection. 
                paramFields.Add(ngaybd);

                paramFields.Add(ngaykt);


                CrystalReportViewer1.ParameterFieldInfo = paramFields;
                CrystalReportViewer1.Visible = true;

        
        }

       
    }
}