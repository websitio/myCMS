<%@ Control Language="C#" AutoEventWireup="true" CodeFile="WebArticlel.ascx.cs" Inherits="Controls_WebArticlel" %>
<link  href="http://www.cafeflorin.com/pdi.css" type="text/css" rel="stylesheet" />
<meta content="False" name="vs_snapToGrid" />
<meta content="True" name="vs_showGrid" />
<div class="form2r" style="border-right: #000000 1px solid; border-top: #000000 1px solid; z-index: 104; left: 712px; border-left: #000000 1px solid; width: 491px; border-bottom: #000000 1px solid; position: absolute; top: 4px; height: 605px"
	 ><asp:textbox id="txtTitle" style="z-index: 103; left: 14px; position: absolute; top: 96px" runat="server"
		width="210px"></asp:textbox><asp:textbox id="txtWebArticle" style="z-index: 104; left: 14px; position: absolute; top: 238px"
		runat="server" width="220px" MaxLength="1200" CssClass="txt" Height="352px" TextMode="MultiLine"></asp:textbox><asp:textbox id="txtArtType" style="z-index: 105; left: 262px; position: absolute; top: 136px"
		runat="server" width="216px" TextMode="MultiLine"></asp:textbox><asp:textbox id="txtParagraphHeading" style="z-index: 106; left: 14px; position: absolute; top: 136px"
		runat="server" width="216px" Height="44px" TextMode="MultiLine"></asp:textbox>
	<div class="txt" style="DISPLAY: inline; z-index: 107; left: 23px; width: 40px; position: absolute; top: 220px; height: 19px"
		>Article</div>
	<div class="txt" style="DISPLAY: inline; z-index: 109; left: 14px; width: 32px; position: absolute; top: 80px; height: 15px"
		>Title</div>
	<div class="txt" style="DISPLAY: inline; z-index: 110; left: 267px; width: 80px; position: absolute; top: 120px; height: 16px"
		>Article Type</div>
	<asp:dropdownlist id="ddlwebcats" style="z-index: 112; left: 14px; position: absolute; top: 56px"
		runat="server" width="181px" CssClass="txt"></asp:dropdownlist><asp:textbox id="txtImage" style="z-index: 113; left: 260px; position: absolute; top: 545px"
		runat="server" width="174px"></asp:textbox>
	<div class="txt" style="DISPLAY: inline; z-index: 114; left: 112px; width: 101px; position: absolute; top: 193px; height: 16px"
		>Select an Image.</div>
	<input id="PersonImage" style="z-index: 101; left: 216px; width: 261px; position: absolute; top: 192px; height: 22px"
		type="file" size="24" name="PersonImage" runat="server" /><br>
	&nbsp;<asp:textbox id="txtSubCategory" style="z-index: 115; left: 264px; position: absolute; top: 59px"
		runat="server" width="207px"></asp:textbox>
	<div class="txt" style="DISPLAY: inline; z-index: 116; left: 268px; width: 84px; position: absolute; top: 42px; height: 16px"
		 >Sub Category</div>
	<div class="txt" style="DISPLAY: inline; z-index: 117; left: 14px; width: 131px; position: absolute; top: 40px; height: 19px"
		 >Top Level Category</div>
	<asp:checkbox id="chkShowPic" style="z-index: 118; left: 18px; position: absolute; top: 190px"
		runat="server" width="88px" CssClass="txt" Text="Has Image"></asp:checkbox>
	<div class="txt" style="DISPLAY: inline; z-index: 119; left: 14px; width: 120px; position: absolute; top: 120px; height: 16px"
		 >Paragraph Header</div>
	<div class="txtb" style="DISPLAY: inline; z-index: 121; left: 184px; width: 152px; position: absolute; top: 23px; height: 16px"
		 >Article Creation Panel</div>
	<asp:textbox id="txtWebArticle2" style="z-index: 122; left: 262px; position: absolute; top: 240px"
		runat="server" width="220px" CssClass="txt" Height="277px" TextMode="MultiLine" Columns="28"
		Rows="12"></asp:textbox>
	<div class="txt" style="DISPLAY: inline; z-index: 123; left: 267px; width: 96px; position: absolute; top: 221px; height: 19px"
		 >Article 2nd Col</div>
	<div class="caption" style="DISPLAY: inline; z-index: 124; left: 11px; width: 471px; position: absolute; top: 0px; height: 23px"
		 >Article Creation Panel:</div>
	<img id="cross" style="z-index: 125; left: 465px; position: absolute; top: 3px" onclick=" pushoffBush();"
		alt="" src="images\cross.png" />
	<asp:label id="lblPK" style="z-index: 126; left: 416px; position: absolute; top: 28px" runat="server"></asp:label></div>
<div class="form2r" style="z-index: 103; left: 712px; width: 525px; position: absolute; top: 614px; height: 128px"
	 >
	<div class="caption" style="DISPLAY: inline; z-index: 130; left: 0px; width: 520px; position: absolute; top: 0px; height: 23px"
		 >Publicity Management&nbsp;Panel:</div>
	<asp:checkbox id="chkPublish" style="z-index: 132; left: 376px; position: absolute; top: 24px"
		runat="server" CssClass="txt" Text="Published"></asp:checkbox><asp:textbox id="UrlField" style="z-index: 132; left: 72px; position: absolute; top: 48px" runat="server"
		width="184px" CssClass="NormalTextBox" maxlength="150"></asp:textbox>
	<div class="txt" style="DISPLAY: inline; z-index: 132; left: 17px; width: 38px; position: absolute; top: 66px; height: 19px"
		 >URL</div>
	<asp:textbox id="txtPublish" style="z-index: 132; left: 272px; position: absolute; top: 48px"
		runat="server" width="28px" MaxLength="1"></asp:textbox><asp:textbox id="txtArtDate" style="z-index: 132; left: 376px; position: absolute; top: 48px"
		runat="server" width="131px"></asp:textbox>
	<div class="txt" style="DISPLAY: inline; z-index: 132; left: 328px; width: 40px; position: absolute; top: 48px; height: 15px"
		 >Date</div>
	<asp:hyperlink id="ViewHyperLink" style="z-index: 127; left: 16px; position: absolute; top: 32px"
		runat="server" Target="_blank">Preview Article</asp:hyperlink>
	<div class="txt" style="DISPLAY: inline; z-index: 127; left: 15px; width: 56px; position: absolute; top: 100px; height: 19px"
		 >Keywords</div>
	<asp:textbox id="txtKeywords" style="z-index: 127; left: 80px; position: absolute; top: 80px"
		runat="server" width="434px" TextMode="MultiLine"></asp:textbox></div>
<div class="form2r" id="Code" style="z-index: 102; left: 712px; width: 519px; position: absolute; top: 752px; height: 116px"
	 ><asp:textbox id="TextBox1" style="z-index: 130; left: 1px; position: absolute; top: 28px" runat="server"
		width="502px" Height="67px" TextMode="MultiLine"></asp:textbox>
	<div class="caption" style="DISPLAY: inline; z-index: 131; left: 0px; width: 510px; position: absolute; top: 0px; height: 23px"
		 >Display Code&nbsp;Management&nbsp;Panel:</div>
</div>
<div style="width: 656px; position: relative; height: 392px"  ><asp:datagrid id="dg" style="z-index: 100; left: 0px; position: absolute; top: 42px" runat="server"
		width="560px" CssClass="form2r" DataKeyField="WebArtID" AllowPaging="True" AutoGenerateColumns="False" PageSize="1" CellSpacing="1" OnItemCommand="dg_ItemCommand" OnPageIndexChanged="dg_PageIndexChanged">
		<ItemStyle Font-Size="8pt" Font-Names="Arial" ForeColor="#000099" BackColor="White"></ItemStyle>
		<HeaderStyle Font-Size="8pt" Font-Names="Arial" HorizontalAlign="left" CssClass="txt" VerticalAlign="Top"></HeaderStyle>
		<Columns>
			<asp:TemplateColumn HeaderText="ID">
				<ItemStyle VerticalAlign="Top"></ItemStyle>
				<ItemTemplate>
					<asp:Label runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.WebArtID") %>' ID="Label1">
					</asp:Label>
				</ItemTemplate>
				<EditItemTemplate>
					<asp:TextBox runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.WebArtID") %>' ID="Textbox2">
					</asp:TextBox>
				</EditItemTemplate>
			</asp:TemplateColumn>
			<asp:TemplateColumn HeaderText="CatID">
				<ItemStyle Wrap="False" VerticalAlign="Top"></ItemStyle>
				<ItemTemplate>
					<asp:Label runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.CategoryID") %>' ID="CategoryID">
					</asp:Label>
				</ItemTemplate>
				<EditItemTemplate>
					<asp:TextBox runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.CatgegoryID") %>' ID="Textbox3">
					</asp:TextBox>
				</EditItemTemplate>
			</asp:TemplateColumn>
			<asp:TemplateColumn HeaderText="Article">
				<ItemTemplate>
					<asp:Label runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.WebArticle") %>' ID="WebArticle">
					</asp:Label>
				</ItemTemplate>
				<EditItemTemplate>
					<asp:TextBox runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.WebArticle") %>' ID="Textbox4">
					</asp:TextBox>
				</EditItemTemplate>
			</asp:TemplateColumn>
			<asp:TemplateColumn HeaderText="Article2">
				<ItemTemplate>
					<asp:Label runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.WebArticle2") %>' ID="Label7">
					</asp:Label>
				</ItemTemplate>
				<EditItemTemplate>
					<asp:TextBox runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.WebArticle2") %>' ID="Textbox11">
					</asp:TextBox>
				</EditItemTemplate>
			</asp:TemplateColumn>
			<asp:TemplateColumn HeaderText="Title">
				<ItemStyle VerticalAlign="Top"></ItemStyle>
				<ItemTemplate>
					<asp:Label runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Title") %>' ID="Title">
					</asp:Label>
				</ItemTemplate>
				<EditItemTemplate>
					<asp:TextBox runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Title") %>' ID="Textbox5">
					</asp:TextBox>
				</EditItemTemplate>
			</asp:TemplateColumn>
			<asp:TemplateColumn HeaderText="Code">
				<ItemTemplate>
					<asp:Label runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Code") %>' ID="Label2">
					</asp:Label>
				</ItemTemplate>
				<EditItemTemplate>
					<asp:TextBox runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Code") %>' ID="Textbox6">
					</asp:TextBox>
				</EditItemTemplate>
			</asp:TemplateColumn>
			<asp:TemplateColumn>
				<ItemStyle VerticalAlign="Top"></ItemStyle>
				<ItemTemplate>
					<asp:Label runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.publish") %>' ID="Label3">
					</asp:Label>
				</ItemTemplate>
				<EditItemTemplate>
					<asp:TextBox runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.publish") %>' ID="Textbox7">
					</asp:TextBox>
				</EditItemTemplate>
			</asp:TemplateColumn>
			<asp:TemplateColumn>
				<ItemStyle VerticalAlign="Top"></ItemStyle>
				<ItemTemplate>
					<asp:Label runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.picture") %>' ID="Label4">
					</asp:Label>
				</ItemTemplate>
				<EditItemTemplate>
					<asp:TextBox runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.picture") %>' ID="Textbox8">
					</asp:TextBox>
				</EditItemTemplate>
			</asp:TemplateColumn>
			<asp:TemplateColumn HeaderText="Type">
				<ItemTemplate>
					<asp:Label runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ArtType") %>' ID="Label5">
					</asp:Label>
				</ItemTemplate>
				<EditItemTemplate>
					<asp:TextBox runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ArtType") %>' ID="Textbox9">
					</asp:TextBox>
				</EditItemTemplate>
			</asp:TemplateColumn>
			<asp:TemplateColumn HeaderText="Keys">
				<ItemStyle VerticalAlign="Top"></ItemStyle>
				<ItemTemplate>
					<asp:Label runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Keywords") %>' ID="Label6">
					</asp:Label>
				</ItemTemplate>
				<EditItemTemplate>
					<asp:TextBox runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Keywords") %>' ID="Textbox10">
					</asp:TextBox>
				</EditItemTemplate>
			</asp:TemplateColumn>
			<asp:TemplateColumn>
				<HeaderStyle width="35px"></HeaderStyle>
				<ItemStyle Font-Size="XX-Small" VerticalAlign="Top"></ItemStyle>
				<ItemTemplate>
					<asp:LinkButton runat="server" Text="Edit" CommandName="Edit" CausesValidation="false" ID="Linkbutton1"></asp:LinkButton>
				</ItemTemplate>
				<EditItemTemplate>
					<asp:LinkButton runat="server" Text="Update" CommandName="Select" ID="btnUpdate"></asp:LinkButton>
					<asp:LinkButton runat="server" Text="Cancel" CommandName="Select" CausesValidation="false" ID="Linkbutton2"></asp:LinkButton>
				</EditItemTemplate>
			</asp:TemplateColumn>
			<asp:ButtonColumn Text="Delete" CommandName="Delete">
				<ItemStyle Font-Size="XX-Small" Font-Names="Ariel" VerticalAlign="Top"></ItemStyle>
			</asp:ButtonColumn>
		</Columns>
		<PagerStyle Position="Top"></PagerStyle>
	</asp:datagrid><asp:button id="btnSave" style="z-index: 104; left: 472px; position: absolute; top: 8px" runat="server"
		width="104px" CssClass="butt" Height="26px" Text="Save Changes" Visible="False" BackColor="Transparent" OnClick="btnSave_Click"></asp:button><asp:label id="lblrows" style="z-index: 102; left: 328px; position: absolute; top: 8px" runat="server"></asp:label><asp:button id="btnSearch" style="z-index: 103; left: 256px; position: absolute; top: 8px" runat="server"
		Text="Search" OnClick="btnSearch_Click"></asp:button><asp:button id="btnAddNew" style="z-index: 105; left: 384px; position: absolute; top: 8px" runat="server"
		width="81px" CssClass="txt" Text="Add New" BackColor="Transparent" OnClick="btnAddNew_Click"></asp:button><asp:textbox id="txbSearch" style="z-index: 106; left: 8px; position: absolute; top: 8px" runat="server"
		width="250px"></asp:textbox></div>

