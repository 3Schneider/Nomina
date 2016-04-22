<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insertar.aspx.cs" Inherits="WebAppNomina.Insertar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    
    
    <Header>
        <nav>
            <ul id =" MENU">
                <li>Menù</li>
                <li><a id ="A1" runat="server" href="~/consultar.aspx">Consultar</a></li>
                <li>Insertar</li>
            </ul>
        </nav>
    </Header>
    <form id="Form1" runat ="server">
    <div>
        <h1>Insertar Empleado</h1>
        <table class="auto-style1">
            <%--caja para los datos--%>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="label1" runat="server" Text="Identificacion"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextId" runat ="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="label2" runat="server" Text="Apellidos"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextApellidos" runat ="server"></asp:TextBox>
                </td>
            </tr>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="label3" runat="server" Text="Nombre"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextNombre" runat ="server"></asp:TextBox>
                </td>
            </tr>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="label4" runat="server" Text="Sueldo por hora"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="Textsueldoporhora" runat ="server"></asp:TextBox>
                </td>
            </tr>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="label5" runat="server" Text="Horas trabajadas"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="Texthorastrabajadas" runat ="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="BtnGuardar" runat="server" Text="Guardar" OnClick="BtnGuardar_Click" />
                    <asp:Button ID="BtnCancelar" runat="server" Text="Cancelar" />
                </td>
            </tr>
        </table>
    </div
        <p>
            <asp:Label ID="lbLMsg" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
