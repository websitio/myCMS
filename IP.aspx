<%@ Page Language="C#" AutoEventWireup="true" CodeFile="IP.aspx.cs" Inherits="IP" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
   <style>

  
   </style> 
</head>
<body style="left: 254px; position: absolute; top: 55px">
    <form id="form1" runat="server">
    <div style="background-color: #ffffff">
        &nbsp;
        <div style="width: 181px; height: 16px; z-index: 5; left: 537px; visibility: hidden; position: absolute; top: 10px;">
            Below, around 65 pieces of information your government know about ( "your browser"
            :); and &nbsp;to the right, your earning key.
            <br />
            Three matching numbers and you should dis-connect now!</div>
        <div style="width: 30px; height: 55px; background-color: transparent;">
          
           
            <div style="z-index: 50; left: -150px; width: 277px; position: absolute; top: -55px;height: 132px">
                
                <asp:Repeater ID="Repeater1" runat="server" >
                <ItemTemplate>
               <asp:Label  id="hp2" Text='<%# DataBinder.Eval(Container.DataItem, "IPaddr") %>' 
				 runat="server" width="125" BackColor="LightGreen" Font-Size="12px" ForeColor="Black" ></asp:Label>  
				 <asp:Label ID="when"  Text='<%# DataBinder.Eval(Container.DataItem, "CreationDate")  %>'  runat="server" Font-Size="12px" BackColor="PowderBlue"></asp:Label>
				
			</ItemTemplate> 
           
             
              
                </asp:Repeater>
                <div style="width: 160px; height: 19px">
                    Add 5 hrs for BST</div>
            </div>
        </div>

            <asp:Label ID="Label2" runat="server" Text="Label" CssClass="stargate" ForeColor="#3333FF"></asp:Label>

        <asp:Label ID="Label1" runat="server" Text="Label" width="164px" ForeColor="White"></asp:Label>
        <div style="z-index: 777; left: 355px; width: 135px; position: absolute; top: 227px;
            height: 28px; visibility: hidden;">
            All<span style="color: #33ff00"><strong> </strong><span style="color: #000000; background-color: #00ff00">
                three</span></span><span style="background-color: #00ff00"> </span>should be
            different before you proceed to Step2)</div>
    
    </div>
    </form>
</body>
</html>
