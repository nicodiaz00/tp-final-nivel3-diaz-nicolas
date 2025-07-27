<%@ Page Title="" Language="C#" MasterPageFile="~/masterDefault.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="interfaz.Registro1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server"  />
    <asp:UpdatePanel runat="server" ID="updatePanel1">
        <ContentTemplate>
            <div class="contenedor-main-registro">
                <div class="contendor-registro">
                    <div class="contenedor-form">

                    </div>
                    <div class="contendor-img-perfil">
                        <div class="">
    <label for="Nombre" class="form-label">Nombre</label>
    <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control"></asp:TextBox>
</div>
<div class="">
    <label for="Apellido" class="form-label">Apellido</label>
    <asp:TextBox runat="server" ID="txtApellido" CssClass="form-control"></asp:TextBox>
</div>
<div class="">
    <label for="Email" class="form-label">Email</label>
    <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control"></asp:TextBox>
</div>

<div class="">
    <label for="Contraseña" class="form-label">Contraseña</label>
    <asp:TextBox runat="server" ID="txtContrasena" CssClass="form-control"></asp:TextBox>
</div>
<div class="">
    <asp:Button runat="server" ID="btnRegistro" OnClick="btnRegistro_Click" CssClass="btnRegistro" Text="Registrate" />
</div>
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>


   



</asp:Content>
