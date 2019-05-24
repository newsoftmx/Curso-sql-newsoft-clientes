<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Curso_sql_newsoft_clientes.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            Probar Conexión<br />
            <br />
            <asp:Label ID="lblEstadoConexion" runat="server" Text="Aun no se prueba la conexión"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnPruebaConexion" runat="server" OnClick="btnPruebaConexion_Click" Text="Probar Conexion" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
