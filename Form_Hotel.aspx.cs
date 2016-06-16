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
        ddl_ciudad.DataSource = CiudadDao.consultarCiudad();
        ddl_ciudad.DataTextField = "nombre";
        ddl_ciudad.DataValueField = "idCiudad";
        ddl_ciudad.DataBind();
    }
}