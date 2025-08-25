<%@ Page Title="" Language="C#" MasterPageFile="~/masterDefault.Master" AutoEventWireup="true" CodeBehind="Salida.aspx.cs" Inherits="interfaz.Salida" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="contenedor-log-out">
        <asp:Label runat="server" ID="lblSalida" Text="Cerraste sesion"></asp:Label>
        <asp:Button runat="server" ID="btnVolverInicio" OnClick="btnVolverInicio_Click" Text="Volver" />
    </div>

</asp:Content>
