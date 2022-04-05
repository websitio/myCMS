<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UIcontent.ascx.cs" Inherits="Controls_UIcontent"  %>

<script src="findDOM.js"></script>

<script>
  // MY script below

function setVisibility(objectID,state) 
{var dom = findDOM(objectID,1);
dom.visibility = state;}
		
		 var tState = 0;
	
//	      var tranState =0;

	      var tranState = 0;
function fnToggle() {    oTransContainer.filters[0].Apply();
    if (tranState=='0') {    tranState = 1;}
    else {  tranState = 0;}
        oTransContainer.filters[0].Play();}
                </script>
                

<script>     // this is the code window zoom
mag = new Array("5","10","15","20","25","30","35","40","45","50","55","60","65","70","75","80","85","90","95","100")
 magindex1 = 0
		
		function zoomer1(objectID) {
		
		objectID.style.zoom = mag[magindex1]+'%';
if(magindex1 <=18) {magindex1 = (magindex1 +1) % mag.length;}
else {return; }}

	function zoompart1()   { 
	Div1blue.style.visibility="visible";
	CodeDiv.style.visibility="visible";
	setInterval("zoomer1(CodeDiv)",10) }
	
	function zoomer2(objectID2)   { 
	objectID2.style.visibility="visible";
    setInterval("zoomer1(objectID2)",15) }
	
//extra for contact control

	function zoompart1c()   { 	part1.style.visibility="visible"; 	setInterval("zoomer1(part1)",15) }
	function pushoffBushc() { 	part1.style.visibility="hidden";	magindex1 = 0; }	

</script>


<script id="Calculate" type="text/javascript">

function showcalc() {
CalcPanel.style.visibility="visible";
CalcPanel.style.zIndex="42000";
CalcPanel.style.cursor="images\myfinger.ico"; 
}

// make the searhc box flah a bit
function GoLightBlue() { pic_RememberThisPage.style.backgroundColor = "#99FF66"; }
function GoDarkerBlue() { pic_RememberThisPage.style.backgroundColor = "#FFFF00"; }

function oscillateBlues()
{ setTimeout("GoLightBlue()", 3000); setTimeout("GoDarkerBlue()", 3200); }

function BeginFind() { setInterval("oscillateBlues()", 4000); }

</script>




<asp:ScriptManager ID="ScriptManager1" runat="server">
	
    </asp:ScriptManager>
		








    <div id="ArticleTitle" style="z-index: 9101; left: 226px; position: absolute; 
                height: 41px;  text-align:center;
                top: 134px; width: 545px;">	
            <asp:label id="lblTitle" 
                
		        runat="server" CssClass="txtb" EnableViewState="False" 
                ToolTip="Current Title   ...(from  category above)" Font-Size="27px">Title
         
             </asp:label>
        </div>
  
  
    
    <asp:label id="Label1" 
    style="z-index: 102; left: 1034px; position: absolute; top: 147px" runat="server"
		Visible="False">Map</asp:label>
	
	
	
	
	
	<%--▄▄▄ This is the div that holds the left verticle column of article text   🟥--%>
	<div style="position: absolute; 
                        z-index: 10000; 
                        width: 300px; 
                        font-size: 16px;  
                        line-height:27px;
                        font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
                 
                        left: 155px;
                        top: 234px; 
                        height: 20px;">       
        
                     <asp:literal id="Literal1" runat="server"></asp:literal>
		 </div>



	<div style="z-index: 105; 
	    top: 203px; 
	    left: 545px; width: 276px; position: absolute;  height: 20px" 
         id="Divplaceholder2" runat="server">
		 
		            <asp:placeholder id="PlaceHolder2" runat="server"></asp:placeholder>
		 </div>
		 
	<asp:Label id="lblTitle2" 
    style="z-index: 106; left: 529px; position: absolute; top: 26px" width="246px" 
    runat="server" Visible="False" EnableViewState="False">Title</asp:Label>
		
	<div style="z-index: 1107; left: 516px; width: 286px; position: absolute; 
                    font-size: 16px;  
                    line-height:27px;
                    font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;

	    top: 296px; height: 100px" 
        id="column2txt" runat="server">
        
		        <asp:Literal id="Literal2" runat="server"></asp:Literal>
		</div>
		
	
	
	
		
 <%--  <div  runat="server"  id="addsright" 
        style="z-index: 9999; left: 557px; position: absolute; top: 211px; width:132px; height: 675px; font-size: 9pt; color: #00cc00; font-family: Arial;" 
        visible="true">
        
       <script type="text/javascript"><!--
    google_ad_client = "pub-7384359056018693";
    /* 160x600, created 10/05/10 */
    google_ad_slot = "1165438632";
    google_ad_width = 130;
    google_ad_height = 600;
//-->
</script>
<script type="text/javascript"
src="http://pagead2.googlesyndication.com/pagead/show_ads.js">
</script>

</div>--%>

<%--
            <div  id="addsbot" runat="server" style="FONT-SIZE: 8pt; z-index: 9999; 
                left: 342px; width: 166px; position: absolute; 
                top: 161px; height: 647px" visible="true">
            <script type="text/javascript"><!--
                google_ad_client = "pub-7384359056018693";
                /* 2011p1 */
                google_ad_slot = "1165438632";
                google_ad_width = 130;
                google_ad_height = 600;
                    //-->
                    </script>
                    <script type="text/javascript" src="http://pagead2.googlesyndication.com/pagead/show_ads.js">
                    </script>
        
            </div>

           --%>
            
            
            
            
            


            <a href="http://www.cafeflorin.com/CheapestDealsToGranCanaria_12_164.aspx">
            <img src="http://www.cafeflorin.com/img/YellowBird-Discount-Gran-Canaria.jpg" 
                    alt="Starting May 1st 2011 - YellowBird Discount free when you reserve you holiday accommodation here" 
                
                
                
                style="position:absolute; top:2028px; left:665px; height: 73px; width: 95px; z-index:98765; visibility: hidden;" 
                class="whiteside"/>
            </a>

                            
            
            <div id="UIbase" style="position: absolute; border-right: #0066ff 2px; border-top: #000000 4px; border-left: #000000 2px;
                z-index: 999; left: 142px;  
                width: 700px;  
                top: 194px; 
                height: 876px; 
                font-size: 12pt;" 
	             >
                &nbsp;
	
		<div>
	<asp:label id="Title" 
        style="z-index: 2006; left: 54px; position: absolute; 
                top: -136px; 
                width: 486px; 
                margin-bottom: 0px; 
                background-color:aqua" 
        runat="server" 
        CssClass="pageTitle" 
        BackColor="Transparent" 
        EnableViewState="False" 
        ToolTip="Current Category">pageTitle</asp:label>
        
   <%--     <asp:label id="TitleShadow" 
        style="z-index: 2000; left: -2px; 
        position: absolute; 
        top: 4px; 
        width: 486px;" 
        runat="server" 
        CssClass="pageTitleShadow" 
        BackColor="Transparent" 
        EnableViewState="False" ToolTip="Current Category">pageTitle</asp:label>--%>
        </div>
           			
	</div>      
	






<div id="addmsg" style="font-weight: normal; 
    z-index: 1000; 
    left: 862px; 
    width: 94px; color: #ff3333; font-family: Arial; position: absolute; 
    top: 0px; height: 16px; font-size: 8pt; 
    visibility: hidden;" title="bookmark">
 updated today </div>

<asp:Image ID="ifolder1" ImageUrl="..\images\PDA.gif"   
style="z-index: 3002; 
    left: 139px; 
    position: absolute; 
    top: 2061px" runat="server" Visible="False" 
    Height="16px" width="16px" Title="Bungalows MAspalomas" 
    EnableViewState="False" />
       
              
      <div id="MoreTitles-counter" style="left:717px; 
          position: absolute; visibility:hidden;
          top: 150px; 
          font-size:x-small;
          z-index: 29999; 
          background-color: #FFFFFF; width: 87px;" 
    title="5 Gay Radio Stations, Tips to speak Spanish, Flight Arrivals - Departures realtime, how to make cheap telephone calls, where to find cheapest Wifi and more useful stuff you might need when you are in Gran Canaria" 
    class="txt8"; >
    <a href="#Icon_labels">
     
    <asp:Label ID="Label2" 
    runat="server" 
    CssClass="txt8" 
    
    Text=" " 
    Font-Size="7" 
    ForeColor="DarkBlue">
    </asp:Label>
     more here...
    </a>
    </div>


<a href="http://www.cafeflorin.com/webcrawler.aspx">
</a>&nbsp;<a href="http://www.ryanair.com" target="_new" class="whiteside">
        </a>
        

              
              
              
              <asp:Label ID="Catlabel" runat="server" Text="CatLabel"  
    style="z-index: 992006; 
                  left: 827px; 
                  position: absolute; 
                  top: 141px; 
                  width: 119px; height: 43px;" 
    CssClass="txtbb" BackColor="White" BorderColor="#000099" 
    BorderStyle="None" ForeColor="#FF6600"></asp:Label>

                    <div id="adiv" runat="server"  
                    style="z-index: 2007; 
                        left: 1000px;
                        top: 100px;
                       position: absolute;  background-color: #99cc66; 
                       width: 22px; height: 22px; 
                       visibility: hidden;">
                       
                       </div>


    
    
    
   
        

<%--<div id="SkyScraperAd" style="position:absolute; z-index:7855;
    top:1336px; 
    left:344px; 
    width:120px;
    height:610px" >

<script type="text/javascript"><!--
    google_ad_client = "pub-7384359056018693";
    /* MySkyScraperType created 20/01/10 */
    google_ad_slot = "0023047654";
    google_ad_width = 120;
    google_ad_height = 600;
//-->
</script>
<script type="text/javascript"
src="http://pagead2.googlesyndication.com/pagead/show_ads.js">
</script>



</div>--%>



  <div id="Line1"     
    
    style="border-top: 1px solid #FFDE59; position: absolute; 
    z-index: 99102; 
    left: 162px; 
    width: 771px;  
    top: 121px; 
    height: 2px; 
    font-family: Verdana; 
    font-size: 9px; 
    font-weight: normal; border-bottom-style: none; " >


</div>

    
    


    
   
    
   
    
    
    
  
    
    
       
    
    
    
    
    
    
    

    
    
    <div id="pic_holAccom"
       
    style="position: absolute; z-index: 99102; 
    top: 2302px; 
	left: 469px; 
	height: 27px; 	
	width: 123px;  
	
	font-family: Verdana;     font-size: 14px;     
	font-weight: normal;  text-align: center; vertical-align: middle; visibility: hidden;" >
    
<asp:Image ID="picHolidayAccom" runat="server"  AlternateText="Our Holiday Bungalows range, location, prices and discount scheme means you get the best deal for any budget" />


</div>



















<div id="pic_NoBookFee"
    
    style="position: absolute; z-index: 99102; 
    top: 2174px; 
    left: 381px; 
	height: 19px; 	
	width: 145px;  
	font-family: Verdana;     font-size: 14px;     
	font-weight: normal;  text-align: center; vertical-align: middle; visibility: hidden;" >
    
<asp:Image ID="picNoBookFee" runat="server" />
</div>







      <div id="BEST-PRICE-NOW-CLICK-HERE"
    
    
    
    
    style="position: absolute; z-index: 99102; 
    top: 2132px; 
	left: 244px; 
	height: 14px; 	
	width: 162px;  
	
	font-family: Verdana;     font-size: 8px;     
	font-weight: normal;  text-align: center; vertical-align: middle; text-decoration: underline blink; visibility: hidden;" >
         <asp:Label ID="uno_BestPrice" runat="server"  
         Text="Click below to Book" Font-Size="9px" Font-Bold="False" ></asp:Label>
     
    </div>
    
    
    


<div id="pic_RememberThisPage" style="z-index: 998777; 
            left: 9px; 
            width: 64px; 
            position: absolute; 
            top: 36px; 
            height: 19px; background-color: #FFFFFF;" 
             title="Link to this Page - Click to remember this page and add it to your bookmarks">
            <asp:Image ID="picRememberThisPage" runat="server" />
            </div>
            
            
            
            
            
    
<%--    Search Box Searchbox butoon search button--%>
    

	 
    
    
    
    
    
       
   
    
    
            

    
    

     
     

       
       
       
         

       
       
       
   
    


       
         
     
