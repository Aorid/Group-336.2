<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page2.aspx.cs" Inherits="webDB.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="style.css">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style ="height:100%; width:100%;">

            <asp:Button ID="Button1" runat="server" data-tooltip="Таблица содержит отрасли - их код, сокращение и название" OnClick="Button1_Click" Text="Перейти на таблицу 'отрасль'" />
            <asp:Button ID="Button2" runat="server" data-tooltip="Таблица содержит холдинги - их номер_аккаунта, символ, долю и т.п." OnClick="Button2_Click" Text="Перейти на таблицу 'Холдинги'" />
            <asp:Button ID="Button3" runat="server" data-tooltip="Таблица содержит акции - их символ, название компании, биржу и т.п." OnClick="Button3_Click" Text="Перейти на таблицу 'Акции'" />

            <asp:GridView Width="100%" ID="GridView2" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" OnPageIndexChanging="GridView2_PageIndexChanging" ToolTip="Таблица холдингов">
                <AlternatingRowStyle BackColor="White" />
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
            <br />
            Добавить элемент в таблицу &quot;Ходинги&quot;<br />
            Номер аккаунта:<asp:Label ID="Label1" runat="server"></asp:Label>
            <br><asp:TextBox data-tooltip="Введите не более 7 символов" Width="100%" ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Символ:<asp:Label ID="Label2" runat="server"></asp:Label>
            <br><asp:TextBox data-tooltip="Введите не более 4 символов" Width="100%" ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            Доля:<asp:Label ID="Label3" runat="server"></asp:Label>
            <br><asp:TextBox data-tooltip="Введите не более 6 символов" Width="100%" ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            Цена:<asp:Label ID="Label4" runat="server"></asp:Label>
            <br><asp:TextBox data-tooltip="Введите не более 10 символов" Width="100%" ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            Дата покупки:<asp:Label ID="Label5" runat="server"></asp:Label>
            <br><asp:TextBox data-tooltip="Введите дату" Width="100%" ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button4" data-tooltip="Все поля должны быть заполнены" runat="server" Text="Добавить" OnClick="Button4_Click" />
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Удалить" />
        </div>
    </form>
    <script src="/scripts/tooltip.js">
    </script>
</body>
</html>
