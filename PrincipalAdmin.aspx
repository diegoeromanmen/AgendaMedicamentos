<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PrincipalAdmin.aspx.cs" Inherits="GestionadorMedicamentos.PrincipalAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Edición de Datos</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Agregar/quitar o modificar:<br />
            <br />
            Ingresa datos usuarios:<br />
            Correo usuario:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Validar datos" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <hr />
            <br />
            <asp:Panel ID="pnlContent" runat="server">

                
                //Add borrar usuario igual 

             
                Nombre de medicamento:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Elimina" />
                <br />
                <br />
                <asp:Label ID="Label2" runat="server"></asp:Label>
                <br />
                <hr />
                <br />
                <br />
                Nombre de medicamento:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                <br />
                <br />
                Nuevos datos:<br />
                <br />
                Nombre nuevo de medicamento:<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                <br />
                Nueva frecuencia:
                <asp:DropDownList ID="DropDownList3" runat="server">
                    <asp:ListItem Value="168">Cada 7 días</asp:ListItem>
                    <asp:ListItem Value="48">Cada 2 días</asp:ListItem>
                    <asp:ListItem Value="24">Cada 24 horas</asp:ListItem>
                    <asp:ListItem Value="8">Cada 8 horas</asp:ListItem>
                    <asp:ListItem Value="2">Cada 2 horas</asp:ListItem>
                </asp:DropDownList>

                <br />
                Nueva fecha de termino de tratamiento: (MES/DÍA/AÑO)<br />
                <asp:TextBox ID="TextBox7" runat="server" OnTextChanged="TextBox7_TextChanged"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label4" runat="server"></asp:Label>
                <br />
                <br />
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Modifica" />
                <br />
                <hr />
                <br />
                <br />
                Nombre de medicamento:<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                <br />
                Frecuencia
                <asp:DropDownList ID="DropDownList4" runat="server" >
                    <asp:ListItem Value="168">Cada 7 días</asp:ListItem>
                    <asp:ListItem Value="48">Cada 2 días</asp:ListItem>
                    <asp:ListItem Value="24">Cada 24 horas</asp:ListItem>
                    <asp:ListItem Value="8">Cada 8 horas</asp:ListItem>
                    <asp:ListItem Value="2">Cada 2 horas</asp:ListItem>
                </asp:DropDownList>
                <br />
                Fecha de termino de tratamiento: (MES/DÍA/AÑO)<br />
                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label3" runat="server"></asp:Label>
                <br />
                <br />
                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Agrega" />
                <br />
                <br />
                <br />
                <br />
            </asp:Panel>
        </div>
    </form>
</body>
</html>
