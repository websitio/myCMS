<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Menu.ascx.cs" Inherits="Controls_Menu"  %>
	
<div style="z-index: 1000; left:4px; width: 728px; position: absolute; 
top: 304px; height: 855px; background-color: transparent">
	
	
	<div style="
	z-index: 102; position: absolute;
	left: 12px; 
	width: 134px; 
	top: 0px; 
	height: 106px;" 
   title="View most recet article on selected Topic" >
	<asp:repeater id="Repeater1" runat="server">
			<ItemTemplate>
			<%--
			 <div id="repmenu"  class="menu1"
     onmouseover="this.className = 'menu2'" 
     onmouseout="this.className='menu1'"  >--%>
	 		
				<asp:HyperLink id="hp1" 
				Text='<%# DataBinder.Eval(Container.DataItem, "CategoryName") %>' 
				NavigateUrl='<%# DataBinder.Eval(Container.DataItem, "url") %>'
					ToolTip='<%# DataBinder.Eval(Container.DataItem, "Tooltip") %>'
				runat="server" 
				
				Height="14px" 
				BorderStyle="Solid" 
				BorderColor="#ffffff" 
				Borderwidth="0"
				Font-Size="12px"
				>
				</asp:HyperLink><br />
				
			<%--	</div>--%>
				</ItemTemplate>
		</asp:repeater>
		</div>
</div>


<div id="ptBung" style="position:absolute;
        top:5154px; 
        left:239px; width: 310px;">
         <asp:ImageMap ID="ImageMapAccomm" ImageUrl="/images/4Accomm/ptAccommodation.png" runat="server">
        <asp:RectangleHotSpot
                                hotspotmode="Navigate"
                                NavigateUrl="/Holiday-Apartments-to-Rent---Playa-del-Ingles_16_421.aspx"
                                alternatetext="Apartments to stay in Playa del Ingles and Maspalomas"
                                top="0"
                                left="0"
                                bottom="32"
                                right="104" >
                                </asp:RectangleHotSpot>


                <asp:RectangleHotSpot
                                hotspotmode="Navigate"
                                NavigateUrl="/Bungalows---Playa-del-Ingles-and-Maspalomas_17_420.aspx"
                                        alternatetext="Bungalows to stay in Playa del Ingles and Maspalomas"
                                
                                top="0"
                                left="106"
                                bottom="32"
                                right="208">
                                </asp:RectangleHotSpot>

                <asp:RectangleHotSpot
                                hotspotmode="Navigate"
                                NavigateUrl="/Holiday-Hotels-Playa-del-Ingles-Maspalomas_18_422.aspx"
                                        alternatetext="Hotels to stay in Playa del Ingles and Maspalomas"
                                
                                top="0"
                                left="210"
                                bottom="32"
                                right="310">
                                </asp:RectangleHotSpot>

                </asp:ImageMap>
     
        </div>