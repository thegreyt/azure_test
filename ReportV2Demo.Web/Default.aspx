<%@ Page Language="C#" AutoEventWireup="true" Inherits="Default" EnableViewState="false"
    ValidateRequest="false" CodeBehind="Default.aspx.cs" %>
<%@ Register Assembly="DevExpress.ExpressApp.Web.v19.2" Namespace="DevExpress.ExpressApp.Web.Templates"
    TagPrefix="cc3" %>
<%@ Register Assembly="DevExpress.ExpressApp.Web.v19.2" Namespace="DevExpress.ExpressApp.Web.Controls"
    TagPrefix="cc4" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>Main Page</title>
    <meta http-equiv="Expires" content="0" />
</head>
<body class="VerticalTemplate">
    <script>
        function ImitCtrlClick(title) {
            var evt = document.createEvent("MouseEvents");
            evt.initMouseEvent("click", true, true, window, 0, 0, 0, 0, 0, true, false, false, false, 0, null);
            var row = $('.dxgv').toArray().filter(function (el) { return el.innerText === title; });
            row[0].dispatchEvent(evt);
        }
        function GetReportBounds() {
            var rect = $(".dxrd-preview")[0].getBoundingClientRect();
            var bounds = [rect.top, rect.left, rect.bottom, rect.right];
            return bounds.toString();
        }
        function GetReportDesignerBounds() {
            var rect = $(".dx-designer")[0].getBoundingClientRect();
            var bounds = [rect.top, rect.left, rect.bottom, rect.right];
            return bounds.toString();
        }
    </script>
    <form id="form2" runat="server">
    <cc4:ASPxProgressControl ID="ProgressControl" runat="server" />
    <div runat="server" id="Content" />
    </form>
</body>
</html>
