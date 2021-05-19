<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page3.aspx.cs" Inherits="webDB.page3" %>

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

            <div data-tooltip="Вы можете проскроллить чтобы увидеть все значения" style ="width:100%; overflow-y:hidden">
            <asp:GridView Width="100%"  ID="GridView3" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" OnPageIndexChanging="GridView3_PageIndexChanging" ToolTip="Таблица акций">
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
            </div>
           <br />
            Добавить элемент в таблицу &quot;Акции&quot;<br />
            Символ:<asp:Label ID="Label1" runat="server"></asp:Label>
            <br><asp:TextBox data-tooltip="Введите не более 4 символов" Width="100%" ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Название компании:<asp:Label ID="Label2" runat="server"></asp:Label>
            <br><asp:TextBox  data-tooltip="Введите не более 30 символов" Width="100%" ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            Биржа:<asp:Label ID="Label3" runat="server"></asp:Label>
            <br><asp:TextBox data-tooltip="Введите не более 4 символов" Width="100%" ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            Цена:<asp:Label ID="Label4" runat="server"></asp:Label>
            <br><asp:TextBox data-tooltip="Введите не более 10 символов" Width="100%" ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            Наивысшая цена:<asp:Label ID="Label5" runat="server"></asp:Label>
            <br><asp:TextBox data-tooltip="Введите не более 10 символов" Width="100%" ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            Минимальная цена:<asp:Label ID="Label6" runat="server"></asp:Label>
            <br><asp:TextBox data-tooltip="Введите не более 10 символов" Width="100%" ID="TextBox6" runat="server"></asp:TextBox>
            <br />
            Соотношение:<asp:Label ID="Label7" runat="server"></asp:Label>
            <br><asp:TextBox data-tooltip="Введите не более 4 символов" Width="100%" ID="TextBox7" runat="server"></asp:TextBox>
            <br />
            Бета:<asp:Label ID="Label8" runat="server"></asp:Label>
            <br><asp:TextBox data-tooltip="Введите не более 4 символов" Width="100%" ID="TextBox8" runat="server"></asp:TextBox>
            <br />
            Рост:<asp:Label ID="Label9" runat="server"></asp:Label>
            <br><asp:TextBox data-tooltip="Введите не более 4 символов" Width="100%" ID="TextBox9" runat="server"></asp:TextBox>
            <br />
            Индустрия:<asp:Label ID="Label10" runat="server"></asp:Label>
            <br><asp:TextBox data-tooltip="Введите не более 4 символов" Width="100%" ID="TextBox10" runat="server"></asp:TextBox>
            <br />
            Изменение цены:<asp:Label ID="Label11" runat="server"></asp:Label>
            <br><asp:TextBox data-tooltip="Введите не более 4 символов" Width="100%" ID="TextBox11" runat="server"></asp:TextBox>
            <br />
            Безопасность:<asp:Label ID="Label12" runat="server"></asp:Label>
            <br><asp:TextBox data-tooltip="Введите не более 1 символ" Width="100%" ID="TextBox12" runat="server"></asp:TextBox>
            <br />
            Рейтинг:<asp:Label ID="Label13" runat="server"></asp:Label>
            <br><asp:TextBox data-tooltip="Введите не более 1 символ" Width="100%" ID="TextBox13" runat="server"></asp:TextBox>
            <br />
            Ранк:<asp:Label ID="Label14" runat="server"></asp:Label>
            <br><asp:TextBox data-tooltip="Введите не более 1 символ" Width="100%" ID="TextBox14" runat="server"></asp:TextBox>
            <br />
            Прогноз:<asp:Label ID="Label15" runat="server"></asp:Label>
            <br><asp:TextBox data-tooltip="Введите не более 1 символ" Width="100%" ID="TextBox15" runat="server"></asp:TextBox>
            <br />
            Рекомендации:<asp:Label ID="Label16" runat="server"></asp:Label>
            <br><asp:TextBox data-tooltip="Введите не более 4 символа" Width="100%" ID="TextBox16" runat="server"></asp:TextBox>
            <br />
            Риски:<asp:Label ID="Label17" runat="server"></asp:Label>
            <br><asp:TextBox data-tooltip="Введите не более 3 символов" Width="100%" ID="TextBox17" runat="server"></asp:TextBox>
            <br />
            <asp:Button data-tooltip="Все поля должны быть заполнены" ID="Button4" runat="server" Text="Добавить" OnClick="Button4_Click" />
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Удалить" />
        </div>
    </form>
    <script src="/scripts/tooltip.js">
    </script>
</body>
</html>
