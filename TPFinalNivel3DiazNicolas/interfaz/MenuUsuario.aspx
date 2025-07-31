<%@ Page Title="" Language="C#" MasterPageFile="~/masterDefault.Master" AutoEventWireup="true" CodeBehind="MenuUsuario.aspx.cs" Inherits="interfaz.MenuUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="contenedor-main-usuario">
        <%if (Session["usuario"] == null)
            {%>
        <div class="contendor-login">
            <div class="contendor-user">
                <label for="usuarioText" class="label-user">Usuario</label>
                <asp:TextBox runat="server" ID="emailUserTxt" CssClass="txtUser"></asp:TextBox>
            </div>
            <div class="contendor-pass">
                <label for="usuarioPass" class="label-user-pass">Contraseña</label>
                <asp:TextBox runat="server" ID="emailPassTxt" CssClass="txtPass"></asp:TextBox>

            </div>
            <div class="contendor-btn">
                <asp:Button runat="server" ID="btnIniciarS" Text="Iniciar Sesion" CssClass="btn-login" OnClick="btnIniciarS_Click" />
                <asp:Button runat="server" ID="btnVolver" OnClick="btnVolver_Click" Text="Volver" CssClass="btn-login" />
            </div>

        </div>
        <%}
            else
            {%>
        <div class="titulo">
            <h3>Panel Usuario</h3>
        </div>
        <div class="panel-perfil">


            <div class="contenedor-perfil-user">
                <div class="">
                    <label for="Nombre" class="form-label">Nombre</label>
                    <asp:TextBox runat="server" ID="usuarioTxt" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="">
                    <label for="Apellido" class="form-label">Apellido</label>
                    <asp:TextBox runat="server" ID="apellidoTxt" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="">
                    <label for="Email" class="form-label">Email</label>
                    <asp:TextBox runat="server" ID="emailTxt" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="">
                    <label for="imgPerfil" class="form-label">Imagen Perfil</label>
                    <asp:TextBox runat="server" ID="perfilTxt" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-4 btn-gestion">
                    <asp:Button runat="server" ID="btnGestion" Text="Gestionar sitio" CssClass="btn btn-primary" OnClick="btnGestion_Click" />
                    <asp:Button runat="server" ID="btnEditarPerfil" Text="Editar perfil" CssClass="btn btn-primary" OnClick="btnEditarPerfil_Click" />
                    <asp:Button runat="server" ID="btnGuardarPerfil" Text="Guardar" CssClass="btn btn-primary" Enabled="false" />
                </div>

            </div>
            <div class="imagenPerfil">
                <img src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQl_3sn9SlQEcL6AhZ1ASxPzR7mu6Xzf9Hacw&s" class="img-usuario" alt="Imagen perfil" />
            </div>
        </div>


        <%} %>
    </div>













</asp:Content>
