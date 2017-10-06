<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GallerySetting.ascx.cs" Inherits="KH_Template.Forms.Gallery.GallerySetting" %>
<div class="row">
					<div class="12u">
						
						<!-- Form -->
							<section class="box">
                                <h3>Add an Item</h3>
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
										<div class="12u">
											<ul class="actions">
												<li><asp:Button ID="btnAdd" CssClass="button" runat="server" Text="Add" OnClick="btnAdd_Click" /></li>
												<li><input type="reset" value="Clear" class="alt" /></li>
											</ul>
										</div>
									</div>
								<hr />
							</section>

                        <section class="box">
                                <h3>Delete an Item</h3>
                                <asp:Repeater runat="server" ID="rptGallery">
                                    <ItemTemplate>
                                            <div class="Gcontainer">
                                                <img class="imgGallery" src="ImageViewer.aspx?FileName=<%# Eval("URL") %>" />
                                                 <div class="middle">
                                                <asp:Button ID="btnDelete" CssClass="alt"  CommandName='<%# Eval("ID")%> ' runat="server" Text="Delete" OnClick="btnDelete_Click" />
                                             </div>   
                                            </div>
                                            
                                    </ItemTemplate>
                                    
                                </asp:Repeater>
                            </section>

					</div>
				</div>
				
