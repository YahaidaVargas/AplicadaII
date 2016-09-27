<%@ Page Title="" Language="C#" MasterPageFile="~/maestras/Maform.Master" AutoEventWireup="true" CodeBehind="rPersonasWf.aspx.cs" Inherits="AplicadaII.tarea4.rPersonasWf" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cuerpo" runat="server" >
    <div class="row">
        <div class="col-sm-12 col-md-12 col-lg-12 col-xs-12" style="background-color: #0000FF; border-style: dotted; font-family: 'Bell Gothic Std Black'; font-size: larger; font-style: normal; color: #FFFFFF; text-transform: capitalize; font-variant: small-caps; font-weight: bold; visibility: inherit; table-layout: fixed; line-height: normal;">
          <center><b><h2> Registrarse</h2></b> </center>  
        </div>
    
      
        <div class="col-sm-12 col-md-12 col-lg-12 col-xs-12">
            <br>
        <br>
        <br >
    <form class="form-horizontal" id="form1" runat="server">
  <div class="form-group">
    <label for="txtNombre" class="col-sm-2 control-label">Nombre</label>

    <div class="col-sm-6">
        <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server" />
    </div>
  </div>
  
<div class="form-group">
    <label for="cbSexo" class="col-sm-2 control-label">Sexo</label>
    <div class="col-sm-5">
  <asp:DropDownList ID="cbSexo" CssClass="form-control" runat="server">
      <asp:ListItem Selected="True" Value="-1">seleccione el sexo</asp:ListItem>
      <asp:ListItem Value="M">Masculino</asp:ListItem>
      <asp:ListItem Value="F">Femenino</asp:ListItem>
   </asp:DropDownList>
    
    </div>
  </div>


   <div class="form-group">
    <label for="telefonos" class="col-sm-2 control-label">Telefonos</label>
    <div class="col-sm-6">
        <div class="well">
           <table class="table">
               <tr>
                   <td>
                       <asp:DropDownList ID="tipoTel" CssClass="form-control" runat="server">
                          <asp:ListItem Selected="True" Value="-1">Tipo de Telefono</asp:ListItem>
                          <asp:ListItem Value="Celular">Celular</asp:ListItem>
                          <asp:ListItem Value="Casa">Casa</asp:ListItem>
                           <asp:ListItem Value="Trabajo">Trabajo</asp:ListItem>
                       </asp:DropDownList>
                   </td>
                   <td>
                       <asp:TextBox runat="server" 
                   ID="txtTelefono" CssClass="form-control" ToolTip="escribe telefono"></asp:TextBox> </td>

               </tr>

           </table>
            
        </div>
    
    </div>
  </div>

  <div class="form-group">
    <div class="col-sm-offset-2 col-sm-10">
    <asp:Button runat="server" CssClass="btn btn-primary" Text="Guardar" ID="btnGuardar" OnClick="btnGuardar_Click" />
    </div>
  </div>
</form>
        </div>

        <div class="col-sm-12 col-md-12 col-lg-12 col-xs-12">

        </div>


        <div class="col-sm-12 col-md-12 col-lg-12 col-xs-12">

        </div>
         </div>
</asp:Content>
