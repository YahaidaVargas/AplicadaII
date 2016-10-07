<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rPersonas.aspx.cs" Inherits="PersonaTelefonos.rPersonas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>


         <asp:Table ID="Table1" runat="server" Height="161px" Width="55%">
        <asp:TableRow runat="server">
            
            <asp:TableCell runat="server">Nombre</asp:TableCell>

            <asp:TableCell runat="server">
                <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>

        <asp:TableRow runat="server">
          <asp:TableCell runat="server">Sexo</asp:TableCell>

            <asp:TableCell runat="server">
                <asp:DropDownList ID="DDsexo" runat="server">
                    <asp:ListItem Text="Femenino" Value="f"></asp:ListItem>
                     <asp:ListItem Text="Masculino" Value="m"></asp:ListItem>
                </asp:DropDownList>
            </asp:TableCell>
        </asp:TableRow>
       
              <asp:TableRow runat="server">
            
            <asp:TableCell runat="server">Tipo Telefono</asp:TableCell>

            <asp:TableCell runat="server">
                <asp:DropDownList ID="DdtipoTel" runat="server">

                    <asp:ListItem Text="Celular" Value="celular"></asp:ListItem>
                    <asp:ListItem Text="Trabajo" Value="trabajo"></asp:ListItem>
                    <asp:ListItem Text="Casa" Value="casa"></asp:ListItem>

                </asp:DropDownList>
                 </asp:TableCell>
        </asp:TableRow>


             <asp:TableRow runat="server">
            
            <asp:TableCell runat="server">Telefono</asp:TableCell>

            <asp:TableCell runat="server">
                <asp:TextBox ID="TxtTel" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>

            <asp:TableRow runat="server">
            
            <asp:TableCell runat="server"></asp:TableCell>

            <asp:TableCell runat="server">
                <asp:Button ID="BtnGuardar" OnClick="BtnGuardar_Click" runat="server" Text="Guardar" />
                          </asp:TableCell>
        </asp:TableRow>


           
    </asp:Table>

         <br />
         <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/consultas/cConsulta.aspx">Consultar</asp:HyperLink>
         <br />
         <br />


    
    </div>
    </form>
</body>
</html>
