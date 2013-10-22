<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="db.aspx.vb" Inherits="WebApplication1.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="color: #FFFFFF; font-size: small;">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" 
            CellPadding="4" CellSpacing="2" DataSourceID="SqlDataSource1" 
            EmptyDataText="There are no data records to display." ForeColor="Black">
            <Columns>
                <asp:BoundField DataField="NAME" HeaderText="NAME" SortExpression="NAME" />
                <asp:BoundField DataField="RNO" HeaderText="RNO" SortExpression="RNO" />
                <asp:BoundField DataField="PHONE" HeaderText="PHONE" SortExpression="PHONE" />
                <asp:BoundField DataField="SUBJECT" HeaderText="SUBJECT" 
                    SortExpression="SUBJECT" />
                <asp:BoundField DataField="TITLE" HeaderText="TITLE" SortExpression="TITLE" />
                <asp:BoundField DataField="AUTHOR" HeaderText="AUTHOR" 
                    SortExpression="AUTHOR" />
                <asp:BoundField DataField="EDITION" HeaderText="EDITION" 
                    SortExpression="EDITION" />
                <asp:BoundField DataField="MRP" HeaderText="MRP" SortExpression="MRP" />
                <asp:BoundField DataField="SALEID" HeaderText="SALEID" 
                    SortExpression="SALEID" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="White" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>" 
            ProviderName="<%$ ConnectionStrings:ConnectionString2.ProviderName %>" 
            SelectCommand="SELECT * FROM &quot;BOOKSELL&quot;"></asp:SqlDataSource>
</p>
    <p style="color: #FFFFFF; font-size: small;">
        &nbsp;</p>
    <p style="color: #FFFFFF; font-size: small;">
        &nbsp;</p>
    <p style="color: #FFFFFF; font-size: small;">
        &nbsp;</p>
    <p style="color: #FFFFFF; font-size: small;">
        &nbsp;</p>
    <p style="color: #FFFFFF; font-size: small;">
        &nbsp;</p>
    <p style="color: #FFFFFF; font-size: small;">
        Type the SALEID you want to buy&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Buy" />
</p>
    <p>
        &nbsp;</p>
</asp:Content>
