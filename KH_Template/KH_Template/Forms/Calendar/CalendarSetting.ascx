<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CalendarSetting.ascx.cs" Inherits="KH_Template.Forms.Calendar.CalendarSetting" %>
<script  type="text/javascript" src="Components/Calendar/js/jquery.datetimepicker.min.js"></script>
<link    href="Components/Calendar/css/jquery.datetimepicker.css" rel="stylesheet" type="text/css">

<script>
    $(function () {
        $("#<%=dateStart.ClientID%>").datetimepicker({
            format: 'Y-m-d. H:i',
            timepicker: true,
            validateOnBlur: false,
            onShow: function (ct) {
                this.setOptions({
                    maxDate: $("#<%=dateEnd.ClientID%>").val() ? $("#<%=dateEnd.ClientID%>").val() : false,
                })
            }
        });
        $("#<%=dateEnd.ClientID%>").datetimepicker({
            format: 'Y-m-d. H:i',
            timepicker: true,
            validateOnBlur: false,
            onShow: function (ct) {
                this.setOptions({
                    minDate: $("#<%=dateStart.ClientID%>").val() ? $("#<%=dateStart.ClientID%>").val() : false
                })
            }
        });
    });
  </script>
<section class="box">
                                <h3>Add an Event</h3>
									<div class="row uniform 50%">
										<div class="6u 12u(3)">
											<input type="text" runat="server" id="txtTitle" value="" placeholder="Title" />
										</div>
										<div class="6u 12u(3)">
											<input type="text" runat="server" id="txtDesc" value="" placeholder="Desc" />
										</div>
									</div>
									<div class="row uniform 50%">
										<div class="12u">
											<div class="select-wrapper">
												<select name="category" runat="server" id="drpTypes">
													
												</select>
											</div>
										</div>
									</div>
									
									<div class="row uniform 50%">
										<div class="9u 12u(3)">
                                            <div class="hide"><asp:FileUpload ID="fileUpload" runat="server" onchange="document.getElementById('<%= txtFile.ClientID %>').value = this.value;" /></div>
											<input type="text" id="txtFile" readonly="readonly" runat="server" value="" placeholder="URL of the picture" />
										</div>
										<div class="3u 12u(3)">
											<input type="button" value="Browse" onclick="document.getElementById('<%= fileUpload.ClientID %>').click();" class="fit" />
										</div>
									</div>
									<div class="row uniform">
										<div class="6u">
											<p>Start Date: <input type="text" runat="server"  id="dateStart"></p>
										</div>
                                        <div class="6u">
											<p>End Date: <input type="text"  runat="server"  id="dateEnd"></p>
										</div>
									</div>
									<div class="row uniform">
										<div class="12u">
											<ul class="actions">
												<li><asp:Button ID="btnAdd" CssClass="button" runat="server" Text="Add" OnClick="btnAdd_Click" /></li>
												<li><input type="reset" value="Clear" class="alt" /></li>
											</ul>
										</div>
									</div>
                                    
								<hr />
							</section>