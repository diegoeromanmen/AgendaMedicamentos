﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroContacto.aspx.cs" Inherits="GestionadorMedicamentos.RegistroContacto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registro Contacto</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            En este apartado tiene la posibilidad de registrar algún contanto:<br />
            <br />
            Nombre del contacto:<asp:TextBox ID="TextBox5" runat="server" OnTextChanged="TextBox5_TextChanged"></asp:TextBox>
            <br />
            <br />
            Correo del contacto:<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <br />
            <br />
            Teléfono del contacto:<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            <br />
            <br />
            Domicilio del contacto:<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Registrar contacto" />
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Regresar a página anterior" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
