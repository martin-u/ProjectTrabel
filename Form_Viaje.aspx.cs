using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dao;
using Entidades;

public partial class Form_Viaje : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            cargarComboTransporte();
            cargarComboTemporada();
        }
    }

    protected void btn_guardar_Click(object sender, EventArgs e)
    {
        ViajeEntidad viaje = new ViajeEntidad();
        //Aca tengo que hacer un metodo para que a medida que ingreso el nombre me busque en la BD
        viaje.idCiudadDestino = int.Parse(txt_destino.Text);
        viaje.idCiudadOrigen = int.Parse(txt_origen.Text);
        viaje.fechaDesde = DateTime.Parse(txt_fechaDesde.Text);
        viaje.fechaHasta = DateTime.Parse(txt_fechaHasta.Text);
        viaje.soloIda = ckb_soloIda.Checked;
        viaje.precioTotal = float.Parse(txt_precio.Text);
        viaje.idTransporte = int.Parse(ddl_transporte.SelectedValue);
        viaje.idTemporada = int.Parse(ddl_temporada.SelectedValue);

        ViajeDao.registrarViaje(viaje);

    }

    public void cargarComboTransporte()
    {
        ddl_transporte.DataSource = Dao.TransporteDao.consultarTransporte();
        ddl_transporte.DataValueField = "idTransporte";
        ddl_transporte.DataTextField = "nombre";
        ddl_transporte.DataBind();
    }

    public void cargarComboTemporada()
    {
        ddl_temporada.DataSource = Dao.TemporadaDao.consultarTemporada();
        ddl_temporada.DataValueField = "idTemporada";
        ddl_temporada.DataTextField = "nombre";
        ddl_temporada.DataBind();
    }

    protected void btn_elimnar_Click(object sender, EventArgs e)
    {

    }
}