<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BcTonghopvay.aspx.cs" Inherits="HRM.Webpages.WebForm1" Culture="vi-VN" uiCulture="vi"%>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

    <div >
    
       
                    Từ ngày:
                    <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 14px" 
                        Width="155px"></asp:TextBox>
               
                    <asp:CalendarExtender ID="TextBox1_CalendarExtender" runat="server" 
                        Enabled="True" TargetControlID="TextBox1">
                    </asp:CalendarExtender>
               
                    Đến ngày:<asp:TextBox ID="TextBox2" runat="server" style="margin-left: 19px" 
                        Width="142px"></asp:TextBox>
                    <asp:CalendarExtender ID="TextBox2_CalendarExtender" runat="server" 
                        Enabled="True" TargetControlID="TextBox2">
                    </asp:CalendarExtender>
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                        style="margin-left: 5px" Text="Xem báo cáo" />
            
    
                  
            
    
                    <asp:ToolkitScriptManager ID="ToolkitScriptManager2" runat="server" EnableScriptGlobalization="True">
                    </asp:ToolkitScriptManager>
            
    
    </div >
 
    <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
        AutoDataBind="true" />
 
    </form>
</body>
</html>
