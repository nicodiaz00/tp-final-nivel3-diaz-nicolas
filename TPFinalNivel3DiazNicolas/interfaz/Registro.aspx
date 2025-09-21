<%@ Page Title="" Language="C#" MasterPageFile="~/masterDefault.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="interfaz.Registro1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server" />
    <asp:UpdatePanel runat="server" ID="updatePanel1">
        <ContentTemplate>
            <div class="contenedor-main-registro">
                <div class="contenedor-registro">
                    <div class="contenedor-form">
                        <div class="div-form">
                            <label for="txtNombre" class="form-label">Nombre</label>
                            <asp:TextBox runat="server" ID="txtNombre" CssClass="txtbox-form" ClientIDMode="Static"></asp:TextBox>
                            <asp:RequiredFieldValidator ErrorMessage="Nombre requerido" ControlToValidate="txtNombre" runat="server" CssClass="validator-style" />
                        </div>
                        <div class="div-form">
                            <label for="txtApellido" class="form-label">Apellido</label>
                            <asp:TextBox runat="server" ID="txtApellido" CssClass="txtbox-form" ClientIDMode="Static"></asp:TextBox>
                            <asp:RequiredFieldValidator ErrorMessage="Apellido requerido" ControlToValidate="txtApellido" runat="server" CssClass="validator-style" />
                        </div>
                        <div class="div-form">
                            <label for="txtEmail" class="form-label">Email</label>
                            <asp:TextBox runat="server" ID="txtEmail" CssClass="txtbox-form" ClientIDMode="Static"></asp:TextBox>
                            <asp:RequiredFieldValidator ErrorMessage="Email requerido" ControlToValidate="txtEmail" runat="server" CssClass="validator-style" />
                        </div>

                        <div class="div-form">
                            <label for="txtContrasena" class="form-label">Contraseña</label>
                            <asp:TextBox runat="server" ID="txtContrasena" CssClass="txtbox-form" TextMode="Password" ClientIDMode="Static"></asp:TextBox>
                            <asp:RequiredFieldValidator ErrorMessage="Contraseña requerida" ControlToValidate="txtContrasena" runat="server" CssClass="validator-style" />
                        </div>
                        <div class="div-form">
                            <asp:Button runat="server" ID="btnRegistro" OnClick="btnRegistro_Click" CssClass="btnRegistro" Text="Registrate" />
                        </div>
                    </div>
                    
                </div>
                <asp:Label runat="server" Text="" ID="lblRegistrado"></asp:Label>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>






</asp:Content>
