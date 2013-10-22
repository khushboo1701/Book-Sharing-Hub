<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="qpapers.aspx.vb" Inherits="WebApplication1.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="color: #FFFFFF; font-size: small">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    QUESTION PAPERS</p>
    <p style="color: #FFFFFF; font-size: small"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        Semester:
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>SEM1</asp:ListItem>
            <asp:ListItem>SEM2</asp:ListItem>
            <asp:ListItem>SEM3</asp:ListItem>
            <asp:ListItem>SEM4</asp:ListItem>
            <asp:ListItem>SEM5</asp:ListItem>
        </asp:DropDownList>
&nbsp;
        <asp:Button ID="Button1" runat="server" Text="SELECT" />
        
    <p style="color: #FFFFFF; font-size: small"> 
        <br />
        <table>
        <tr>
        <td>
        <asp:Panel ID="Panel1" runat="server" Height="100px" 
        style="margin-left: 0px">
          <a href="pictures/Scan0001.tif">  C Programming </a><br />
          <a href="pictures/Scan0001.tif"> COA </a><br /> 
          <a href="pictures/Scan0001.tif">ACCOUNTS </a><br /> 
          <a href="pictures/Scan0001.tif">DISCRETE MATHS </a><br />
    </asp:Panel></td>
        <td>
       <asp:Panel ID="Panel2" runat="server" Height="100px" 
        style="margin-left: 0px">
           <a href="pictures/Scan0001.tif">DATA STRUC </a><br /> 
           <a href="pictures/Scan0001.tif">DBMS </a><br /> 
           <a href="pictures/Scan0001.tif">COMP NETWORKS </a><br /> 
           <a href="pictures/Scan0001.tif">RMT </a></asp:Panel> </td>
        <td> <asp:Panel ID="Panel3" runat="server" Height="100px" 
        style="margin-left: 0px">
            <a href="pictures/Scan0001.tif">MINING </a><br />
            <a href="pictures/Scan0001.tif">GRAPHICS </a><br /> 
            <a href="pictures/Scan0001.tif">SOFT ENGG </a><br /> 
            <a href="pictures/Scan0001.tif">OPRTNG SYSTEM </a></asp:Panel></td>
        <td> 
            <asp:Panel ID="Panel4" runat="server" Height="100px" 
        style="margin-left: 0px">
               <a href="pictures/Scan0001.tif">JAVA </a><br /> 
               <a href="pictures/Scan0001.tif">INFO SEC </a><br /> 
               <a href="pictures/Scan0001.tif">ALGORITHMS </a><br /> 
               <a href="pictures/Scan0001.tif">PROJECT MGMT </a></asp:Panel></td>
        <td><asp:Panel ID="Panel5" runat="server" Height="100px" 
        style="margin-left: 0px">
        <a href="pictures/Scan0001.tif">WEB </a> <br />
            <a href="pictures/Scan0001.tif">DISTBTD SYSTEM </a></asp:Panel> </td></tr></table>
                
    <p>
    </asp:Content>
