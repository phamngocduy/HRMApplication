<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BCchitietvaytheongay.aspx.cs" Inherits="HRM.Webpages.BCchitietvaytheongay" Culture="vi-VN" uiCulture="vi"%>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style3
        {
            width: 160px;
        }
        .style5
        {
            width: 152px;
        }
        .style6
        {
            width: 98px;
        }
        .style7
        {
            width: 113px;
        }
        .style8
        {
            width: 83px;
        }
        .style9
        {
            width: 158px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
   <div >
                <table class="style1">
                    <tr>
                        <td class="style9">
                Tên nhân viên:</td>
                        <td class="style3">
                            <asp:ComboBox ID="ComboBox1" runat="server" DataSourceID="SqlDataSource1" 
                                DataTextField="ten" DataValueField="id" MaxLength="0" style="display: inline;">
                            </asp:ComboBox>
                        </td>
                        <td class="style8">
                 Từ ngày:</td>
                        <td class="style5">
                            <asp:TextBox ID="TextBox1" runat="server" 
                    style="margin-left: 1px" Width="80px" ></asp:TextBox>
        
                <asp:CalendarExtender ID="TextBox1_CalendarExtender" runat="server" 
                    Enabled="True" TargetControlID="TextBox1">
                </asp:CalendarExtender>
        
                        </td>
                        <td class="style6">
        
                Đến ngày:</td>
                        <td class="style7">
                            <asp:TextBox ID="TextBox2" runat="server" 
                    style="margin-left: 5px" Width="80px" ></asp:TextBox>
               
                <asp:CalendarExtender ID="TextBox2_CalendarExtender" runat="server" 
                    Enabled="True" TargetControlID="TextBox2">
                </asp:CalendarExtender>
               
                        </td>
                        <td>
               
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Xem báo cáo" 
                    Width="106px"  style="margin-left: 8px"/>
                        </td>
                    </tr>
                </table>
               <br />
               
              <div>
                  <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"  EnableScriptGlobalization="True">
                  </asp:ToolkitScriptManager>
            </div>
                

 


 
            <div>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:HRMDB1Entities %>" 
                    
                    
                    
                    SelectCommand="select HoVaTen +' - '+ DonVi as ten , id  from NhanVienVayMuon order by ten">
                </asp:SqlDataSource>
                <br/>

</div>



 
    </div>
    <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
        AutoDataBind="true" />
    <CR:CrystalReportViewer ID="CrystalReportViewer2" runat="server" 
        AutoDataBind="true" />
    </form>
</body>
</html>
