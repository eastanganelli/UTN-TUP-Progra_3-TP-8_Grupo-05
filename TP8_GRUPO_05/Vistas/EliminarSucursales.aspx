<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarSucursales.aspx.cs" Inherits="Vistas.EliminarSucursales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 40px;
        }
        .auto-style4 {
            width: 215px;
        }
        .auto-style5 {
            width: 180px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:LinkButton ID="lbAgregarSucursal" runat="server" OnClick="lbAgregarSucursal_Click">Agregar Sucursal</asp:LinkButton>
                    </td>
                    <td class="auto-style4">
                        <asp:LinkButton ID="lbListadoDeSucursales" runat="server" OnClick="lbListadoDeSucursales_Click">Listado de Sucursales</asp:LinkButton>
                    </td>
                    <td>
                        <asp:LinkButton ID="lbEliminarSucursal" runat="server">Eliminar Sucursal</asp:LinkButton>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblEliminarSucursal" runat="server" Font-Bold="True" Font-Size="17pt" Text="Eliminar Sucursal"></asp:Label>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblIngresarId" runat="server" Text="Ingresar ID sucursal:"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtIngresarId" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" Width="70px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblMensaje" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
