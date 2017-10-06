<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GalleryForm.ascx.cs" Inherits="KH_Template.GalleryForm" %>
<link    href="Components/Gallery/css/nanogallery2.min.css" rel="stylesheet" type="text/css">
<script  type="text/javascript" src="Components/Gallery/js/jquery.nanogallery2.min.js"></script>
<div id="my_nanogallery2" data-nanogallery2>
    <asp:Repeater runat="server" ID="rptGallery">
           <ItemTemplate>
                <a href="ImageViewer.aspx?FileName=<%# Eval("URL") %>" data-ngthumb="ImageViewer.aspx?FileName=<%# Eval("URL") %>"  data-ngdesc="<%# Eval("Detail")%>"><%# Eval("Title")%></a>
               </ItemTemplate>
        </asp:Repeater>
</div>
      
<%--<div id="my_nanogallery2" data-nanogallery2>
  <!-- first album -->
  <a href=""           data-ngkind="album" data-ngid="1"                     data-ngthumb="images/portfolio_pic1.jpg">Album A</a>
  <a href="images/portfolio_pic1.jpg"                     data-ngid="10" data-ngalbumid="1" data-ngthumb="images/portfolio_pic2.jpg">Image 1 / album A</a>
  <a href="images/portfolio_pic2.jpg"                     data-ngid="11" data-ngalbumid="1" data-ngthumb="images/portfolio_pic3.jpg">Image 2 / album A</a>

  <!-- second album -->
  <a href=""          data-ngkind="album" data-ngid="2"                     data-ngthumb="images/portfolio_pic4.jpg">Album B</a>
  <a href="images/portfolio_pic3.jpg"                     data-ngid="20" data-ngalbumid="2" data-ngthumb="images/portfolio_pic5.jpg"   >Image1</a>
  <a href="images/portfolio_pic4.jpg"                     data-ngid="21" data-ngalbumid="2" data-ngthumb="images/portfolio_pic6.jpg"   >Image2</a>
  <a href="images/portfolio_pic5.jpg"                     data-ngid="22" data-ngalbumid="2" data-ngthumb="images/portfolio_pic7.jpg"   >Image3</a>
</div>  --%>  