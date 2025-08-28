<%@ Page Title="" Language="C#" MasterPageFile="~/masterDefault.Master" AutoEventWireup="true" CodeBehind="Listado.aspx.cs" Inherits="interfaz.Listado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server"></asp:ScriptManager>
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <div class="contenedor-listado-main">
                <div class="titulo-listado">
                    <h2>ARTICULOS</h2>
                </div>
                <div class="contendor-busqueda-articulos">
                    <div class="contenedor-txt-busqueda">
                        <label for="txtBusqueda">Buscar</label>
                        <asp:TextBox runat="server" AutoPostBack="true" ID="txtBusqueda" OnTextChanged="txtBusqueda_TextChanged" CssClass="input-busqueda"></asp:TextBox>
                    </div>
                    <div class="contenedor-check">
                        <asp:CheckBox ID="checkBoxBusquedaAvanzada" Text="Busqueda avanzada" runat="server" Checked="false" OnCheckedChanged="checkBoxBusquedaAvanzada_CheckedChanged" AutoPostBack="true" />
                    </div>



                </div>
                <div class="columnaBusquedaAvanzada">
                    <div class="contenedor-1">
                        <div class="contenedor-campo">
                            <label for="ddlCampo">Campo</label>
                            <asp:DropDownList runat="server" ID="ddlCampo" OnSelectedIndexChanged="ddlCampo_SelectedIndexChanged" AutoPostBack="true" CssClass="ddl-campo">
                                <asp:ListItem Text="Codigo"></asp:ListItem>
                                <asp:ListItem Text="Nombre"></asp:ListItem>
                                <asp:ListItem Text="Precio"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="contenedor-criterio">
                            <label for="ddlCriterio">Criterio</label>
                            <asp:DropDownList runat="server" ID="ddlCriterio" CssClass="ddl-criterio"></asp:DropDownList>
                        </div>
                    </div>
                    <div class="contenedor-2">
                        <div class="contenedor-filtro">
                            <label for="ddlFiltro">Filtro</label>
                            <asp:TextBox runat="server" ID="txtFiltro" CssClass="input-filtro"></asp:TextBox>

                        </div>

                        <div class="contenedorBtnBusqueda">
                            <asp:Button runat="server" ID="btnBuscar" Text="Buscar" OnClick="btnBuscar_Click" CssClass="btn-buscar-avanzado" />
                        </div>
                    </div>



                </div>
                <div class="contenedor-listado-articulo">
                    <div class="contenedor-aux-dgv">
                        <asp:GridView runat="server" ID="dgvArticulos" AutoGenerateColumns="false" CssClass="tabladgv" OnSelectedIndexChanged="dgvArticulos_SelectedIndexChanged" DataKeyNames="Id" OnPageIndexChanging="dgvArticulos_PageIndexChanging" AllowPaging="true" PageSize="5">
                            <Columns>
                                <asp:BoundField HeaderText="ID" DataField="Id" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
                                <asp:BoundField HeaderText="CODIGO" DataField="Codigo" ItemStyle-CssClass="col-codigo" HeaderStyle-CssClass="col-codigo" />
                                <asp:BoundField HeaderText="NOMBRE" DataField="Nombre" ItemStyle-CssClass="col-nombre" HeaderStyle-CssClass="col-nombre" />
                                <asp:BoundField HeaderText="DESCRIPCIÓN" DataField="Descripcion" ItemStyle-CssClass="col-descripcion" HeaderStyle-CssClass="col-descripcion" />
                                <asp:BoundField HeaderText="IDMARCA" DataField="Marca.Id" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
                                <asp:BoundField HeaderText="IDCATEGORIA" DataField="Categoria.Id" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />

                                <asp:BoundField HeaderText="CATEGORIA" DataField="Categoria" ItemStyle-CssClass="col-categoria" HeaderStyle-CssClass="col-categoria" />
                                <asp:BoundField HeaderText="MARCA" DataField="Marca" ItemStyle-CssClass="col-marca" HeaderStyle-CssClass="col-marca" />
                                <asp:BoundField HeaderText="IMAGEN" DataField="ImagenUrl" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
                                <asp:BoundField HeaderText="PRECIO" DataField="Precio" ItemStyle-CssClass="col-precio" HeaderStyle-CssClass="col-precio" />
                                <asp:CommandField ShowSelectButton="true" HeaderText="Editar" SelectText="✍️" ItemStyle-CssClass="col-editar" HeaderStyle-CssClass="col-editar" />
                            </Columns>

                        </asp:GridView>
                    </div>

                </div>

            </div>





        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>
