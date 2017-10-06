<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="KH_Template.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <header>
					<h2>Contact Us</h2>
					<p>Tell us what you think about our little operation.</p>
				</header>
				<div class="box">
						<div class="row uniform 50%">
							<div class="6u 12u(3)">
								<input type="text" name="name" id="name" value="" placeholder="Name" />
							</div>
							<div class="6u 12u(3)">
								<input type="email" name="email" id="email" value="" placeholder="Email" />
							</div>
						</div>
						<div class="row uniform 50%">
							<div class="12u">
								<input type="text" name="subject" id="subject" value="" placeholder="Subject" />
							</div>
						</div>
						<div class="row uniform 50%">
							<div class="12u">
								<textarea name="message" id="message" placeholder="Enter your message" rows="6"></textarea>
							</div>
						</div>
						<div class="row uniform">
							<div class="12u">
								<ul class="actions align-center">
									<li><input type="submit" value="Send Message" /></li>
								</ul>
							</div>
						</div>
				</div>
</asp:Content>
