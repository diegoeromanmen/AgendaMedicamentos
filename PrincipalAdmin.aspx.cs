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
    public partial class PrincipalAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["idAdmin"] == null || Session["nombreAdmin"] == null)
            {
                Response.Redirect("LoginAdmin.apsx");
            }


            if(Session["idUSelected"] == null)
            {
                pnlContent.Visible = false;
            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            String nMed, fechafin;
            int freq;

            nMed = TextBox6.Text; //Nombre medicamento

            if (!int.TryParse(DropDownList4.SelectedValue, out freq))
            {
                freq = -1;
            }

            fechafin = TextBox8.Text;//Fecha de fin
            if (nMed != "" && fechafin != "" && freq != -1 && Session["idUSelected"] != null)
            {

                String query = "INSERT INTO medicamento VALUES ((SELECT ISNULL(MAX(cMed), 0) + 1 FROM Medicamento), ?, ?, CURRENT_TIMESTAMP, ?, ?)";
                OdbcConnection conexion = new ConexionBD().con;
                OdbcCommand comando = new OdbcCommand(query, conexion);
                comando.Parameters.AddWithValue("nombre", nMed);
                comando.Parameters.AddWithValue("frecuencia", freq);
                comando.Parameters.AddWithValue("fechaFin", fechafin);
                comando.Parameters.AddWithValue("idU", Session["idUSelected"]);
                comando.ExecuteNonQuery();


                Label3.Text = "El nombre del medicamento que introdujiste es: " + nMed + " y lo tomarás con la frecuencia de: " + DropDownList4.SelectedItem.Text + " hasta la fecha de: " + fechafin;

                TextBox6.Text = "";
                TextBox8.Text = "";
            }
            else
            {
                Label1.Text = "Hacen falta datos para introducir medicamento";
            }

        }

        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox3.Text != "")
            {
                String query = "delete from medicamento where nombre=? and idU=?";
                OdbcConnection conexion = new ConexionBD().con;
                OdbcCommand comando = new OdbcCommand(query, conexion);
                comando.Parameters.AddWithValue("nombre", TextBox3.Text);
                comando.Parameters.AddWithValue("idU", Session["idUSelected"]);
                comando.ExecuteNonQuery();

                Label2.Text = "Eliminación realizada";
            }
            else
            {
                Label2.Text = "Datos inválidos";
            }
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            int freq;

            if (!int.TryParse(DropDownList4.SelectedValue, out freq))
            {
                freq = -1;
            }

            if (TextBox5.Text != "" && TextBox7.Text != "" && TextBox4.Text != "")
            {
                String query = "update Medicamento set nombre=?, frecuencia=?, fechaFin=? where nombre=? and idU=?";
                OdbcConnection conexion = new ConexionBD().con;
                OdbcCommand comando = new OdbcCommand(query, conexion);

                comando.Parameters.AddWithValue("nombreMNuevo", TextBox5.Text);
                comando.Parameters.AddWithValue("frecuenciaMNueva", freq);
                comando.Parameters.AddWithValue("fechaFinNueva", TextBox7.Text);
                comando.Parameters.AddWithValue("nombreMedAnt", TextBox4.Text);
                comando.Parameters.AddWithValue("idU", Session["idUSelected"]);
                comando.ExecuteNonQuery();
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox7.Text = "";

                Label4.Text = "Actualización realizada";
            }
            else
            {
                Label4.Text = "Datos innválidos";
            }

        }

        protected void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            String query = "select idU, nombre, passwrd from Usuario where correo=?";
            OdbcConnection conexion = new ConexionBD().con;
            OdbcCommand comando = new OdbcCommand(query, conexion);
            comando.Parameters.AddWithValue("correoU", TextBox1.Text);

            OdbcDataReader lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                Session.Add("idUSelected", lector.GetInt32(0));
                String nombreU = lector.GetString(1);
                String passwrdU = lector.GetString(2);

                Label1.Text = "Usuario: " + nombreU;
                pnlContent.Visible = true;

            }
            else
            {
                Label1.Text = "Datos inválidos";

            }

        }


    }
}