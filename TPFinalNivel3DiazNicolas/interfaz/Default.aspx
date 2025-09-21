<%@ Page Title="" Language="C#" MasterPageFile="~/masterDefault.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="interfaz.Default" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="row-art">
        <div class="carrusel-container">
        </div>
    </div>
    <div class="columnacard">
        <asp:Repeater runat="server" ID="repArticulo">
            <ItemTemplate>
                <div class="card">
                    <div class="contenedor-img">
                        <img src="<%#Eval("ImagenUrl") %>" class="img-articulo" alt="imagen articulo: <%#Eval("Nombre")%>">
                    </div>
                    <div class="card-body">
                        <h5 class="card-title"><%#Eval("Nombre")%></h5>
                        <p class="card-text"><%#Eval("Descripcion")%></p>                        
                    </div>
                    <div class="btn-card">
                        <asp:Button runat="server" ID="btnIdArticulo" Text="Seleccionar" CssClass="btnIdArticulo" CommandArgument='<%#Eval("Id")%>' CommandName="IdArticulo" OnClick="btnIdArticulo_Click" />
                        <asp:Button runat="server" ID="btnFavorito" Text="Detalle" CssClass="btn-favorito" CommandArgument='<%#Eval("Id")%>' CommandName="IdArticulo" OnClick="btnFavorito_Click"  />
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    <script src="Js/script.js"></script>
</asp:Content>
