<%@ Page Title="" Language="C#" MasterPageFile="~/maestras/Maform.Master" AutoEventWireup="true" CodeBehind="cDetalle.aspx.cs" Inherits="AplicadaII.tarea4.cDetalle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cuerpo" runat="server">
    <div class="row">
        <form id="formCon" runat="server">
            <div class="col-sm-4 col-md-4 col-lg-4 col-xs-12">
             <asp:Label ID="lbid" runat="server"  ></asp:Label>
                


                </div>

              <div class="col-sm-4 col-md-4 col-lg-4 col-xs-12">
                
              <asp:Label ID="lbnombre" runat="server"  ></asp:Label>


                </div>


             <div class="col-sm-12 col-md-12 col-lg-12 col-xs-12">
                <asp:Table ID="tbTelefono" runat="server"></asp:Table>
                


                </div>

            </form>
        </div>

</asp:Content>
