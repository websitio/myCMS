<%@ Control Language="C#" AutoEventWireup="true" CodeFile="WebCrawlerCFControl1.ascx.cs" Inherits="Controls_WebCrawlerCFControl1" %>
<%@ Register Assembly="System.Web.Silverlight" Namespace="System.Web.UI.SilverlightControls"
    TagPrefix="asp" %>

<div style="position: absolute; top: 45px; z-index: -55; left: 600px; width: 183px; height: 581px;">
		
	<asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
        
        <asp:Silverlight ID="Silverlight1" runat="server" Height="533px" 
        MinimumVersion="2.0.31005.0" Source="~/ClientBin/WebCarosel.xap"
            width="988px">
        </asp:Silverlight>
		
        </div>