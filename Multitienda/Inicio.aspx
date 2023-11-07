<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Multitienda.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnCategoria" runat="server" Text="Mantenedor de Categoría" OnClick="btnCategoria_Click" />
            <asp:Button ID="btnProducto" runat="server" Text="Mantenedor de Producto" OnClick="btnProducto_Click" />
        </div>
    </form>
</body>
</html>
