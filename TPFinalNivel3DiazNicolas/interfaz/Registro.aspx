<%@ Page Title="" Language="C#" MasterPageFile="~/masterDefault.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="interfaz.Registro1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-6 col-md-6">
            <div class="contenedorRegistro">
                <div class="titulo">
                    <h2>Registrate</h2>
                </div>

                <div class="contenedor-form">
                    <div class="mb-4">
                        <label for="Nombre" class="form-label">Nombre</label>
                        <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="mb-4">
                        <label for="Apellido" class="form-label">Apellido</label>
                        <asp:TextBox runat="server" ID="txtApellido" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="mb-4">
                        <label for="Email" class="form-label">Email</label>
                        <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control"></asp:TextBox>
                    </div>

                    <div class="mb-4">
                        <label for="Contraseña" class="form-label">Contraseña</label>
                        <asp:TextBox runat="server" ID="txtContrasena" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="mb-4">
                        <asp:Button runat="server" ID="btnRegistro" OnClick="btnRegistro_Click" CssClass="btnRegistro" Text="Registrate" />
                    </div>
                </div>


            </div>
        </div>
        <div class="col-6 col-md-6">
            <div class="contenedorLogin">
                <div class="titulo">
                    <h2>Inicia sesion</h2>
                </div>
                <div class="contenedor-form">
                    <div class="mb-4">
                        <label for="emailUsuario" class="form-label">Email</label>
                        <asp:TextBox runat="server" ID="txtEmailUsuario" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="mb-4">
                        <label for="emailUsuario" class="form-label">Contraseña</label>
                        <asp:TextBox runat="server" ID="txtContrasenaUsuario" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="mb-4">
                        <asp:Button runat="server" ID="btnLogin" OnClick="btnLogin_Click" CssClass="btnRegistro" Text="Inicia Sesion" />
                    </div>
                    <div class="mb-4">
                        <asp:Label runat="server" ID="lblLogueado" Text=""></asp:Label>
                    </div>
                </div>

            </div>
        </div>
    </div>
</asp:Content>
