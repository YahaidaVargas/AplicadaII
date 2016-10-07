<%@ Page Title="" Language="C#" MasterPageFile="~/maestras/Maform.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="AplicadaII.MaestroDet.Detalle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cuerpo" runat="server">
    <form id="form1" runat="server">
        <asp:DetailsView ID="DVDetalles" runat="server" Height="50px" Width="125px">
        </asp:DetailsView>
    </form>
</asp:Content>
