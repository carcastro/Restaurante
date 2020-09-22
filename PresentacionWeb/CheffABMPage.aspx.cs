using Modelo;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWeb
{
    public partial class CheffABMPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Cheff cheff = new Cheff();
            cheff.Nombre = this.txtNombre.Text;
            cheff.Apellido = this.txtApellido.Text;
            cheff.Telefono = this.txtTelefono.Text;
            cheff.Especialidad = this.txtEspecialidad.Text;
            cheff.DNI = this.txtDNI.Text;
     
            AdmCheff PATOVACHEFF = new AdmCheff();
            int resultado = PATOVACHEFF.ingresarCheff(cheff);

            if(resultado==1)
            {
                //lo agrego bien
                LitResultado.Text = "Cheff agregado con exito";
                //limpio los textbox
                this.txtNombre.Text = "";
            }
            else
            {
                //El cheff ya existe
                LitResultado.Text = "Ya existe Cheff con ese DNI";
            }
        }
    }
}