<%@ Page Language="C#" ContentType="text/html" ResponseEncoding="utf-8"  Debug="true" Inherits="GetCalendarData" CodeFile="GetCalendarData.aspx.cs" AutoEventWireup="true" ValidateRequest="false" %>
<%@ Import Namespace="System.Collections.Generic" %>
<%@ Import Namespace="System.IO" %>
<%

    string data = KH_Template.Util.GetData();

    Response.Write(data);

%>