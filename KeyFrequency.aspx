<%@ Page Language="C#" AutoEventWireup="true" CodeFile="KeyFrequency.aspx.cs" Inherits="KeyFrequency" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="KeySearch" runat="server"></asp:TextBox>
    </div>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
        AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="WebArtID" 
        DataSourceID="Ob11">
        <Columns>
            <asp:BoundField DataField="WebArtID" HeaderText="WebArtID" 
                InsertVisible="False" ReadOnly="True" SortExpression="WebArtID" />
            <asp:BoundField DataField="CategoryID" HeaderText="CategoryID" 
                SortExpression="CategoryID" />
            <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
            <asp:BoundField DataField="url" HeaderText="url" ReadOnly="True" 
                SortExpression="url" />
        </Columns>
        <EmptyDataTemplate>
            <asp:HyperLink ID="HyperLink1" runat="server" 
                NavigateUrl='<%# Eval("url", "{0}") %>' Text='<%# Eval("Title", "{0}") %>'></asp:HyperLink>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text='<%# Eval("WebArtID", "{0}") %>'></asp:Label>
        </EmptyDataTemplate>
    </asp:GridView>
    <asp:ObjectDataSource ID="Ob11" runat="server" DeleteMethod="Delete" 
        InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" 
        SelectMethod="KeyData" 
        TypeName="KeywordsCol1DateSetTableAdapters.WebArticle07_CFcomTableAdapter" 
        UpdateMethod="Update">
        <DeleteParameters>
            <asp:Parameter Name="Original_WebArtID" Type="Int32" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="CategoryID" Type="Int32" />
            <asp:Parameter Name="WebArticle" Type="String" />
            <asp:Parameter Name="WebArticle2" Type="String" />
            <asp:Parameter Name="Title" Type="String" />
            <asp:Parameter Name="Original_WebArtID" Type="Int32" />
        </UpdateParameters>
        <SelectParameters>
            <asp:ControlParameter ControlID="KeySearch" DefaultValue="deal" Name="keyword1" 
                PropertyName="Text" Type="String" />
        </SelectParameters>
        <InsertParameters>
            <asp:Parameter Name="CategoryID" Type="Int32" />
            <asp:Parameter Name="WebArticle" Type="String" />
            <asp:Parameter Name="WebArticle2" Type="String" />
            <asp:Parameter Name="Title" Type="String" />
        </InsertParameters>
    </asp:ObjectDataSource>
    <asp:ObjectDataSource ID="Keysource1" runat="server"></asp:ObjectDataSource>
    </form>
</body>
</html>
