using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Curso_sql_newsoft_clientes
{
    public partial class Default : System.Web.UI.Page
    {
        #region "Variables Globales"
        //declaro la instancia a la clase de conexion
        clases.Conexion cn = new clases.Conexion();
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPruebaConexion_Click(object sender, EventArgs e)
        {
            try
            {
                cn.cadenaConexion.Open();
                lblEstadoConexion.Text = "Todo perfecto, se conecto sin problema";
                cn.cadenaConexion.Close();
            }
            catch (Exception)
            {
                cn.cadenaConexion.Close();
                lblEstadoConexion.Text = "Error al conectar";
            }
        }
    }
}