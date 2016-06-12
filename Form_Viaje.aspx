<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Form_Viaje.aspx.cs" Inherits="Form_Viaje" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlace_Encabezado" runat="Server">
    <title>Formulario Viaje</title>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlace_Form" runat="Server">

    <div>
        <h1>Formulario Viaje</h1>
    </div>
    <div>
        <label>Ciudad de Origen</label>
        <asp:TextBox runat="server" ID="txt_origen" CssClass="form-control" />
    </div>
    <div>
        <label>Ciudad de Destino</label>
        <asp:TextBox runat="server" ID="txt_destino" CssClass="form-control" />
    </div>    
    <div >
        <label>Fecha Desde</label>        
            <asp:TextBox class="form-control" id="txt_fechaDesde" runat="server"></asp:TextBox>
             <%--<span class="input-group-addon">
                <span class="glyphicon glyphicon-calendar"></span>
            </span> --%>       
        <label>Fecha Hasta</label>        
            <asp:TextBox class="form-control" id="txt_fechaHasta" runat="server"></asp:TextBox>
            <%--<span class="input-group-addon">
                <span class="glyphicon glyphicon-calendar"></span>
            </span> --%>       
    </div>
   
    <br />
    <div>
        <asp:CheckBox Text="Solo Ida" runat="server" ID="ckb_soloIda" CssClass="form-control" />
    </div>
    <div>
        <label>Precio Total</label>
        <asp:TextBox ID="txt_precio" runat="server" CssClass="form-control" />
    </div>
    <div>
        <label>Transporte</label>
        <asp:DropDownList runat="server" ID="ddl_transporte" CssClass="form-control"></asp:DropDownList>
    </div>
    <div>
        <label>Temporada</label>
        <asp:DropDownList runat="server" ID="ddl_temporada" CssClass="form-control"></asp:DropDownList>
    </div>
    <br />
    <div>
        <asp:Button Text="Guardar" ID="btn_guardar" OnClick="btn_guardar_Click" runat="server" CssClass="btn btn-success" />
        <asp:Button Text="Eliminar" ID="btn_elimnar" OnClick="btn_elimnar_Click" runat="server" CssClass="btn btn-danger" />
        
    </div>

    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlace_Pie" runat="Server">
    <script type="text/javascript">
        $(function () {
            $('#div_fechaDesde').datetimepicker();
            $('#div_fechaHasta').datetimepicker({
                useCurrent: false //Important! See issue #1075
            });
            $("#div_fechaDesde").on("dp.change", function (e) {
                $('#div_fechaHasta').data("DateTimePicker").minDate(e.date);
            });
            $("#div_fechaHasta").on("dp.change", function (e) {
                $('#div_fechaDesde').data("DateTimePicker").maxDate(e.date);
            });
        });
    </script>
</asp:Content>

