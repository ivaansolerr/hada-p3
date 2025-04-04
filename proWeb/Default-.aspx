<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default-.aspx.cs" Inherits="proWeb.Default_" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label CssClass="fLB" runat="server" Text="Code"></asp:Label>
    <asp:TextBox ID="txtCode" runat="server" Width="250px"></asp:TextBox>
    <br /><br />

    <asp:Label CssClass="fLB" runat="server" Text="Name"></asp:Label>
    <asp:TextBox ID="txtName" runat="server" Width="250px"></asp:TextBox>
    <br /><br />

    <asp:Label CssClass="fLB" runat="server" Text="Amount"></asp:Label>
    <asp:TextBox ID="txtAmount" runat="server" CssClass="inNumb"></asp:TextBox>
    <br /><br />

    <asp:Label CssClass="fLB" runat="server" Text="Category"></asp:Label>
    <asp:DropDownList ID="ddlCategory" runat="server">
    </asp:DropDownList>
    <br /><br />

    <asp:Label CssClass="fLB" runat="server" Text="Price"></asp:Label>
    <asp:TextBox ID="txtPrice" runat="server" CssClass="inNumb"></asp:TextBox>
    <br /><br />

    <asp:Label CssClass="fLB" runat="server" Text="Creation Date"></asp:Label>
    <asp:TextBox ID="txtCreationDate" runat="server" TextMode="Date"></asp:TextBox>
    <br /><br />

    <asp:Label ID="DisplayMessage" runat="server" Text=""></asp:Label>
    <br /><br />

    <!-- Buttons with Click Events -->
    <asp:Button ID="btnCreate" CssClass="mDB" runat="server" Text="Create" OnClick="btnCreate_Click" />
    <asp:Button ID="btnUpdate" CssClass="mDB" runat="server" Text="Update" OnClick="btnUpdate_Click" />
    <asp:Button ID="btnDelete" CssClass="mDB" runat="server" Text="Delete" OnClick="btnDelete_Click" />
    <asp:Button ID="btnRead" CssClass="mDB" runat="server" Text="Read" OnClick="btnRead_Click" />
    <asp:Button ID="btnReadFirst" CssClass="mDB" runat="server" Text="Read First" OnClick="btnReadFirst_Click" />
    <asp:Button ID="btnReadPrev" CssClass="mDB" runat="server" Text="Read Prev" OnClick="btnReadPrev_Click" />
    <asp:Button ID="btnReadNext" CssClass="mDB" runat="server" Text="Read Next" OnClick="btnReadNext_Click" />
</asp:Content>