<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Form_Hotel.aspx.cs" Inherits="Form_Hotel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlace_Encabezado" Runat="Server">
    <title>Formulario Hotel</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlace_Form" Runat="Server">
    <div>
        <label>Hotel</label>
        <asp:TextBox runat="server" id="txt_nombre" CssClass="form-control"/>
    </div>
    <div>
        <label>Telefono</label>
        <asp:TextBox ID="txt_telefono" runat="server"/>
    </div>
    <div>
        <label>CUIT</label>
        <asp:TextBox ID="txt_cuit" runat="server" />
    </div>
    <div>
        <label>Temporada</label>
        <asp:DropDownList ID="ddl_temporada" runat="server" />
    </div>
    <div>
        <label>Precio</label>
        <asp:TextBox ID="txt_precio" runat="server" />
    </div>
    <div>
        <label>Categoria</label>
        <asp:DropDownList ID="ddl_categoria" runat="server" />
    </div>
    <div>
        <label>Ciudad</label>
        <asp:DropDownList ID="ddl_ciudad" runat="server" />
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlace_Pie" Runat="Server">
</asp:Content>

