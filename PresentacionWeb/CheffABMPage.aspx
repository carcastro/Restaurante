<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheffABMPage.aspx.cs" Inherits="PresentacionWeb.CheffABMPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Apellido"></asp:Label>
            <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Telefono"></asp:Label>
            <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Especialidad"></asp:Label>
            <asp:TextBox ID="txtEspecialidad" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="DNI"></asp:Label>
            <asp:TextBox ID="txtDNI" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" />
            <br />
            <asp:Literal ID="LitResultado" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>
