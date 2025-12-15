<%@ Page Title="" Language="C#" MasterPageFile="~/masterDefault.Master" AutoEventWireup="true" CodeBehind="Listado.aspx.cs" Inherits="interfaz.Listado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server"></asp:ScriptManager>

    <div class="contenedor-listado-main">
        <div class="titulo-listado">
            <h2>ARTICULOS</h2>
        </div>
        <div class="contendor-busqueda-articulos">
            <div class="contenedor-txt-busqueda">
                <label for="txtBusqueda">Buscar</label>
                <asp:UpdatePanel runat="server" ID="updatepanel1">
                    <ContentTemplate>
                        <asp:TextBox runat="server" AutoPostBack="true" ID="txtBusqueda" OnTextChanged="txtBusqueda_TextChanged" CssClass="input-busqueda"></asp:TextBox>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
            <div class="contenedor-check">
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <asp:CheckBox ID="checkBoxBusquedaAvanzada" Text="Busqueda avanzada" runat="server" Checked="false" OnCheckedChanged="checkBoxBusquedaAvanzada_CheckedChanged" AutoPostBack="true" />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
        <div class="columnaBusquedaAvanzada">
            <div class="contenedor-1">
                <div class="contenedor-campo">
                    <label for="ddlCampo">Campo</label>
                    <asp:UpdatePanel runat="server">
                        <ContentTemplate>
                            <asp:DropDownList runat="server" ID="ddlCampo" OnSelectedIndexChanged="ddlCampo_SelectedIndexChanged" AutoPostBack="true" CssClass="ddl-campo">
                                                       
                            </asp:DropDownList>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
                <div class="contenedor-criterio">
                    <label for="ddlCriterio">Criterio</label>
                    <asp:UpdatePanel runat="server">
                        <ContentTemplate>
                            <asp:DropDownList runat="server" ID="ddlCriterio" CssClass="ddl-criterio"></asp:DropDownList>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>
            <div class="contenedor-2">
                <div class="contenedor-filtro">
                    <label for="ddlFiltro">Filtro</label>
                    <asp:UpdatePanel runat="server">
                        <ContentTemplate>
                            <asp:TextBox runat="server" ID="txtFiltro" CssClass="input-filtro"></asp:TextBox>                            
                            <asp:RegularExpressionValidator ID="regexValidator" runat="server"
                                ControlToValidate="txtFiltro"
                                ErrorMessage="Solo se permiten números y puntos."
                                ForeColor="Red"
                                Display="Dynamic">

                            </asp:RegularExpressionValidator>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
                <div class="contenedorBtnBusqueda">
                    <asp:UpdatePanel runat="server">
                        <ContentTemplate>
                            <asp:Button runat="server" ID="btnBuscar" Text="Buscar" OnClick="btnBuscar_Click" CssClass="btn-buscar-avanzado" />
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>
        </div>
        <div class="contenedor-listado-articulo">
            <div class="contenedor-aux-dgv">
                <asp:UpdatePanel runat="server" ID="updatepanel2">
                    <ContentTemplate>
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
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
    </div>
</asp:Content>
