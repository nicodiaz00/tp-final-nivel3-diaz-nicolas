<%@ Page Title="" Language="C#" MasterPageFile="~/masterDefault.Master" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="interfaz.Formulario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="js/script.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server" ID="scritpmanager1"></asp:ScriptManager>

    <div class="div-formulario-main">

        <div class="titulo">
            <h2>Nuevo Articulo</h2>
        </div>
        <div class="contedor-cargar-articulo">
            <div class="contenedor-form-and-image">
                <div class="formulario-articulos">
                    <div class="div-form-carga">
                        <label for="ID" class="label-carga">ID</label>
                        <asp:TextBox runat="server" ID="txtId" CssClass="txtbox-carga"></asp:TextBox>
                    </div>
                    <div class="div-form-carga">
                        <label for="Codigo" class="label-carga">Codigo</label>
                        <asp:TextBox runat="server" ID="txtCodigo" CssClass="txtbox-carga"></asp:TextBox>
                    </div>
                    <div class="div-form-carga">
                        <label for="Nombre" class="label-carga">Nombre</label>
                        <asp:TextBox runat="server" ID="txtNombre" CssClass="txtbox-carga"></asp:TextBox>
                    </div>
                    <div class="div-form-carga-descripcion">
                        <label for="Descripcion" class="label-carga">Descripcion</label>
                        <asp:TextBox runat="server" ID="txtDescripcion" CssClass="txtbox-descripcion" TextMode="MultiLine"></asp:TextBox>
                    </div>

                    <div class="div-form-carga">

                        <label for="Marca" class="label-carga">Marca</label>
                        <asp:DropDownList runat="server" ID="ddlMarca" CssClass="txtbox-carga"></asp:DropDownList>

                    </div>
                    <div class="div-form-carga">

                        <label for="Categoria" class="label-carga">Categoria</label>
                        <asp:DropDownList runat="server" ID="ddlCategoria" CssClass="txtbox-carga"></asp:DropDownList>



                    </div>
                    <div class="div-form-carga">
                        <label for="Precio" class="label-carga">Precio</label>
                        <asp:TextBox CssClass="txtbox-carga" ID="txtPrecio" runat="server"></asp:TextBox>
                    </div>
                    <!--<asp:UpdatePanel runat="server" ID="updatePanel">
                        <ContentTemplate>-->
                    <div class="div-form-carga">
                        <label for="urlImagen" class="label-carga">Imagen</label>
                        <asp:TextBox CssClass="txtbox-carga" ID="txtImagen" runat="server" AutoPostBack="false" OnTextChanged="txtImagen_TextChanged"></asp:TextBox>
                        <!-- </ContentTemplate>
                    </asp:UpdatePanel>
                    -->
                    </div>
                    <div class="div-form-btn">
                        <asp:Button runat="server" ID="btnCargarArticulo" CssClass="btn-cargar-articulo" Text="Cargar" OnClick="btnCargarArticulo_Click" />
                        <asp:Button runat="server" ID="btnCancelarArticulo" CssClass="btn-cancelar-articulo" Text="Cancelar" OnClick="btnCancelarArticulo_Click" />


                    </div>
                </div>
                <!--<asp:UpdatePanel runat="server" ID="updatePanel1">
                <ContentTemplate>-->
                <div class="div-imagen-articulo">

                    <asp:Image ID="Image1" runat="server" ImageUrl="https://img.freepik.com/free-vector/illustration-gallery-icon_53876-27002.jpg" CssClass="asp-imagen-articulo" />
                </div>
                <!--</ContentTemplate>
            </asp:UpdatePanel>-->
            </div>





        </div>
        <div class="panel-confirmarcion">
            <asp:Panel ID="pnlMensaje" runat="server" CssClass="mensaje-exito" Visible="false">
                <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label><br />
                <asp:Button ID="btnAceptarMensaje" runat="server" Text="Aceptar" OnClick="btnAceptarMensaje_Click" />
            </asp:Panel>
        </div>

    </div>




</asp:Content>
