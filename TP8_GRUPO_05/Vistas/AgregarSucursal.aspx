<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarSucursal.aspx.cs" Inherits="Vistas.AgregarSucursal" %>

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
            width: 70px;
        }
        .auto-style3 {
            width: 165px;
        }
        .auto-style4 {
            width: 70px;
            height: 23px;
        }
        .auto-style5 {
            width: 165px;
            height: 23px;
        }
        .auto-style6 {
            height: 23px;
        }
        .auto-style7 {
            width: 240px;
        }
        .auto-style8 {
            height: 23px;
            width: 240px;
        }
        .auto-style9 {
            width: 220px;
        }
        .auto-style11 {
            width: 70px;
            height: 32px;
        }
        .auto-style12 {
            width: 165px;
            height: 32px;
        }
        .auto-style13 {
            width: 240px;
            height: 32px;
        }
        .auto-style14 {
            height: 32px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style9">
                        <asp:LinkButton ID="lbAgregarSucursal" runat="server">Agregar Sucursal</asp:LinkButton>
                    </td>
                    <td class="auto-style9">
                        <asp:LinkButton ID="lbListadoDeSucursales" runat="server" OnClick="lbListadoDeSucursales_Click">Listado de Sucursales</asp:LinkButton>
                    </td>
                    <td>
                        <asp:LinkButton ID="lbEliminarSucursal" runat="server" OnClick="lbEliminarSucursal_Click">Eliminar Sucursal</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style5"></td>
                    <td class="auto-style8" colspan="2"></td>
                    <td class="auto-style6"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Label ID="lblGrupo" runat="server" Font-Bold="True" Font-Size="20pt" Text="GRUPO N° 5"></asp:Label>
                    </td>
                    <td class="auto-style7" colspan="2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style7" colspan="2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Label ID="lblAgregarSucursal" runat="server" Font-Bold="True" Font-Size="15pt" Text="Agregar Sucursal"></asp:Label>
                    </td>
                    <td class="auto-style7" colspan="2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style5"></td>
                    <td class="auto-style8" colspan="2"></td>
                    <td class="auto-style6"></td>
                </tr>
                <tr>
                    <td class="auto-style11"></td>
                    <td class="auto-style12">
                        <asp:Label ID="lblNombreSucursal" runat="server" Text="Nombre Sucursal:"></asp:Label>
                    </td>
                    <td class="auto-style13" colspan="2">
                        <asp:TextBox ID="txtNombreSucursal" runat="server" Height="22px" Width="225px"></asp:TextBox>
                    </td>
                    <td class="auto-style14"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Label ID="lblDescripción" runat="server" Text="Descripción:"></asp:Label>
                    </td>
                    <td class="auto-style7" colspan="2">
                        <asp:TextBox ID="txtDescripción" runat="server" Height="27px" Width="225px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style5">
                        <asp:Label ID="lblProvincia" runat="server" Text="Provincia:"></asp:Label>
                    </td>
                    <td class="auto-style8" colspan="2">
                        <asp:DropDownList ID="ddlProvincia" runat="server" Width="235px">
                            <asp:ListItem Value="0">--Seleccionar--</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style6"></td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style5">
                        <asp:Label ID="lblDirección" runat="server" Text="Dirección:"></asp:Label>
                    </td>
                    <td class="auto-style8" colspan="2">
                        <asp:TextBox ID="txtDirección" runat="server" Height="22px" Width="225px"></asp:TextBox>
                    </td>
                    <td class="auto-style6"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style7" colspan="2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style7" colspan="2">
                        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" Width="75px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
