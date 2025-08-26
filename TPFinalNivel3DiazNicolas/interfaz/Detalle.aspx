<%@ Page Title="" Language="C#" MasterPageFile="~/masterDefault.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="interfaz.Detalle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="contenedor-detalle">
      <asp:Repeater runat="server" ID="detalleArticulo">
     <ItemTemplate>
         <div class="card">
             <div class="contenedor-img">
                 <img src="<%#Eval("ImagenUrl") %>" class="img-articulo" alt="imagen articulo: <%#Eval("Nombre")%>">
             </div>

             <div class="card-body">
                 <h5 class="card-title"><%#Eval("Nombre")%></h5>
                 <p class="card-text"><%#Eval("Descripcion")%></p>


             </div>
             
         </div>
     </ItemTemplate>
 </asp:Repeater>
        <div class="btn-detalle">
            <asp:Button runat="server" Text="Volver" ID="btnVolver" OnClick="btnVolver_Click" CssClass="btn-volver"/>
        </div>
    </div>
</asp:Content>
