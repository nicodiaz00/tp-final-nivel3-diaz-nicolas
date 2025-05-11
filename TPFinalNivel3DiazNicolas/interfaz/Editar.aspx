<%@ Page Title="" Language="C#" MasterPageFile="~/masterDefault.Master" AutoEventWireup="true" CodeBehind="Editar.aspx.cs" Inherits="interfaz.Editar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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

                <asp:TextBox runat="server" ID="txtUrlImagen" CssClass="textbox-formulario"></asp:TextBox>
                <asp:Label runat="server" AssociatedControlID="txtPrecio" CssClass="label-formulario">Precio</asp:Label>

                <asp:TextBox runat="server" ID="txtPrecio" CssClass="textbox-formulario"></asp:TextBox>
                <asp:Label runat="server" AssociatedControlID="ddlMarca" CssClass="label-formulario">Marca</asp:Label>

                <asp:DropDownList runat="server" ID="ddlMarca" CssClass="ddl"></asp:DropDownList>
                <asp:Label runat="server" AssociatedControlID="ddlCategoria" CssClass="label-formulario">Categoria</asp:Label>

                <asp:DropDownList runat="server" ID="ddlCategoria" CssClass="ddl"></asp:DropDownList>

            </div>
            <div class="contendor-imagen">

            </div>
        </div>
    </div>
</asp:Content>
