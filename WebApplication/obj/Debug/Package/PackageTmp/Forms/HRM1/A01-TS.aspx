<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="A01-TS.aspx.cs" Inherits="HRM.Webpages.A01_TS" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 169px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table class="style1">
        <tr>
            <td class="style2">
    
        <asp:ComboBox ID="ComboBox1" runat="server" AutoCompleteMode="SuggestAppend" 
            DataSourceID="SqlDataSource2" DataTextField="HoVaTen" DataValueField="NV_id" 
            MaxLength="0" style="display: inline;">
        </asp:ComboBox>
            </td>
            <td>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Xem " 
            style="margin-left: 12px" Width="86px" />
    
            </td>
        </tr>
    </table>
    <div>
        
    
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
            ConnectionString="<%$ ConnectionStrings:HRMDB1Entities %>" 
            SelectCommand="SELECT [HoVaTen], [NV_id] FROM [nvbhNhanVienBHXH]">
        </asp:SqlDataSource>
    
    </div>
    <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
        AutoDataBind="true" ToolPanelView="None" />
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>
    </form>
</body>
</html>
