<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Perfil.aspx.vb" Inherits="PaginaPrincipal.Perfil" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
     <asp:AdRotator ID="AdRotator2" runat="server" AdvertisementFile="~/XMLFile1.xml" Width="100%" Height="100%"  />
    <form id="form1" runat="server">
         <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        
        <div aria-orientation="horizontal" style="height: 125%; clip: rect(auto, auto, auto, auto); width: 100%; position: absolute; top: 20px; left: 162px; margin-left: 80px; margin-bottom: 0px;" aria-expanded="undefined">
                <asp:Label ID="lbl_Nombre" runat="server" Text="Nombre" Font-Bold="True" Font-Size="Large" ForeColor="White"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tx_Nombre" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="White"></asp:Label>
&nbsp;&nbsp;&nbsp;
                <br />
                <br />
                <asp:Label ID="lbl_Apellido" runat="server" Text="Apellido" Font-Bold="True" Font-Size="Large" ForeColor="White"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tx_Apellido" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lbl_Dni" runat="server" Text="Dni" Font-Bold="True" Font-Size="Large" ForeColor="White"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tx_Dni" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lbl_Sexo" runat="server" Text="Sexo" Font-Bold="True" Font-Size="Large" ForeColor="White"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>F</asp:ListItem>
                    <asp:ListItem>M</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <asp:Label ID="lbl_Edad" runat="server" Text="Edad" Font-Bold="True" Font-Size="Large" ForeColor="White"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tx_Edad" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lbl_Telefono" runat="server" Text="Telefono" Font-Bold="True" Font-Size="Large" ForeColor="White"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tx_Telefono" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lbl_Gmail" runat="server" Text="Gmail" Font-Bold="True" Font-Size="Large" ForeColor="White"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tx_Gmail" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lbl_Contrasena" runat="server" Text="Contraseña" Font-Bold="True" Font-Size="Large" ForeColor="White"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tx_Contrasena" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;<asp:Button ID="Button3" runat="server" Text="Cambiar contraseña" />
                <br />
                <br />
                <asp:Label ID="lbl_NuevaContrasena" runat="server" Text="Nueva Contraseña" Font-Bold="True" Font-Size="Large" ForeColor="White"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tx_NuevaContrasena" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lbl_ConfirmarContrasena" runat="server" Text="Confirmar Contraseña" Font-Bold="True" Font-Size="Large" ForeColor="White"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tx_ConfirmarContrasena" runat="server"></asp:TextBox>
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Button ID="Button1" runat="server" Text="Modificar perfil" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Aceptar cambios" Width="115px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Btn_volver" runat="server" PostBackUrl="~/PaginaPrincipal.aspx" Text="Volver" />
            <br />
            <br />
            <br />
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="IdReser" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="IdReser" HeaderText="IdReser" InsertVisible="False" ReadOnly="True" SortExpression="IdReser" />
                        <asp:BoundField DataField="Fk_IdCliente" HeaderText="Fk_IdCliente" SortExpression="Fk_IdCliente" />
                        <asp:BoundField DataField="Fk_IdEsta" HeaderText="Fk_IdEsta" SortExpression="Fk_IdEsta" />
                        <asp:BoundField DataField="Dni" HeaderText="Dni" SortExpression="Dni" />
                        <asp:BoundField DataField="fecha_ini" HeaderText="fecha_ini" SortExpression="fecha_ini" />
                        <asp:BoundField DataField="FechaFin" HeaderText="FechaFin" SortExpression="FechaFin" />
                        <asp:BoundField DataField="Habitaciones" HeaderText="Habitaciones" SortExpression="Habitaciones" />
                        <asp:BoundField DataField="Precio" HeaderText="Precio" SortExpression="Precio" />
                    </Columns>
                    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                    <SortedAscendingCellStyle BackColor="#FDF5AC" />
                    <SortedAscendingHeaderStyle BackColor="#4D0000" />
                    <SortedDescendingCellStyle BackColor="#FCF6C0" />
                    <SortedDescendingHeaderStyle BackColor="#820000" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:retoethaziConnectionString %>" ProviderName="<%$ ConnectionStrings:retoethaziConnectionString.ProviderName %>" SelectCommand="Select * From reservas Where Dni = '20234428V'">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="dni" Name="@dni" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <asp:Timer ID="Timer1" runat="server" Interval="5000" >
                </asp:Timer>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
