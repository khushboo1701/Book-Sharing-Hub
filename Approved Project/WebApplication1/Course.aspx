<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Course.aspx.vb" Inherits="WebApplication1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="font-size: medium; color: #FFFFFF">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p>
    <p style="color: #FFFFFF; font-size: small">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    PDF DOWNLOADS</p>
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
          <a href="pictures/DBMS.pdf">  C Programming </a><br />
          <a href="pictures/DBMS.pdf"> COA </a><br /> 
          <a href="pictures/DBMS.pdf">ACCOUNTS </a><br /> 
          <a href="pictures/DBMS.pdf">DISCRETE MATHS </a><br />
    </asp:Panel></td>
        <td>
       <asp:Panel ID="Panel2" runat="server" Height="100px" 
        style="margin-left: 0px">
           <a href="pictures/DBMS.pdf">DATA STRUC </a><br /> 
           <a href="pictures/DBMS.pdf">DBMS </a><br /> 
           <a href="pictures/DBMS.pdf">COMP NETWORKS </a><br /> 
           <a href="pictures/DBMS.pdf">RMT </a></asp:Panel> </td>
        <td> <asp:Panel ID="Panel3" runat="server" Height="100px" 
        style="margin-left: 0px">
            <a href="pictures/DBMS.pdf">MINING </a><br />
            <a href="pictures/DBMS.pdf">GRAPHICS </a><br /> 
            <a href="pictures/DBMS.pdf">SOFT ENGG </a><br /> 
            <a href="pictures/DBMS.pdf">OPRTNG SYSTEM </a></asp:Panel></td>
        <td> 
            <asp:Panel ID="Panel4" runat="server" Height="100px" 
        style="margin-left: 0px">
               <a href="pictures/DBMS.pdf">JAVA </a><br /> 
              <a href="pictures/DBMS.pdf">INFO SEC </a><br /> 
               <a href="pictures/DBMS.pdf">ALGORITHMS </a><br /> 
               <a href="pictures/DBMS.pdf">PROJECT MGMT </a></asp:Panel></td>
        <td><asp:Panel ID="Panel5" runat="server" Height="100px" 
        style="margin-left: 0px">
        <a href="pictures/DBMS.pdf">WEB </a> <br />
            <a href="pictures/DBMS.pdf">DISTBTD SYSTEM </a></asp:Panel> </td></tr></table>
    </asp:Content>
