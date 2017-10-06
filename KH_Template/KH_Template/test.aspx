<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="KH_Template.test" %>
<%@ Register Src="Forms/Gallery/GallerySetting.ascx" TagPrefix="KH" TagName="GallerySetting" %>
<%@ Register Src="Forms/Gallery/GalleryForm.ascx" TagPrefix="KH" TagName="GalleryForm" %>
<%@ Register Src="Forms/Calendar/CalendarForm.ascx" TagPrefix="KH" TagName="CalendarForm" %>
<%@ Register Src="Forms/Calendar/CalendarSetting.ascx" TagPrefix="KH" TagName="CalendarSetting" %>
<%@ Register Src="Forms/Table/TableForm.ascx" TagPrefix="KH" TagName="TableForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <header>
					<h2>Content Management</h2>
					<p>Tell us what you think about our little operation.</p>
				</header>
     <KH:TableForm id="tableform1" Data="Select * From Event" runat="server"/>
<!-- Add the web user control in asp -->
<%--<KH:GallerySetting id="MyControl" runat="server"/>

    <KH:GalleryForm id="ContentForm1" runat="server"/>
    <br /><br />
   

   <KH:CalendarSetting id="CalendarSetting1" runat="server"/>
<KH:CalendarForm id="MyControl1" runat="server"/>--%>
</asp:Content>
