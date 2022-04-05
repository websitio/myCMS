<%@ Page Language="C#" MasterPageFile="~/CF-MasterPage.master" AutoEventWireup="true" CodeFile="Web.aspx.cs" Inherits="Web" Title="Cafe Florin Web" UICulture="auto" Culture="auto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

   
    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>



<asp:Label ID="Label1" runat="server" Text="Page Details" 
        style="z-index: 104; left: 911px; position: absolute; top: 1px; height: 36px;" 
        Visible="False"></asp:Label>

    <script type="text/javascript">
        function Gored() { CafeFlorinAddressDirection.style.borderColor = "#FF0000"; }
        function GoOrange() { CafeFlorinAddressDirection.style.borderColor = "#FF9900"; }                         
        function oscillate() 
         {setTimeout("Gored()", 3000); setTimeout("GoOrange()", 3200);   }

         function Begin() { setInterval("oscillate()", 4000);    }
    
    
    </script>
    
        
    <table id="TopMenuTable"  style="
        top: 70px; 
        left: 168px; 
        position: absolute; 
        z-index: 99002; height: 22px; width: 643px;">
    
               
               <tr id="MenuTops" 
                   title="Points of Interest in the Canary Islands">
               <td> 
               
                  <asp:HyperLink ID="MenuLink1" runat="server" 
                  
                    NavigateUrl="How-to-find-Cafe-Florin-in-Playa-del-Ingles-Maspalomas._1_49.aspx" 
                    
                    CssClass="iconbar" Font-Size="14px">Points of Interest </asp:HyperLink> 
                   
                    </td>
                    
               <td title="Places to Stay that more than tick boxes"> 
                      <asp:HyperLink ID="MenuLink3" runat="server" 
                      
                NavigateUrl="Connect-to-the-Internet-with-low-cost-WiFi-Network-hotspots-in-Playa-del-Ingles_4_45.aspx" 
                CssClass="iconbar" Font-Size="14px">Places to Stay </asp:HyperLink>
                 </td>
                 
               <td title="No need to worry about missing anything, its all here">
                        <asp:HyperLink ID="MenuLink4" runat="server" 
                     NavigateUrl="Cheapest-telephone-call-tariffs-to-U.K-just-1-minute-from-the-Yumbo-Entrance_5_62.aspx" 
                     CssClass="iconbar" Font-Size="14px"> Events </asp:HyperLink>
               </td>       
               
               <td title="Everything you'd expect to be able to find and all sorts of unexpected stuff">
                   <asp:HyperLink ID="MenuLink10" runat="server" 
                    NavigateUrl="Check-in-and-print-your-boarding-pass-in-Maspalomas-at-Cafe-Florin_11_114.aspx" 
                    CssClass="iconbar" Font-Size="14px"> Resources </asp:HyperLink>
                             
                 </td>
                     
               <td title="No match for social media or search engines,   "> 
                        <asp:HyperLink ID="MenuLink5" runat="server" 
                        NavigateUrl="Food-and-Drinks-menu-Cafe-Florin-2011-Playa-del-Ingles-Maspalomas-Gran-Canaria_6_412.aspx" 
                        CssClass="iconbar" Font-Size="14px"> People and Messaging </asp:HyperLink>
                </td>
                            
                    
                    </tr>
             </table>
    

<%--    
    --%>
  
 
            <div style="z-index: 2006; left: 1150px; width: 257px; position: absolute; top: 209px; height: 175px; background-color:indianred">
            <asp:PlaceHolder ID="PlaceHolder2" runat="server">
            </asp:PlaceHolder>
            </div>



    <div id="Repeater_TitlesThisCategory" style=" position: absolute;z-index: 1002; 
                     width: 134px; height: 862px;
                    padding: 1px;    
                    top: 325px; 
                    left: 823px">
                   <asp:Repeater ID="Repeater2" runat="server" >
                    <ItemTemplate><br />
                   
                    <div>
	                <asp:HyperLink id="hp2"  
	                    onmouseover="this.style.backgroundColor='FFFFCC';
	                    this.style.color='000099';
	                    this.style.textDecoration='underline'"
	                    onmouseout="this.style.backgroundColor=''; this.style.textDecoration='';this.style.color='0000FF';"
	                    Text='<%# DataBinder.Eval(Container.DataItem, "Title") %>' 
	                    ToolTip='<%# DataBinder.Eval(Container.DataItem, "TitleToolTip") %>'
	                    NavigateUrl='<%# DataBinder.Eval(Container.DataItem, "WebArtLink")  %>' 
	                    runat="server" 	
	                    Font-Bold="True" 	
	                    ForeColor="Blue" 	
	                    Font-Size="11px" 
	                    width="116px" 
	                    CssClass="sale2" BackColor="yellow"> 
	    
	      </asp:HyperLink>  <br/>
    	</div>
		    
		    <asp:Label ID="x2_ArtIntro"
	    Text='<%# DataBinder.Eval(Container.DataItem, "WebArticle") %>'
	    runat="server"
		    Font-Bold="false" 	
		    ForeColor="Black" 	
		    Font-Size="11px"
		     ToolTip='<%# DataBinder.Eval(Container.DataItem, "WebArticleToolTip") %>'
    	 	width="116px"> 
		    </asp:Label>
	    <br />
    	
    	  <asp:Label ID="Label2"
	    Text='<%# DataBinder.Eval(Container.DataItem, "ArtDate") %>'
	    runat="server"
		    Font-Bold="false" 	ForeColor="Black" 	Font-Size="10px"> </asp:Label>
	    <br />
    	
	    </ItemTemplate> 
        </asp:Repeater>
    </div>


    </asp:Content>

    <asp:Content ID="Content2" runat="server" contentplaceholderid="head">

        <style type="text/css">
            .style72
            {
                text-align: center;
                width: 127px;
                height: 15px;
            }
                    
    </style>


</asp:Content>


