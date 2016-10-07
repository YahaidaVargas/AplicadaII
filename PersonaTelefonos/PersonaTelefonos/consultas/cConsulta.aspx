<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cConsulta.aspx.cs" Inherits="PersonaTelefonos.cConsulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 100%;">
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:GridView ID="GvConsult" runat="server">
                        <Columns>
                            <asp:HyperLinkField DataNavigateUrlFields="PersonasId" DataNavigateUrlFormatString="DetalleTel.aspx?id={0}" DataTextField="PersonasId" DataTextFormatString="Telefono" />
                        </Columns>
                    </asp:GridView>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>

    
    </div>
    </form>
</body>
</html>
