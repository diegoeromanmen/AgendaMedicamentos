<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PrincipalUsuario.aspx.cs" Inherits="GestionadorMedicamentos.PrincipalUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>DatosPersonales</title>
</head>
<body>
    <form id="form1" runat="server">
        Tus medicamentos son los siguientes:<br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:TemplateField HeaderText="Name">
                    <ItemTemplate>
                        
                    </ItemTemplate>
                   </asp:TemplateField>
                <asp:BoundField DataField="freq" HeaderText="Freccuencia" />
                <asp:BoundField DataField="fechaFin" HeaderText="Fecha Fin" />
            </Columns>
        </asp:GridView>

        <hr />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Registrar nuevo medicamento" />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Registrar nuevo contacto" />
        <br />
    </form>
</body>
</html>
