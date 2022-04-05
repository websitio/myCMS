<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Editor.aspx.cs" 
Inherits="Editor"  
UICulture="auto" 
Culture="auto;en-US"  
ValidateRequest="false"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >

<script type="text/javascript">



function Clip() 
{
var b=document.getElementById("<%=TextBox1.ClientID %>");
holdtext.innerText=b.value;

alert(holdtext.innerText);
}

		function pushoffBush() {
		Div1blue.style.visibility="hidden";
		CodeDiv.style.visibility="hidden";	
		magindex1 = 0; }

		function loadRichEditor() 
		{
		  myEdit=window.open("http://www.gay-gran-canaria.com/EditorHTML.aspx", "myEdit", "location=1,status=1,scrollbars=1,width=300,height=600");
		}

</script>

     <script language="javascript" type="text/javascript">
<!--
         function pop(url) {
             mywindow = window.open("http://www.gay-gran-canaria.com/EditorHTML.aspx", 'mywindow', 'height=200,width=150');
             if (window.focus) { newwindow.focus() }
             return false;
         }
// -->
</script>


<script language="javascript" type="text/javascript">

    var remote= null;
    window.name = "content";


    function openRemote(contentURL, windowName, x, y) {
        widthHeight = 'height=' + y + ',width=' + x;
        remote = window.open(contentURL, windowName, widthHeight);
        
    }

    function closeRemote() {
        if (remote != null) {
            remote.close();
            remote = null;
        }
    }


// -->
</script>






<head runat="server">
    <title>CF Editor</title>
   <link href="cms.css" type="text/css" rel="stylesheet"> 
   
</head>
<body>
    <form id="form1" runat="server">
    
  <img src="http://www.cafeflorin.com/img2/editorBCK.jpg" 
        style="position:absolute; top:167px; left:124px; width:740px" alt="" />
  
        
        
    <div>
  <div id="tb1"  style="font-size: 9pt; left: 4px; color: #330099; 
      font-family: Arial; position: absolute; top: 66px; width: 245px; height: 26px;">
    
    <asp:TextBox ID="TextBox1" runat="server" ForeColor="Navy"></asp:TextBox>
   
     <asp:Label ID="LabelSearch" runat="server" Text="Label" 
     width="40px" meta:resourceKey="LabelSearch" Height="16px" ></asp:Label>
     <br />
     
      <asp:Label ID="lblMssg" runat="server" Text=""></asp:Label>
      </div>
      
      
      
      
      
      
      
 

      
      
      
      
      
      
       <div id="HTMLeditor" 
    style="position: absolute; 
        left:  16px;
        top: 123px; 
        width:151px;
        height:20px;
        color: #330099; 
        font-family: Arial">
      
      <a href="javascript:openRemote('http://www.gay-gran-canaria.com/EditorHTML.aspx','remote',325,820)">Use HTML Text Editor</a>
     

   
   </div>
   
   
   
   
   
    <div id="DIVgridview" 
        style="left: 205px; position: absolute; top: 1px; width: 668px;">
       
         <asp:GridView ID="GridView1" runat="server" 
         AutoGenerateColumns="False" 
         DataKeyNames="WebArtID"
            DataSourceID="ObjectDataSource1" 
            AllowPaging="True" 
            PageSize="5" width="639px">
            <Columns>
                <asp:TemplateField HeaderText="Title" SortExpression="Title">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" 
                        Text='<%# Bind("Title") %>' width="475px"></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" 
                        Text='<%# Bind("Title") %>' width="520px"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="CategoryID" HeaderText="CatID" 
                SortExpression="CategoryID" />
                <asp:BoundField DataField="WebArtID" 
                HeaderText="ArtID" InsertVisible="False"
                    ReadOnly="True" SortExpression="WebArtID" />
            </Columns>
        </asp:GridView>
       
       </div>
       
        
        <asp:ObjectDataSource ID="ObjectDataSource1" 
        runat="server" DeleteMethod="Delete"
            InsertMethod="Insert" 
            OldValuesParameterFormatString="original_{0}" 
            SelectMethod="FetchArticlesByID"
            TypeName="_2008TableAdapters.WebArticle07_CFcomTableAdapter" 
            UpdateMethod="Update">
            <DeleteParameters>
                <asp:Parameter Name="Original_WebArtID" Type="Int32" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="CategoryID" Type="Int32" />
                <asp:Parameter Name="WebArticle" Type="String" />
                <asp:Parameter Name="WebArticle2" Type="String" />
                <asp:Parameter Name="Title" Type="String" />
                <asp:Parameter Name="codeinc" Type="String" />
                <asp:Parameter Name="hasCode" Type="String" />
                <asp:Parameter Name="Code" Type="String" />
                <asp:Parameter Name="picture" Type="String" />
                <asp:Parameter Name="ImageContent" Type="Object" />
                <asp:Parameter Name="Original_WebArtID" Type="Int32" />
            </UpdateParameters>
            <SelectParameters>
                <asp:ControlParameter ControlID="TextBox1" Name="Title" 
                PropertyName="Text" Type="String" />
            </SelectParameters>

            <InsertParameters>
                <asp:Parameter Name="CategoryID" Type="Int32" />
                <asp:Parameter Name="WebArticle" Type="String" />
                <asp:Parameter Name="WebArticle2" Type="String" />
                <asp:Parameter Name="Title" Type="String" />
                <asp:Parameter Name="codeinc" Type="String" />
                <asp:Parameter Name="hasCode" Type="String" />
                <asp:Parameter Name="Code" Type="String" />
                <asp:Parameter Name="picture" Type="String" />
                <asp:Parameter Name="ImageContent" Type="Object" />
            </InsertParameters>
        </asp:ObjectDataSource>
       
       
        
       <div id="DIVdetailsView" style="left: 3px; 
           position: absolute; 
           top: 234px; width: 145px; height: 64px;"> 
      
       
        <asp:DetailsView ID="DetailsView1" runat="server" 
        Height="50px" width="228px" AllowPaging="True" 
        AutoGenerateRows="False" DataKeyNames="WebArtID" 
        DataSourceID="ObjectDataSource1">
            <Fields>
                <asp:TemplateField ShowHeader="False">
                    <EditItemTemplate>
                        
                        <asp:LinkButton ID="LinkButton1" runat="server" 
                        CausesValidation="True" 
                        CommandName="Update"
                            Text="Update" >
                            </asp:LinkButton>
                            
                        <asp:LinkButton ID="LinkButton2" runat="server" 
                        CausesValidation="False" CommandName="Cancel"
                            Text="Cancel">
                            </asp:LinkButton>
                            
                    </EditItemTemplate>
                    
                    <InsertItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" 
                        CausesValidation="True" 
                        CommandName="Insert"
                            Text="Insert">
                            </asp:LinkButton>
                            
                        <asp:LinkButton ID="LinkButton2" runat="server" 
                        CausesValidation="False" 
                        CommandName="Cancel"
                            Text="Cancel">
                            </asp:LinkButton>
                            
                    </InsertItemTemplate>
                    
                    <ControlStyle BorderStyle="Solid" Borderwidth="1px" 
                    CssClass="button" 
                    Font-Bold="True" />
                    
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" 
                        CausesValidation="False" 
                        CommandName="Edit"
                            Text="Edit">
                            </asp:LinkButton>
                        <asp:LinkButton ID="LinkButton2" runat="server" 
                        CausesValidation="False" 
                        CommandName="New"  Text="New"  meta:resourceKey="LinkButton2">
                        </asp:LinkButton>
                          
                        <asp:LinkButton ID="LinkButton3" runat="server" 
                        CausesValidation="False" 
                        CommandName="Delete"
                            Text="Delete" Visible="false">
                            </asp:LinkButton>
                    </ItemTemplate>
                    
                </asp:TemplateField>
               
                
                <asp:TemplateField SortExpression="Title">
                    <EditItemTemplate>
                        &nbsp;
                        <div id="DivEditTitle" style="left: 125px;
                             border-bottom-width: 1px; 
                             border-bottom-color: #3300cc; 
                             width: 500px; 
                             position: absolute; 
                             top: 49px; height: 27px; background-color: #ffffff">
                            
                            <asp:TextBox ID="TextBox1" runat="server" 
                            Text='<%# Bind("Title") %>' 
                            width="487px" CssClass="pageTitle" Height="20px">
                            </asp:TextBox>
                         </div>
                       
                        <div id="dIVeDITmODElABEL" style="left: 555px; 
                            width: 100px; 
                            position: absolute; top: 15px; height: 11px">
                            <strong>EDIT MODE</strong></div>
                    </EditItemTemplate>
                    
                    <InsertItemTemplate>
                        &nbsp;
                        <div id="DivInsertTitle" style="left: 150px; 
                            width: 466px; 
                            position: absolute; top: 50px;  height: 26px; 
                            background-color: #ffffff">
                          <asp:TextBox ID="TextBox1" 
                          runat="server" 
                          Text='<%# Bind("Title") %>' 
                          Height="19px" width="447px">
                          </asp:TextBox>
                          </div>
                    </InsertItemTemplate>
                   
                    <ControlStyle CssClass="active" />
                    <ItemTemplate>
                        &nbsp;
                        <div id="DivItemTitle" style="left: 150px; 
                            width: 450px; 
                            position: absolute; top: 50px;
                            height: 24px; border-right: #ffffff 5px solid; 
                            border-top: #ffffff 2px solid; 
                            border-left: #3300cc 1px solid; 
                            border-bottom: #3300cc 1px solid; 
                            background-color: #ffffff;">
                        &nbsp;  
                        
                        <asp:Label ID="Label1TITLE" 
                        runat="server" 
                        Text='<%# Bind("Title") %>' 
                        Height="22px" width="436px" CssClass="pageTitle">
                        </asp:Label>
                        </div>
                    </ItemTemplate>
                    
                    <HeaderStyle BorderStyle="None" Borderwidth="0px" />
                </asp:TemplateField>
                
               
                <asp:TemplateField SortExpression="WebArticle">
                    <EditItemTemplate>
                        &nbsp;
                        <div id="DivEditWebArt1" style="left: 113px; 
                            width: 283px; position: absolute; top: 77px;  
                            height: 578px;">
                          
                        <asp:TextBox ID="TextBox2" runat="server" Height="567px" 
                        Text='<%# Bind("WebArticle") %>'
                        TextMode="MultiLine" 
                        width="266px" CssClass="txt">
                        </asp:TextBox>
                        </div>
                    </EditItemTemplate>
                    
                    <InsertItemTemplate>
                        &nbsp;
                        <div id="DivInsertColumn1" style="left: 155px; 
                            width: 262px; 
                            position: absolute;    
                            top: 77px; 
                            height: 513px; 
                            background-color: #ffffff">
                        
                        <asp:TextBox ID="TextBox2" runat="server" 
                        Text='<%# Bind("WebArticle") %>' 
                        CssClass="txt" Height="503px" 
                        TextMode="MultiLine" width="244px">
                        </asp:TextBox>
                        </div>
                    </InsertItemTemplate>
                    
                    <ItemTemplate>
                        &nbsp;&nbsp;
                        <div id="Main-left-ColumnItem-Web-Art" style="border-right: #000099 1px dotted; 
                            padding-right: 2px;
                            border-top: #000099 1px dotted; 
                            padding-left: 2px; 
                            left: 152px; padding-bottom: 2px;
                            border-left: #000099 1px dotted; 
                            width: 273px; 
                            padding-top: 2px; 
                            border-bottom: #000099 1px dotted;
                            position: absolute; 
                            top: 79px; 
                            height: 546px; 
                            background-color: #ffffff">
                        
                        <asp:Label ID="Label2" 
                        runat="server" 
                        Text='<%# Bind("WebArticle") %>' 
                        Height="32px" width="270px">
                        </asp:Label>
                        </div>
                    </ItemTemplate>
                </asp:TemplateField>
              
             
                <asp:TemplateField  SortExpression="WebArticle2">
                    <EditItemTemplate>
                        &nbsp;
                        <div style="left: 433px; 
                            width: 300px; 
                            position: absolute; 
                            top: 77px; 
                            height: 570px; z-index: 5;" >
                            
                            <asp:TextBox ID="TextBox3" runat="server" 
                            Text='<%# Bind("WebArticle2") %>' 
                            TextMode="MultiLine"
                                width="260px" 
                                Height="559px" CssClass="txt">
                                </asp:TextBox>
                                </div>
                        <div style="width: 100px; height: 26px">
                        </div>
                    </EditItemTemplate>
                    
                    <InsertItemTemplate>
                        &nbsp;
                        <div id="DivInsertColumn2" style="left: 474px; 
                            width: 285px; 
                            position: absolute;
                            top: 83px; height: 484px">
                        <asp:TextBox ID="TextBox3" runat="server" 
                        Text='<%# Bind("WebArticle2") %>' 
                        Height="497px" 
                        TextMode="MultiLine" 
                        width="225px">
                        </asp:TextBox>
                        </div>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        &nbsp;
                        <div id="Main-Right-column" style="border-right: #0000ff 1px dotted; 
                            border-top: #0000ff 1px dotted; 
                            left: 484px;
                            border-left: #0000ff 1px dotted; 
                            width: 323px; border-bottom: #0000ff 1px dotted;
                            position: absolute; 
                            top: 79px; 
                            height: 546px; 
                            background-color: #ffffff">
                        <asp:Label ID="Label3" runat="server" 
                        Text='<%# Bind("WebArticle2") %>' 
                        BackColor="White" width="263px">
                        </asp:Label>
                        </div>
                    </ItemTemplate>
                </asp:TemplateField>
                
                <asp:TemplateField  SortExpression="CategoryID">
                    <EditItemTemplate>
                      <div id="DivInEditCatID" style="left: 70px; 
                          width: 59px; position: absolute; top: 208px;
                            height: 24px">
                        
                        <asp:TextBox ID="TextBox4" runat="server" 
                        Text='<%# Bind("CategoryID") %>' width="28px">
                        </asp:TextBox>
                        </div>
                       
                        <div style="width: 59px; height: 100px">
                        </div>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        &nbsp;
                        <div id="DivInsertCatID" style="left: 70px; 
                            width: 59px; position: absolute; top: 208px;
                            height: 24px">
                        <asp:TextBox ID="TextBox4" runat="server" 
                        Text='<%# Bind("CategoryID") %>' CssClass="fieldlbl" 
                        width="43px">
                        </asp:TextBox>
                        </div>
                        
                        <div style="width: 17px; height: 329px">
                        </div>
                    </InsertItemTemplate>
                   
                    <ItemTemplate>
                        &nbsp;
                        <div id="DivItemCatID" style="left: 76px; 
                            width: 80px; position: absolute; top: 208px;
                            height: 28px">
                            <asp:Label ID="Label4" runat="server" CssClass="fieldlbl" 
                            Height="14px" 
                            Text='<%# Bind("CategoryID") %>'
                            width="34px">
                            </asp:Label>
                            </div>
                        <div style="width: 46px; height: 100px">
                        </div>
                    </ItemTemplate>
              
                </asp:TemplateField>
               
                <asp:TemplateField  SortExpression="hasCode">
                    <EditItemTemplate>
                      <div id="DivIEdithasCode" style="left: 76px; 
                          width: 42px; position: absolute; top: 600px;
                            height: 21px;">
                        <asp:TextBox ID="TextBox5"  
                        width="16px" runat="server"  
                        Text='<%# Bind("hasCode") %>' 
                        CssClass="fieldlbl">
                        </asp:TextBox>
                   </div>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                      
                      <div id="DivInserthasCode" style="left: 76px; 
                          width: 42px; position: absolute; top: 600px;
                            height: 21px;">
                        <asp:TextBox ID="TextBox5" runat="server" 
                        Text='<%# Bind("hasCode") %>' 
                        CssClass="fieldlbl" width="16px">
                        </asp:TextBox>
                    </div>
                     </InsertItemTemplate>
                   
                    <ItemTemplate>
                        &nbsp;
                        <div id="DivItemhasCode" style="left: 76px; 
                            width: 42px; 
                            position: absolute; 
                            top: 600px;
                            height: 21px;">
                            <asp:Label ID="Label5" runat="server" 
                            CssClass="fieldlbl"  
                            Height="14px" 
                            Text='<%# Bind("hasCode") %>'
                                width="22px">
                                </asp:Label>
                                </div>
                                <div style="width: 46px; height: 100px">
                        </div>
                    </ItemTemplate>
                </asp:TemplateField>
                
               
                <asp:TemplateField  SortExpression="Code">
                    <EditItemTemplate>
                        &nbsp;<div style="width: 49px; 
                                  height: 834px; border-right: #ffffff 1px solid; 
                                  border-top: #ffffff 1px solid; 
                                  border-left: #ffffff 1px solid; 
                                  border-bottom: #ffffff 1px solid;">
                                  </div>
                        
                        <div id="DivEditCode" style="left: 150px; 
                            width: 300px; 
                            position: absolute; top: 688px; height: 216px">
                            
                            <asp:TextBox ID="TextBox6" runat="server" 
                            Text='<%# Bind("Code") %>' 
                            Height="200px" 
                            TextMode="MultiLine" width="276px">
                            </asp:TextBox>
                        </div>    &nbsp;
                        
                    
                    </EditItemTemplate>
                    
                    <InsertItemTemplate><div style="width: 100px; 
                                            height: 559px">  </div>
                        
                        <div id="DivInsertCode" style="left: 150px; 
                            width: 300px; position: absolute; 
                            top: 688px; height: 216px">
                        <asp:TextBox ID="TextBox6" runat="server" 
                        Text='<%# Bind("Code") %>' 
                        Height="305px" 
                        TextMode="MultiLine" width="276px">
                        </asp:TextBox>
                        </div>
                    </InsertItemTemplate>
                    <ItemTemplate>    &nbsp;
                    
                        <div id="DivItemCode" style="border-right: #99ccff 1px solid; 
                            border-top: #99ccff 1px solid; 
                            left: 150px; 
                            border-left: #99ccff 1px solid; 
                            width: 280px; 
                            border-bottom: #99ccff 1px solid;
                           position: absolute; top: 788px; height: 250px; 
                           background-color: #ffffff">
                          <b>Code Window </b>
                        
                        <asp:Label ID="Label6" runat="server" 
                        Text='<%# Bind("Code") %>' 
                        Height="18px" width="276px">
                        </asp:Label>
                         
                         </div>
                    </ItemTemplate>
                </asp:TemplateField>
               
                
                <asp:BoundField DataField="picture" 
                HeaderText="picture" 
                SortExpression="picture" />
                
                <asp:TemplateField HeaderText="WebArtID" 
                InsertVisible="False" 
                SortExpression="WebArtID">
                
                    <EditItemTemplate>
                
                        <asp:Label ID="Label1" runat="server" 
                        Text='<%# Eval("WebArtID") %>'>
                        </asp:Label>
                    </EditItemTemplate>
                   
                    <ItemTemplate>     &nbsp;
                    <div id="DivItemWebArtID" style="left: 315px;
                         width: 100px; 
                         position: absolute; top: 10px;      height: 18px">
                         
                     <asp:Label ID="Label7" runat="server" CssClass="fieldlbl" 
                     Height="14px"  width="24px" 
                     Text='<%# Bind("WebArtID") %>'>
                     </asp:Label></div>
                    </ItemTemplate>
                    
                </asp:TemplateField>
            </Fields>
            <PagerSettings Position="TopAndBottom" />
        </asp:DetailsView></div>
        
        <div id="DivBackDrop1" class="form2" style="z-index: -1; 
            left: 5px; width: 0px;
            position: absolute; top: 300px; height: 624px">
        </div>
        
        <div id="DivItemLangLabels" style="left: 30px; width: 82px; 
            position: absolute;
            top: 293px; height: 19px;">
            <asp:Label ID="LabelPageTitle" runat="server" 
            Text="Page Title" 
            width="70px" 
            CssClass="SG1" Height="14px"></asp:Label>
            
            <div id="DivColumn1Label" style="left: 0px; 
                width: 79px; 
                position: absolute; top: 22px;
                height: 21px;">
                <asp:Label ID="LabelColumn1" runat="server" 
                Text="Column 1" 
                width="69px" 
                CssClass="SG1"></asp:Label>
                <div id="DivColumn2Label" style="left: -354px; 
                    width: 157px; position: absolute; 
                    top: 287px; 
                    height: 30px; z-index: 100;" class="bck">
                    
                    <asp:Label ID="LabelColumn2" runat="server" 
                    Text="Column 2" width="96px" CssClass="SG1">
                    </asp:Label>
                    
                    <div id="DivCategoryLabel" style="left: 0px; 
                        width: 108px; 
                        position: absolute; 
                        top: 109px; height: 88px;" class="bck">
                        <asp:Label ID="LabelCategoryID" runat="server" CssClass="SG1" 
                        Text="Category ID"
                            width="72px">
                            </asp:Label>
                          </div>
                         
                          
                        <div id="DivLabelhasCode" style="left: -360px; 
                            width: 120px; position: absolute; 
                            top: 419px; height: 35px;" class="bck">
                            
                            <asp:Label ID="LabelhasCode" runat="server" 
                            CssClass="SG1" Text="Plus Special" width="98px">
                            </asp:Label>
                            </div>
                            
                            <div id="DivCode" style="left: -362px; 
                                width: 141px; 
                                position: absolute; top: 475px; 
                                height: 21px;" 
                                class="bck">
                                <asp:Label ID="LabelSpecialCODE" 
                                runat="server" CssClass="SG1" Text="Special Content"
                                    width="100px">
                                </asp:Label>
                                   </div>
                                    
                                <div id="DivWebArtID" style="left: 357px; 
                                    width: 40px; position: absolute; top: -167px; 
                                    height: 7px;">
                                   <asp:Label ID="LabelWebArticleNumbr" runat="server" 
                                   CssClass="SG1" Text="No." width="25px">
                                   </asp:Label>
                                      </div>
                                      
                                  
                                 
                        <div id="Div1" style="left: 800px; 
                            width: 109px; position: absolute; top:500px; 
                            height: 7px;" class="bck">
                 
                      <asp:Label ID="Label8" runat="server" 
                      Text="No." width="100px">
                      </asp:Label></div>
                              
                      <div id="23" style="border-right: #000000 1px solid; 
                          border-top: #000000 1px solid; 
                          left: 104px; 
                          border-left: #000000 1px; 
                          border-bottom: #000000 1px; 
                          position: absolute; 
                          top: 437px; 
                          width: 24px; height: 61px;"></div>
                           
                             <div id="23b" style="position: absolute; 
                                 top: 477px; 
                                 width: 140px; 
                                 height: 233px; 
                                 border-left: #000000 1px solid; 
                                 border-bottom: #000000 1px solid; 
                                 z-index: -2; 
                                 left: 47px;">
                                 </div>
                           
                        
                  
                </div>
            </div>
        </div>
    </div>
   
   

   
   
  	<img id="copi" alt="" onclick="ClipBoard();" 
  	src="images\edit.jpg" 
  	style="z-index: 126;
  	    left: 183px; 
  	    position: absolute; 
  	    top: 120px; height: 17px;" 
  	    align="left" 
  	    width="16" title="Copy Code to your Clipboard" />
          
   </form>
</body>
</html>
