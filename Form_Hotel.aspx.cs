using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dao;
using Entidades;

public partial class Form_Hotel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            cargarComboTemporada();
            cargarComboCiudad();
            cargarComboCategoria();
        }
    }
    

    protected void cargarComboTemporada()
    {
        ddl_temporada.DataSource = TemporadaDao.consultarTemporada();
        ddl_temporada.DataTextField = "nombre";
        ddl_temporada.DataValueField = "idTemporada";
        ddl_temporada.DataBind();
    }

    protected void cargarComboCategoria()
    {
        ddl_categoria.DataSource = CategoriaDao.consultarCategoria();
        ddl_categoria.DataTextField = "nombre";
        ddl_categoria.DataValueField = "idCategoria";
        ddl_categoria.DataBind();
    }

    protected void cargarComboCiudad()
    {
        ddl_ciudad.DataSource = CiudadOrigenDao.consultarCiudadOrigen();
        ddl_ciudad.DataTextField = "nombreOrigen";
        ddl_ciudad.DataValueField = "idCiudadOrigen";
        ddl_ciudad.DataBind();
    }

    protected void btn_guardar_Click(object sender, EventArgs e)
    {

    }

    protected void btn_eliminar_Click(object sender, EventArgs e)
    {

    }

    protected void btn_consultar_Click(object sender, EventArgs e)
    {

    }
}