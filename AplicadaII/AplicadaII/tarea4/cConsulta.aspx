<%@ Page Title="" Language="C#" MasterPageFile="~/maestras/Maform.Master" AutoEventWireup="true" CodeBehind="cConsulta.aspx.cs" Inherits="AplicadaII.tarea4.cConsulta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cuerpo" runat="server">



    <div class="row">
        <form id="formCon" runat="server">
            <div class="col-sm-12 col-md-12 col-lg-12 col-xs-12">

    <br />
<br />

                <asp:GridView ID="gvConsulta" runat="server" CssClass="table table-condensed table-hover" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" OnSelectedIndexChanged="gvConsulta_SelectedIndexChanged" OnSelectedIndexChanging="gvConsulta_SelectedIndexChanging"   >
                    <AlternatingRowStyle BackColor="#DCDCDC" />
                    <Columns>
                        <asp:CommandField SelectText="Telefonos" ShowSelectButton="True" />
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#0000A9" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#000065" />


                
                </asp:GridView>

            </div>


        </form>

    </div>
    

</asp:Content>
