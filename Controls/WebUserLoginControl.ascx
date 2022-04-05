<%@ Control Language="C#" AutoEventWireup="true" CodeFile="WebUserLoginControl.ascx.cs" Inherits="Controls_WebUserLoginControl" %>

<div id="ControlBackground" style="width: 277px; height: 136px; left: 15px; position: absolute; top: 15px;" class="form1r">
   
    <div style="left: 15px; position: absolute; top: 16px; height: 27px" 
        class="DivTxtbox">
        Name
        <asp:TextBox ID="txbUserName" runat="server" width="170px"></asp:TextBox>
        </div>
       
    <div id="DivPwd" 
        style="left: 12px; position: absolute; top: 58px; height: 20px" 
        class="DivTxtbox">
           Password
        <asp:TextBox ID="txbPassword" runat="server" TextMode="Password" width="145px"></asp:TextBox>

        </div> 

    <div id="DivBtn" style="position: absolute; left: 214px; top: 92px;">
        <asp:Button ID="Button1" runat="server" Text="Button" onclick="LoginBtn_Click"/>

        </div> 
  
    <div id="DivIdNo" style="position: absolute; left: 32px; width: 173px; top: 96px; height: 15px;">
        <asp:CheckBox ID="CheckBox1" runat="server" />
   
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
   
   
   </div> 
   
   
   
   </div>
   