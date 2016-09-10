<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BHXH_D02TS.aspx.cs" Inherits="HRM.Webpages.BHXH_D02TS" Culture="vi-VN" uiCulture="vi" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
      <asp:CalendarExtender ID="TextBox1_CalendarExtender" ClientIDMode="Static" runat="server"
                      TargetControlID="TextBox1" Format="MM/yyyy" 
                      DefaultView="Months" OnClientShown="onCalendarShown"
                      OnClientHidden="onCalendarHidden" PopupButtonID="imgStart" >
        </asp:CalendarExtender>

        
    
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click1" 
            Text="Button" />

        
    
    </div>
    <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
        AutoDataBind="True" GroupTreeImagesFolderUrl="" Height="50px" 
        ReportSourceID="CrystalReportSource1" ToolbarImagesFolderUrl="" 
        ToolPanelWidth="200px" Width="350px" ToolPanelView="None" />
    <CR:CrystalReportSource ID="CrystalReportSource1" runat="server">
        <Report FileName="crystal\MauDO2TS.rpt">
            <Parameters>
                <CR:Parameter ConvertEmptyStringToNull="False" DefaultValue="" Name="@ngaybd" 
                    ReportName="" />
                <CR:ControlParameter ControlID="" ConvertEmptyStringToNull="False" 
                    DefaultValue="" Name="@ngaykt" PropertyName="" ReportName="" />
            </Parameters>
        </Report>
    </CR:CrystalReportSource>
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"  EnableScriptGlobalization="True">
    </asp:ToolkitScriptManager>
    </form>
</body>
</html>


<script type="text/javascript">

    function onCalendarHidden() {
        var cal = $find("TextBox1_CalendarExtender");

        if (cal._monthsBody) {
            for (var i = 0; i < cal._monthsBody.rows.length; i++) {
                var row = cal._monthsBody.rows[i];
                for (var j = 0; j < row.cells.length; j++) {
                    Sys.UI.DomEvent.removeHandler(row.cells[j].firstChild, "click", call);
                }
            }
        }
    }

    function onCalendarShown() {

        var cal = $find("TextBox1_CalendarExtender");

        cal._switchMode("months", true);

        if (cal._monthsBody) {
            for (var i = 0; i < cal._monthsBody.rows.length; i++) {
                var row = cal._monthsBody.rows[i];
                for (var j = 0; j < row.cells.length; j++) {
                    Sys.UI.DomEvent.addHandler(row.cells[j].firstChild, "click", call);
                }
            }
        }
    }

    function call(eventElement) {
        var target = eventElement.target;
        switch (target.mode) {
            case "month":
                var cal = $find("TextBox1_CalendarExtender");
                cal._visibleDate = target.date;
                cal.set_selectedDate(target.date);
                //cal._switchMonth(target.date);
                cal._blur.post(true);
                cal.raiseDateSelectionChanged();
                break;
        }
    }
</script>
