<%@ Page Title="" Language="C#" MasterPageFile="~/masterDefault.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="interfaz.Error" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="contenedor-main-error">
        <div class="contenedor-error">
            <asp:Label runat="server" ID="lblError" Text="hubo un error"></asp:Label>
            <asp:Button runat="server" Text="Volver" OnClick="Unnamed_Click" CssClass="btn-volver" />
        </div>
    </div>


</asp:Content>
