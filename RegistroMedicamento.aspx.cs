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
    public partial class RegistroMedicamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["idu"] == null || Session["nombreU"] == null)
            {
                Response.Redirect("Inicio.aspx");
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            String nMed, fechafin;
            int freq;

            nMed = TextBox9.Text; //Nombre medicamento
     
            if (!int.TryParse(DropDownList1.SelectedValue, out freq))
            {
                freq = -1; 
            }

            fechafin = TextBox10.Text;//Fecha de fin
            if (nMed != "" && fechafin != "" && freq != -1)
            {

                String query = "INSERT INTO medicamento VALUES ((SELECT ISNULL(MAX(cMed), 0) + 1 FROM Medicamento), ?, ?, CURRENT_TIMESTAMP, ?, ?)";
                OdbcConnection conexion = new ConexionBD().con;
                OdbcCommand comando = new OdbcCommand(query, conexion);
                comando.Parameters.AddWithValue("nombreM", nMed);
                comando.Parameters.AddWithValue("frecuenciaM", freq);
                comando.Parameters.AddWithValue("fechaFin", fechafin);
                comando.Parameters.AddWithValue("idU", Session["idU"]);
                comando.ExecuteNonQuery();


                Label1.Text = "El nombre del medicamento que introdujiste es: " + nMed + " y lo tomarás con la frecuencia de: " + DropDownList1.SelectedItem.Text + " hasta la fecha de: " + fechafin;

                TextBox9.Text = "";
                TextBox10.Text = "";
            }
            else
            {
                Label1.Text = "Hacen falta datos para introducir medicamento";
            }


        }

        protected void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("PrincipalUsuario.aspx");
        }

        protected void TextBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}