<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Form_Hotel.aspx.cs" Inherits="Form_Hotel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlace_Encabezado" runat="Server">
    <title>Formulario Hotel</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlace_Form" runat="Server">
    <div>
        <label>Hotel</label>
        <asp:TextBox runat="server" ID="txt_nombre" CssClass="form-control" />
    </div>
    <div>
        <label>Telefono</label>
        <asp:TextBox ID="txt_telefono" runat="server" CssClass="form-control" />
    </div>
    <div>
        <label>CUIT</label>
        <asp:TextBox ID="txt_cuit" runat="server" CssClass="form-control" />
    </div>
    <div>
        <label>Temporada</label>
        <asp:DropDownList ID="ddl_temporada" runat="server" CssClass="form-control" />
    </div>
    <div>
        <label>Precio</label>
        <asp:TextBox ID="txt_precio" runat="server" CssClass="form-control" />
    </div>
    <div>
        <label>Categoria</label>
        <asp:DropDownList ID="ddl_categoria" runat="server" CssClass="form-control" />
    </div>
    <div>
        <label>Ciudad</label>
        <asp:DropDownList ID="ddl_ciudad" runat="server" CssClass="form-control" />
    </div>
    <br />

    <div>
        <asp:Button Text="Guardar" ID="btn_guardar" OnClick="btn_guardar_Click" runat="server" CssClass="btn btn-success" />
        <asp:Button Text="Consultar" ID="btn_consultar" OnClick="btn_consultar_Click" runat="server" CssClass="btn btn-primary" />
        <asp:Button Text="Eliminar" ID="btn_eliminar" OnClick="btn_eliminar_Click" runat="server" CssClass="btn btn-danger" Enabled="false" />
    </div>
    <div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlace_Pie" runat="Server">
</asp:Content>

