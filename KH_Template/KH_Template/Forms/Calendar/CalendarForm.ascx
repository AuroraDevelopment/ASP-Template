<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CalendarForm.ascx.cs" Inherits="KH_Template.Forms.Calendar.CalendarForm" %>
<%--<link    href="Components/Calendar/css/calendar.css" rel="stylesheet" type="text/css">--%>
<link    href="Components/Calendar/css/helpDatepicker.css" rel="stylesheet" type="text/css">
<link    href="Components/Calendar/css/jquery-ui-1.10.3.custom.css" rel="stylesheet" type="text/css">
<link    href="Components/Calendar/css/lugo.datepicker.css" rel="stylesheet" type="text/css">
<script  type="text/javascript" src="Components/Calendar/js/jquery.ui.core.js"></script>
<script type="text/javascript">
    jQuery.browser = {};
    (function () {
        jQuery.browser.msie = false;
        jQuery.browser.version = 0;
        if (navigator.userAgent.match(/MSIE ([0-9]+)\./)) {
            jQuery.browser.msie = true;
            jQuery.browser.version = RegExp.$1;
        }
    })();
</script>
<script  type="text/javascript" src="Components/Calendar/js/jquery.ui.datepicker.min.js"></script>
<script  type="text/javascript" src="Components/Calendar/js/Common.js"></script>
<div id="current" class="divDatePicker ll-skin-latoja"></div>        
<style>
    #current{
        width:500px;
        margin-left:auto;
        margin-right:auto;
    }
</style>
 <script type="text/javascript">
     $(document).ready(function () {
         var smallcalendar = new SmallCalendar('divDatePicker', 'divCalendarList');
     });
</script>