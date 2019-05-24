<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="clientes.aspx.cs" Inherits="Curso_sql_newsoft_clientes.clientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Formulario para captura de clientes<br />
            <br />
            <asp:Label ID="lblEstadoClientes" runat="server" Text="sin uso clientes"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnÑrobarClientes" runat="server" OnClick="btnÑrobarClientes_Click" Text="Probar Clientes" />
            <br />
            <br />
            crear mi formulario que pemrita la captura de los clientes<br />
            <br />
            <br />
            ID:&nbsp;
            <asp:TextBox ID="txtIdCliente" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSelIDCliente" runat="server" OnClick="btnSelIDCliente_Click" Text="Sleccionar ID Cliente" Width="186px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSelTodosClientes" runat="server" Text="Seleccionar Todos los Clientes" OnClick="btnSelTodosClientes_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar Cliente" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" />
            <br />
            <br />
            <asp:Label ID="lblBusquedaCliente" runat="server" Text="No ha buscado un cliente"></asp:Label>
            <br />
            <br />
            Nombre: <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <br />
            Apellido paterno:
            <asp:TextBox ID="txtApePaterno" runat="server"></asp:TextBox>
&nbsp;<br />
            Apellido materno:&nbsp;
            <asp:TextBox ID="txtApeMaterno" runat="server"></asp:TextBox>
            <br />
            Edad:
            <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
            <br />
            Teléfono:&nbsp;
            <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
            <br />
            Email:
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            Fecha de nacimiento:
            <asp:TextBox ID="txtFechaNacimiento" runat="server"></asp:TextBox>
            <br />
            Fecha hora ingreso:
            <asp:TextBox ID="txtHoraIngreso" runat="server"></asp:TextBox>
            <br />
            Hora desayuno:
            <asp:TextBox ID="txtHoraDesayuno" runat="server"></asp:TextBox>
            <br />
            Sexo:
            <asp:TextBox ID="txtSexo" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblEstadoGuardado" runat="server" Text="Sin guardar"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnGuardarClientes" runat="server" OnClick="btnGuardarClientes_Click" Text="Guardar Clientes" />
            <br />
            <br />
            <br />
            <asp:GridView ID="gdvClientes" runat="server">
            </asp:GridView>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
