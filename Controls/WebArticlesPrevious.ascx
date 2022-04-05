<%@ Control Language="C#" AutoEventWireup="true" CodeFile="WebArticlesPrevious.ascx.cs" Inherits="Controls_WebArticlesPrevious" %>

<script type="text/javascript">
			var open = 0;
			var slideDelay = 2;
			var domStyle = null;
					
			function setMenu (objectID) {
			if (isDHTML){
				domStyle = findDOM(objectID,1);
				if (open) { fX = -330; cX = 0; open = 0; }
					else { fX =130; cX = -50; open = 1; }
				slideMenu(cX,fX);
			}
		}	
		
		function slideMenu (cX,fX) {
			if (cX != fX) {
				if (cX > fX) { cX -= 10; }
				else { cX += 10; }
				domStyle.left = cX;
				
				setTimeout('slideMenu(' + cX + ',' + fX + ')', slideDelay);  
							
			}
			return
		}
</script>


<atlas:ScriptManager ID="s1" EnablePartialRendering="true" runat="server" />
	<atlas:ProfileScriptService runat="server" ID="profileservice" AutoSave="true" />
<div id="mainMenu" style="border-right: #000099 1pt solid; border-top: #000099 1pt solid; 
z-index: 19009; 
left: -327px; 
border-left: #000099 1pt solid; width: 362px; border-bottom: #000099 1pt solid; position: absolute; 
top: 1423px; 
height: 238px; background-color: #ffffff" moveable="true">

<A href="javascript:setMenu('mainMenu')">
<img id="pic" title="Previous Articles from this Category" style="z-index: 18002; border-left-color: #ffffff; 
    left: 330px; border-bottom-color: #ffffff; border-top-STYLE: solid; border-top-color: #ffffff; border-right-STYLE: solid; border-left-STYLE: solid; 
    position: absolute; 
    top: 36px; border-right-color: #ffffff; border-bottom-STYLE: solid; 
    height: 146px;" alt="" src="images\link2articles.gif" width="16" /> 
    </A>
    <asp:Panel runat="server" id="oldtitles" >

		<div id="Search" style="z-index: 18000; 
		    left: 0px; position: absolute; 
		    top: 6px; border-right: #000099 2px; 
		border-top: #000099 1px; border-left: #000099 1px; border-bottom: #000099 1px; background-color: #ffffff; width: 357px;
		 height: 186px;" title="Previous articles" >
		 <div style="z-index: 3000; left: 219px; width: 108px; position: absolute; top: 28px;
          height: 16px" title="Newest first, Oldest last!">
        <asp:Label ID="Label1" runat="server" Text="Label" width="105px"></asp:Label>
        </div>
        <atlas:UpdatePanel ID="ps" runat="server" >
		<ContentTemplate>
			
    <asp:GridView ID="GridView1" runat="server"  AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowDataBound="GridView1_RowDataBound" AutoGenerateColumns="False" CellPadding="1" PageSize="7" width="327px">
        <Columns>
        <asp:TemplateField HeaderText="Previous Pages from" >
        <ItemStyle width="325px"  Font-Size="10px" Wrap="False" HorizontalAlign="Center" />
        <ItemTemplate><asp:HyperLink ID="hyp1" width="325px"  NavigateUrl='<%# Bind("WebArtLink") %>' runat="server" Text='<%# Bind("title") %>'  BorderStyle="Solid" Borderwidth="1" BorderColor="MidnightBlue" />   
        </ItemTemplate>
        <HeaderStyle Font-Size="10px" Height="10px" Font-Bold="True" />
        <ControlStyle BackColor="GhostWhite" Font-Size="11px"  BorderStyle="None"  Font-Bold="False" />
            
          </asp:TemplateField>
            
                <asp:BoundField DataField="WebArtID" Visible="False" />
         
        </Columns>
    
        <PagerSettings Position="Top"  />

        <PagerStyle BackColor="White" Font-Names="Arial" Font-Size="8px" ForeColor="LightBlue" Height="8px" HorizontalAlign="left" VerticalAlign="Bottom"   
        CssClass="bluemix"  Font-Bold="True" />
        <RowStyle BorderStyle="Solid" BorderColor="White" Borderwidth="1px" />
        <SelectedRowStyle ForeColor="Yellow" />
    </asp:GridView>
          
	</ContentTemplate>
		</atlas:UpdatePanel>
            &nbsp; &nbsp;&nbsp; <span style="color: #ffffff">(Not just for bitch boys)</span>
		</div>
				
		</asp:Panel>
		</div>
		
		<atlas:DragOverlayExtender ID="extender1" runat="server" >
		<atlas:DragOverlayProperties Enabled="false" TargetControlID="oldtitles"  ProfileProperty="panelLocation" />
		</atlas:DragOverlayExtender>

				