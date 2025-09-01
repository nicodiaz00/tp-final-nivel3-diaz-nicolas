<%@ Page Title="" Language="C#" MasterPageFile="~/masterDefault.Master" AutoEventWireup="true" CodeBehind="Editar.aspx.cs" Inherits="interfaz.Editar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server" ID="ScriptManager1"></asp:ScriptManager>
    <div class="contendor-editar">
        <div class="contenedor-titulo-editar">
            <h2>Editar Articulo</h2>
        </div>
        <div class="contenedor-formulario-editar">
            <div class="formulario">
                <asp:Label runat="server" AssociatedControlID="txtCodigo" CssClass="label-formulario">Código</asp:Label>
                <asp:TextBox runat="server" ID="txtCodigo" CssClass="textbox-formulario"></asp:TextBox>
                <asp:Label runat="server" AssociatedControlID="txtNombre" CssClass="label-formulario">Nombre</asp:Label>

                <asp:TextBox runat="server" ID="txtNombre" CssClass="textbox-formulario"></asp:TextBox>
                <asp:Label runat="server" AssociatedControlID="txtDescripcion" CssClass="label-formulario">Descripcion</asp:Label>

                <asp:TextBox runat="server" ID="txtDescripcion" TextMode="MultiLine" CssClass="textbox-formulario"></asp:TextBox>
                <asp:Label runat="server" AssociatedControlID="txtUrlImagen" CssClass="label-formulario">Imagen</asp:Label>
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <asp:TextBox runat="server" ID="txtUrlImagen" CssClass="textbox-formulario" OnTextChanged="txtUrlImagen_TextChanged" AutoPostBack="true"></asp:TextBox>
                    </ContentTemplate>
                </asp:UpdatePanel>

                <asp:Label runat="server" AssociatedControlID="txtPrecio" CssClass="label-formulario">Precio</asp:Label>

                <asp:TextBox runat="server" ID="txtPrecio" CssClass="textbox-formulario"></asp:TextBox>
                <asp:Label runat="server" AssociatedControlID="ddlMarca" CssClass="label-formulario">Marca</asp:Label>

                <asp:DropDownList runat="server" ID="ddlMarca" CssClass="ddl"></asp:DropDownList>
                <asp:Label runat="server" AssociatedControlID="ddlCategoria" CssClass="label-formulario">Categoria</asp:Label>

                <asp:DropDownList runat="server" ID="ddlCategoria" CssClass="ddl"></asp:DropDownList>

            </div>

            <div class="contendor-imagen">
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <asp:Image runat="server" ID="aspImageEditarArticulo" CssClass="asp-imagen-editar-articulo" ImageUrl="https://img.freepik.com/free-vector/illustration-gallery-icon_53876-27002.jpg" />
                    </ContentTemplate>
                </asp:UpdatePanel>

            </div>
        </div>
        <div class="contenedor-botones">
            <asp:Button runat="server" Text="Guardar" ID="btnGuardarEdicion" CssClass="btn-panel-edicion" OnClick="btnGuardarEdicion_Click" />
            <asp:Button runat="server" Text="Eliminar" ID="btnEliminarArticulo" CssClass="btn-panel-edicion" OnClick="btnEliminarArticulo_Click" />
            <asp:Button runat="server" Text="Cancelar" ID="btnCancelarEdicion" CssClass="btn-panel-edicion" OnClick="btnCancelarEdicion_Click" />
        </div>
    </div>
</asp:Content>
