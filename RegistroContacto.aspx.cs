using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GestionadorMedicamentos
{
    public partial class RegistroContacto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["idu"] == null || Session["nombreU"] == null)
            {
                Response.Redirect("Inicio.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox5.Text != "" && TextBox6.Text != "" && TextBox7.Text != "" && TextBox8.Text != "")
            {
                String query = "insert into contacto values((select isnull(max(idC),0)+1 from Contacto),?,?,?,?,?)";
                String s5, s6, s7, s8;
                s5 = TextBox5.Text;//Nombre Contacto
                s6 = TextBox6.Text;//Correo contacto
                s7 = TextBox7.Text;//Teléfono Contacto
                s8 = TextBox8.Text;//Domicilio Contacto
                OdbcConnection conexion = new ConexionBD().con;
                OdbcCommand comando = new OdbcCommand(query, conexion);

                comando.Parameters.AddWithValue("nombreC", s5);
                comando.Parameters.AddWithValue("correoC", s6);
                comando.Parameters.AddWithValue("telefonoC", s7);
                comando.Parameters.AddWithValue("domicilioC", s8);
                comando.Parameters.AddWithValue("idU", Session["idU"]);

                comando.ExecuteNonQuery();
                Label1.Text = "En nombre del contacto es: " + s5 + " el correo del contacto es: " + s6 + " el teléfono del contacto es: " + s7 +
                    " el domicilio del contacto es: " + s8;

                TextBox5.Text = "";//Nombre Contacto
                TextBox6.Text = "";//Correo contacto
                TextBox7.Text = "";//Teléfono Contacto
                TextBox8.Text = "";//Domicilio Contacto
            }
            else
            {
                Label1.Text = "Hay elemento(s) incompletos";
            }
        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("PrincipalUsuario.aspx");
        }
    }
}