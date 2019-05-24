using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Curso_sql_newsoft_clientes
{
    public partial class clientes : System.Web.UI.Page
    {
        #region "variablesGlobales"
        clases.Clientes csClientes = new clases.Clientes();
        string nombre, apePat, apeMat, email, fechaNacimiento, fechaHoraIngreso, horaDesayuno;
        int edad, ID;
        DataSet datos = new DataSet();

        protected void btnSelTodosClientes_Click(object sender, EventArgs e)
        {
            datos = csClientes.busClientes();
            gdvClientes.DataSource = datos.Tables["Datos Generales"];
            gdvClientes.DataBind();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIdCliente.Text != "")
            {
                ID = int.Parse( txtIdCliente.Text);
                try
                {
                    if (csClientes.eliClientes(ID))
                    {
                        lblEstadoClientes.Text = "Se ha eliminado correctamente";
                    }
                    else
                    {
                        lblEstadoClientes.Text = "Error al eliminar cliente";
                    }
                }
                catch (Exception ex)
                {
                    lblEstadoClientes.Text = ex.Message;
                }
            }
        }
        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtIdCliente.Text != "")
            {
                ID = int.Parse(txtIdCliente.Text);
                try
                {
                    bajarVariables();
                    if (csClientes.actClientes(ID, nombre, apePat, apeMat, edad, tel,
                email, fechaNacimiento, fechaHoraIngreso, horaDesayuno, sexo))
                    {
                        lblEstadoClientes.Text = "Se ha actualizado correctamente";
                    }
                    else
                    {
                        lblEstadoClientes.Text = "Error al actualzar cliente";
                    }
                }
                catch (Exception ex)
                {
                    lblEstadoClientes.Text = ex.Message;
                }
            }
        }

        protected void btnSelIDCliente_Click(object sender, EventArgs e)
        {
            if(txtIdCliente.Text != "")
            {
                //traer todos los datos del cliente
                ID = int.Parse(txtIdCliente.Text);
                try
                {
                    //uso un dataset para recibir todos 
                    //los datos de mi bd que vienen desde
                    //la bibilioteca de clases
                    datos = csClientes.busIDClientes(ID);
                    lblBusquedaCliente.Text = "Funciono";
                    foreach(DataRow row in datos.Tables["Datos Generales"].Rows)
                    {
                        txtNombre.Text = row["nombre"].ToString();
                        txtApePaterno.Text = row["apePaterno"].ToString();
                        txtApeMaterno.Text = row["apeMaterno"].ToString();
                        txtEdad.Text = row["edad"].ToString();
                        txtTelefono.Text = row["telefono"].ToString();
                        txtEmail.Text = row["email"].ToString();
                        txtFechaNacimiento.Text = row["fechaNacimiento"].ToString();
                        txtHoraIngreso.Text = row["fechaHoraIngreso"].ToString();
                        txtHoraDesayuno.Text = row["horaDesayuno"].ToString();
                        txtSexo.Text = row["sexo"].ToString();
                        gdvClientes.DataSource = datos.Tables["Datos Generales"];
                        gdvClientes.DataBind();
                    }
                }
                catch (Exception)
                {
                    lblBusquedaCliente.Text = "Error";
                }
            }
            else
            {
                //detecta que la caja de ID esta vacia
                /* y me invita a escribir un id
                 * para que pueda buscar un cliente*/
                lblBusquedaCliente.Text = "Hola por favor" +
                    " escribe un id del cliente a buscar";
                
            }
        }

        double tel;
        string sexo;
        #endregion
        #region "metodos"
        public void bajarVariables()
        {
            nombre =txtNombre.Text;
            apePat = txtApePaterno.Text;
            apeMat = txtApeMaterno.Text;
            edad = int.Parse(txtEdad.Text);
            tel = double.Parse(txtTelefono.Text);
            email = txtEmail.Text;
            fechaNacimiento = txtFechaNacimiento.Text;
            fechaHoraIngreso = txtHoraIngreso.Text;
            horaDesayuno = txtHoraDesayuno.Text;
            sexo = txtSexo.Text;
        }
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnÑrobarClientes_Click(object sender, EventArgs e)
        {
            lblEstadoClientes.Text = Convert.ToString(csClientes.hola());
        }

        protected void btnGuardarClientes_Click(object sender, EventArgs e)
        {
            bajarVariables();
            if(csClientes.guaClientes(nombre, apePat, apeMat, edad, tel,
                email, fechaNacimiento, fechaHoraIngreso, horaDesayuno, sexo))
            {
                lblEstadoGuardado.Text = "Guardado Correctamente";
            }
            else
            {
                lblEstadoGuardado.Text = "No se pudo Guardar";
            }
            
        }
    }
}