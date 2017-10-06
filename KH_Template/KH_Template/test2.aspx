<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test2.aspx.cs" Inherits="KH_Template.test2" %>
<%@ Register Src="Forms/Calendar/CalendarForm.ascx" TagPrefix="KH" TagName="CalendarForm" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="js/jquery.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <KH:CalendarForm id="MyControl" runat="server"/>
        </div>
    </form>
</body>
</html>
