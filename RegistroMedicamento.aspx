<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroMedicamento.aspx.cs" Inherits="GestionadorMedicamentos.RegistroMedicamento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>RegistroMedicamento</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            En este apartado puedes registrar un nuevo medicamento:<br />
            <br />
            Nombre del medicamento:<asp:TextBox ID="TextBox9" runat="server" OnTextChanged="TextBox9_TextChanged"></asp:TextBox>
            <br />
            <br />
            Eliga la frecuencia del medicamento:<br />
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Value="168">Cada 7 días</asp:ListItem>
                <asp:ListItem Value="48">Cada 2 días</asp:ListItem>
                <asp:ListItem Value="24">Cada 24 horas</asp:ListItem>
                <asp:ListItem Value="8">Cada 8 horas</asp:ListItem>
                <asp:ListItem Value="2">Cada 2 horas</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />           
            <br />
            Introduzca la fecha de termino de su tratamiento: (MES/DÍA/AÑO)<br />
            <asp:TextBox ID="TextBox10" runat="server" OnTextChanged="TextBox10_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Registra Datos" />
            <br />
            <br />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Regresa a página anterior" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
