<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoSucursales.aspx.cs" Inherits="Vistas.ListadoSucursales" %>

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
            width: 170px;
        }
        .auto-style3 {
            width: 150px;
        }
        .auto-style4 {
            width: 220px;
        }
        .auto-style5 {
            width: 40px;
        }
        .auto-style6 {
            width: 60px;
        }
        .auto-style7 {
            width: 185px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style7">
                        <asp:LinkButton ID="lbAgregarSucursal0" runat="server" OnClick="lbAgregarSucursal_Click">Agregar Sucursal</asp:LinkButton>
                    </td>
                    <td class="auto-style4">
                        <asp:LinkButton ID="lbListadoDeSucursales0" runat="server">Listado de Sucursales</asp:LinkButton>
                    </td>
                    <td class="auto-style3">
                        <asp:LinkButton ID="lbEliminarSucursal0" runat="server" OnClick="lbEliminarSucursal0_Click">Eliminar Sucursal</asp:LinkButton>
                    </td>
                    <td colspan="2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="2">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style3">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="2">
                        <asp:Label ID="lblListadoDeSucursales0" runat="server" Font-Bold="True" Font-Size="15pt" Text="Listado de sucursales"></asp:Label>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td colspan="2">
                        <asp:Label ID="lblMensaje" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="2">
                        &nbsp;</td>

                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style3">
                    <asp:Label ID="lblFiltrarProvincia" runat="server" Text="Filtrar por Provincia:"></asp:Label>
                    </td>
                    <td colspan="2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="2">
                        <asp:Label ID="lblBusqueda0" runat="server" Text="Búsqueda ingrese ID sucursal:"></asp:Label>
                    </td>
                    <td class="auto-style4">
                    <asp:TextBox ID="txtIdSucursal0" runat="server" Width="220px"></asp:TextBox>
                    </td>

                    <td class="auto-style3">
                        <asp:DropDownList ID="ddlProvinciaFiltro" runat="server" Width="220px" AutoPostBack="True" OnSelectedIndexChanged="ddlProvinciaFiltro_SelectedIndexChanged" CausesValidation="False">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style3">
                        <asp:Button ID="btnFiltrar0" runat="server" Text="Filtrar" OnClick="btnFiltrar0_Click" />
                        <asp:Button ID="btnMostrarTodos0" runat="server" Text="Mostrar todos" Width="100px" OnClick="btnMostrarTodos0_Click" />
                    </td>
                    <td class="auto-style6">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="2">&nbsp;</td>
                    <td class="auto-style4">
                        <asp:Label ID="lblContador" runat="server" Font-Bold="True" ForeColor="#333333"></asp:Label>
                    </td>
                    <td class="auto-style3">&nbsp;</td>
                    <td colspan="2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="2">
                        &nbsp;</td>
                    <td class="auto-style4">
                        <asp:GridView ID="gvSucursal0" runat="server">
                        </asp:GridView>
                    </td>
                    <td class="auto-style3">&nbsp;</td>
                    <td colspan="2">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
