<!DOCTYPE html>
<%@Page Language="C#"%>
<%@Import Namespace="System.IO"%>
<%@Import Namespace="System.Web"%>
<%@Import Namespace="HRM.Webpages"%>
<%@Import Namespace="HRM.Webpages.Helpers"%>
<script runat="server">
private string GetText() {
    var path = HttpContext.Current.Server.MapPath(Resources.Vietnamese);
    using (var file = new StreamReader(path))
        return file.ReadToEnd();
}
private void SetText(string text) {
    var path = HttpContext.Current.Server.MapPath(Resources.Vietnamese);
    using (var file = new StreamWriter(path, false))
        file.Write(text);
}
private void Process() {
    var tran = HttpContext.Current.Request.Form["Translation"];
    if (String.IsNullOrEmpty(tran) ||
        String.IsNullOrWhiteSpace(tran))
        return;
    //SetText(tran);
    Vietnamese.Reload();
}
</script>
<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title></title>
</head>
<body>
    <%Process();%>
    <form action="Vietnamese.aspx" method="post">
        <input type="submit" value="Reload" />
        <div>
            <textarea name="Translation" rows="40" cols="80" readonly><%Response.Write(GetText());%></textarea>
        </div>
    </form>
</body>
</html>
