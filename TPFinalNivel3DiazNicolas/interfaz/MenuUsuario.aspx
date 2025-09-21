<%@ Page Title="" Language="C#" MasterPageFile="~/masterDefault.Master" AutoEventWireup="true" CodeBehind="MenuUsuario.aspx.cs" Inherits="interfaz.MenuUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server" ID="scritpmanager1"></asp:ScriptManager>

    <div class="contenedor-main-usuario">
        <%if (Session["usuario"] == null)
            {%>

        <div class="contendor-login">
            <div class="titulo-login">
                <h3>Inicia Sesion</h3>
            </div>
            <div class="contendor-user">
                <label for="usuarioText" class="label-user">Usuario</label>
                <asp:TextBox runat="server" ID="emailUserTxt" CssClass="txtUser"></asp:TextBox>
            </div>
            <div class="contendor-pass">
                <label for="usuarioPass" class="label-user-pass">Contraseña</label>
                <asp:TextBox runat="server" ID="emailPassTxt" CssClass="txtPass" TextMode="Password" AutoCompleteType="Disabled"></asp:TextBox>
            </div>
            <div class="contendor-btn">
                <asp:Button runat="server" ID="btnIniciarS" Text="Iniciar Sesion" CssClass="btn-login" OnClick="btnIniciarS_Click" />
                <asp:Button runat="server" ID="btnVolver" OnClick="btnVolver_Click" Text="Volver" CssClass="btn-login" />
            </div>
        </div>
        <%}
            else
            {%>
        <div class="panel-perfil">
            <div class="titulo-panel-usuario">
                <h3>Panel Usuario</h3>
            </div>
            <div class="contenedor-panel">
                <div class="contenedor-perfil-user">
                    <div class="div-panel-usuario">
                        <label for="Nombre" class="form-label">Nombre</label>
                        <asp:UpdatePanel runat="server" ID="updatePanel3">
                            <ContentTemplate>
                                <asp:TextBox runat="server" ID="usuarioTxt" CssClass="asp-form"></asp:TextBox>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                    <div class="div-panel-usuario">
                        <label for="Apellido" class="form-label">Apellido</label>
                        <asp:UpdatePanel runat="server" ID="updatePanel14">
                            <ContentTemplate>
                                <asp:TextBox runat="server" ID="apellidoTxt" CssClass="asp-form"></asp:TextBox>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                    <div class="div-panel-usuario">
                        <label for="Email" class="form-label">Email</label>
                        <asp:UpdatePanel runat="server" ID="updatePanel5">
                            <ContentTemplate>
                                <asp:TextBox runat="server" ID="emailTxt" CssClass="asp-form"></asp:TextBox>
                            </ContentTemplate>
                        </asp:UpdatePanel>

                    </div>
                    <div class="div-panel-usuario">
                        <label for="contrasena" class="form-label">Contraseña</label>
                        <asp:UpdatePanel runat="server" ID="updatePanel6">
                            <ContentTemplate>
                                <asp:TextBox runat="server" ID="contrasena" CssClass="asp-form"></asp:TextBox>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                    <div class="div-panel-usuario">
                        <label for="imgPerfil" class="form-label">Imagen Perfil</label>
                        <asp:UpdatePanel runat="server" ID="updatePanel7">
                            <ContentTemplate>
                                <asp:TextBox runat="server" ID="perfilTxt" CssClass="asp-form" AutoPostBack="true" OnTextChanged="perfilTxt_TextChanged"></asp:TextBox>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                </div>
                <div class="imagenPerfil">
                    <asp:UpdatePanel runat="server" ID="updatePanel8">
                        <ContentTemplate>
                            <asp:Image runat="server" ID="aspImagePerfil" CssClass="img-usuario" ImageUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQl_3sn9SlQEcL6AhZ1ASxPzR7mu6Xzf9Hacw&s"/>
                            
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>
            <div class="contenedor-botones-usuario">
                <asp:UpdatePanel runat="server" ID="updatePanel9">
                    <ContentTemplate>
                        <asp:Button runat="server" ID="btnGestion" Text="Gestionar sitio" CssClass="button-panel-usuario" OnClick="btnGestion_Click" />
                        <asp:Button runat="server" ID="btnEditarPerfil" Text="Editar perfil" CssClass="button-panel-usuario" OnClick="btnEditarPerfil_Click" />
                        <asp:Button runat="server" ID="btnGuardarPerfil" Text="Guardar" CssClass="btn-panel-guardar" Enabled="false" OnClick="btnGuardarPerfil_Click" />
                    </ContentTemplate>
                </asp:UpdatePanel>

            </div>
        </div>


        <%} %>
    </div>













</asp:Content>
