<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Categoria.aspx.cs" Inherits="Multitienda.Categoria1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Mantenedor de Categoría</h1>
            <asp:Label ID="lblErrorMessage" runat="server" ForeColor="Red"></asp:Label>

            <div>
                <label>ID de Categoría:</label>
                <asp:TextBox ID="txtIdCategoria" runat="server"></asp:TextBox>
            </div>

            <div>
                <label>Nombre de Categoría:</label>
                <asp:TextBox ID="txtNombreCategoria" runat="server"></asp:TextBox>
            </div>


            <br />

            <asp:GridView ID="GridViewCategories" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="IdCategoria" HeaderText="ID de Categoría" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre de Categoría" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnEdit" runat="server" Text="Editar" OnClick="btnEdit_Click" CommandArgument='<%# Eval("IdCategoria") %>' />
                            <asp:Button ID="btnDelete" runat="server" Text="Eliminar" OnClick="btnDelete_Click" CommandArgument='<%# Eval("IdCategoria") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>

            <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="Multitienda.MultitiendaEDM" EntityTypeName="" Select="new (IdCategoria, nombre, Productoes)" TableName="Categorias">
            </asp:LinqDataSource>

            <br />

            <asp:Button ID="btnActualizarCategoria" runat="server" Text="Actualizar Categoría" OnClick="btnActualizarCategoria_Click" />

            <br />

            <asp:HyperLink ID="lnkBackToIndex" runat="server" Text="Volver al Inicio" NavigateUrl="Inicio.aspx" />
        </div>
    </form>
</body>
</html>
