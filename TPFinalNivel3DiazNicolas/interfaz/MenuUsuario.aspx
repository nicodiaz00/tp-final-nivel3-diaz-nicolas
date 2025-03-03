<%@ Page Title="" Language="C#" MasterPageFile="~/masterDefault.Master" AutoEventWireup="true" CodeBehind="MenuUsuario.aspx.cs" Inherits="interfaz.MenuUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row row-panel">
        <div class="col-12">

            <div class="panelUsuario">
                <%if (Session["usuario"] == null)
                    {%>
                <div class="">
                    <h3>No iniciaste session</h3>
                    <asp:Button runat="server" ID="btnVolver" OnClick="btnVolver_Click" Text="Volver" CssClass="btn btn-primary" />
                </div>
                <%}
                    else
                    {%>
                <div class="panel-perfil">
                    <div class="titulo">
                        <h3>Panel Usuario</h3>
                    </div>

                    <div class="">
                        <div class="mb-4">
                            <label for="Nombre" class="form-label">Nombre</label>
                            <asp:TextBox runat="server" ID="usuarioTxt" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="mb-4">
                            <label for="Apellido" class="form-label">Apellido</label>
                            <asp:TextBox runat="server" ID="apellidoTxt" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="mb-4">
                            <label for="Email" class="form-label">Email</label>
                            <asp:TextBox runat="server" ID="emailTxt" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="mb-4">
                            <label for="imgPerfil" class="form-label">Imagen Perfil</label>
                            <asp:TextBox runat="server" ID="perfilTxt" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="mb-4">
                        </div>
                    </div>
                </div>
                <div class="imagenPerfil">
                    <img src="#" class="" alt="Imagen perfil" />
                </div>
                <%}
                %>
            </div>
        </div>

    </div>


</asp:Content>
