﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GestionadorMedicamentos
{
    public partial class PrincipalUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["idu"] == null || Session["nombreU"] == null)
            {
                Response.Redirect("Inicio.aspx");
            }
        }

        protected void medClick(object sender, EventArgs e)
        {
            LinkButton lnk = sender as LinkButton;
            if (lnk != null)
            {
                // Store the medicine ID in session
                Session["MedicineID"] = lnk.CommandArgument;

                // Redirect to the target page
                Response.Redirect("TargetPage.aspx");
            }
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistroMedicamento.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistroContacto.aspx");
        }
    }
}