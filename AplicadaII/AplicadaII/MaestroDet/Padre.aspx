<%@ Page Title="" Language="C#" MasterPageFile="~/maestras/Maform.Master" AutoEventWireup="true" CodeBehind="Padre.aspx.cs" Inherits="AplicadaII.MaestroDet.Padre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cuerpo" runat="server">
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" CssClass="table">
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <Columns>
                <asp:BoundField DataField="PersonasId" HeaderText="ID" Visible="False" />
                <asp:BoundField DataField="Nombres" HeaderText="Nombres" />
                <asp:BoundField DataField="Sexo" HeaderText="Sexo" />
                <asp:HyperLinkField DataNavigateUrlFields="PersonasId" DataNavigateUrlFormatString="Detalle.aspx?id={0}" DataTextField="PersonasId" DataTextFormatString="Telefonos" />
            </Columns>
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <SortedAscendingCellStyle BackColor="#FAFAE7" />
            <SortedAscendingHeaderStyle BackColor="#DAC09E" />
            <SortedDescendingCellStyle BackColor="#E1DB9C" />
            <SortedDescendingHeaderStyle BackColor="#C2A47B" />
        </asp:GridView>
        <br />
    </form>
</asp:Content>
