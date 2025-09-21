<%@ Page Title="" Language="C#" MasterPageFile="~/masterDefault.Master" AutoEventWireup="true" CodeBehind="Validacion.aspx.cs" Inherits="interfaz.Validacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="contenedor-validacion">
        <asp:Label runat="server" ID="lblValidacion" Text=""></asp:Label>
        <asp:Button runat="server" Text="Volver" ID="btVolverInicio" CssClass="" OnClick="btVolverInicio_Click"/>
    </div>
    
</asp:Content>
