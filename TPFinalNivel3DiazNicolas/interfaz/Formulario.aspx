<%@ Page Title="" Language="C#" MasterPageFile="~/masterDefault.Master" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="interfaz.Formulario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server" ID="scritpmanager1"></asp:ScriptManager>
    <asp:UpdatePanel runat="server" ID="updatePanel">
        <ContentTemplate>
            <div class="rowFormulario">
                <div class="col-8">
                    <div class="container">
                        <h2>Carga de articulos al inventario</h2>

                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-8">
                    <div class="mb-4">
                        <label for="ID" class="form-label">ID</label>
                        <asp:TextBox runat="server" ID="txtId" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="mb-4">
                        <label for="Codigo" class="form-label">Codigo</label>
                        <asp:TextBox runat="server" ID="txtCodigo" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="mb-4">
                        <label for="Nombre" class="form-label">Nombre</label>
                        <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="mb-4">
                        <label for="Descripcion" class="form-label">Descripcion</label>
                        <asp:TextBox runat="server" ID="txtDescripcion" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                    </div>

                    <div class="mb-4">
                        <div>
                            <label for="Marca" class="form-label">Marca</label>
                        </div>
                        <div>
                            <asp:DropDownList runat="server" ID="ddlMarca"></asp:DropDownList>
                        </div>


                    </div>
                    <div class="mb-4">
                        <div>
                            <label for="Categoria" class="form-label">Categoria</label>
                        </div>
                        <div>
                            <asp:DropDownList runat="server" ID="ddlCategoria"></asp:DropDownList>
                        </div>
                    </div>
                    <div class="mb-4">
                        <label for="Precio" class="form-label">Precio</label>
                        <asp:TextBox CssClass="form-control" ID="txtPrecio" runat="server"></asp:TextBox>
                    </div>


                </div>
                <div class="col-4">
                    <div class="mb-4">
                        <label for="urlImagen" class="form-label">Imagen</label>
                        <asp:TextBox CssClass="form-control" ID="txtImagen" runat="server"></asp:TextBox>
                    </div>
                    <asp:Image ID="Image1" runat="server" ImageUrl="https://img.freepik.com/free-vector/illustration-gallery-icon_53876-27002.jpg"/>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>


</asp:Content>
