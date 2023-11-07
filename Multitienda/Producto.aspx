<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Producto.aspx.cs" Inherits="Multitienda.Producto1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Mantenedor de Productos</h1>
            <asp:Label ID="lblErrorMessage" runat="server" ForeColor="Red"></asp:Label>

            <div>
                <label>ID de Producto:</label>
                <asp:TextBox ID="txtIdProducto" runat="server"></asp:TextBox>
            </div>

            <div>
                <label>Nombre de Producto:</label>
                <asp:TextBox ID="txtNombreProducto" runat="server"></asp:TextBox>
            </div>

            <div>
                <label>Descripción:</label>
                <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
            </div>

            <div>
                <label>Categoría:</label>
                <asp:DropDownList ID="ddlCategoria" runat="server">
                    <asp:ListItem Text="Category 1" Value="1" />
                </asp:DropDownList>
            </div>

            <br />

            <asp:GridView ID="GridViewProductos" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="idProducto" HeaderText="ID de Producto" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre de Producto" />
                    <asp:BoundField DataField="Descripcion" HeaderText="Descripción" />
                    <asp:BoundField DataField="idCategoria" HeaderText="Categoría" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnEdit" runat="server" Text="Editar" OnClick="btnEdit_Click" CommandArgument='<%# Eval("IdProducto") %>' />
                            <asp:Button ID="btnDelete" runat="server" Text="Eliminar" OnClick="btnDelete_Click" CommandArgument='<%# Eval("IdProducto") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>

            <asp:LinqDataSource ID="LinqDataSourceProductos" runat="server" ContextTypeName="Multitienda.MultitiendaEDM" EntityTypeName="" Select="new (IdProducto, Nombre, Descripcion, Categoria)" TableName="Productos">
            </asp:LinqDataSource>

            <br />

            <asp:Button ID="btnActualizarProducto" runat="server" Text="Actualizar Producto" OnClick="btnActualizarProducto_Click" />

            <br />

            <asp:HyperLink ID="lnkBackToIndex" runat="server" Text="Volver al Inicio" NavigateUrl="Inicio.aspx" />
        </div>
    </form>
</body>
</html>
