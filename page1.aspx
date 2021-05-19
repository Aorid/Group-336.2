<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page1.aspx.cs" Inherits="webDB.page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" href="style.css">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

 p.MsoNormal
	{margin-top:0cm;
	margin-right:0cm;
	margin-bottom:8.0pt;
	margin-left:0cm;
	line-height:107%;
	font-size:11.0pt;
	font-family:"Calibri",sans-serif;
	}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style ="height:100%; width:100%;">

        <asp:Button ID="Button1" runat="server" data-tooltip="Таблица содержит отрасли - их код, сокращение и название" OnClick="Button1_Click" Text="Перейти на таблицу 'Отрасль'" />
        <asp:Button ID="Button2" runat="server" data-tooltip="Таблица содержит холдинги - их номер_аккаунта, символ, долю и т.п." OnClick="Button2_Click" Text="Перейти на таблицу 'Холдинги'" />
        <asp:Button ID="Button3" runat="server" data-tooltip="Таблица содержит акции - их символ, название компании, биржу и т.п." OnClick="Button3_Click" Text="Перейти на таблицу 'Акции'" />

            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Справка" />
            <asp:Panel ID="Panel1" runat="server" Visible="False">&nbsp;<a onclick="a3_Click"><asp:TreeView ID="TreeView1" runat="server">
                <Nodes>
                    <asp:TreeNode Text="Таблицы" Value="Новый узел">
                        <asp:TreeNode Text="Общая информация" Value="Общая информация">
                            <asp:TreeNode SelectAction="None" Text="Нажмите на кнопки с названиями таблиц, для вывода на экран" Value="Нажмите на кнопки с названиями таблиц, для вывода на экран"></asp:TreeNode>
                        </asp:TreeNode>
                        <asp:TreeNode Text="Таблица &quot;Отрасль&quot;" Value="Таблица &quot;Отрасль&quot;">
                            <asp:TreeNode SelectAction="None" Text="Выведет на экран информацию об отраслях" Value="Выведет на экран информацию об отраслях"></asp:TreeNode>
                        </asp:TreeNode>
                        <asp:TreeNode Text="Таблица &quot;Холдинги&quot;" Value="Таблица &quot;Холдинги&quot;">
                            <asp:TreeNode SelectAction="None" Text="Выведет на экран информацию о холдингах" Value="Выведет на экран информацию о холдингах"></asp:TreeNode>
                        </asp:TreeNode>
                        <asp:TreeNode Text="Таблица &quot;Акции&quot;" Value="Таблица &quot;Акции&quot;">
                            <asp:TreeNode SelectAction="None" Text="Выведет на экран информацию о акциях" Value="Выведет на экран информацию о акциях"></asp:TreeNode>
                        </asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode Text="Редактирование БД" Value="Редактирование БД">
                        <asp:TreeNode Text="Общая информация" Value="Общая информация">
                            <asp:TreeNode SelectAction="None" Text="Кнопки для взаимодействия с БД" Value="Кнопки для взаимодействия с БД"></asp:TreeNode>
                        </asp:TreeNode>
                        <asp:TreeNode Text="Добавление записи" Value="Добавление записи">
                            <asp:TreeNode SelectAction="None" Text="Чтобы добавить новую запись, вам необходимо сначала заполнить все необходимые поля в соответствии с валидацией, а после нажать на кнопку &quot;добавить&quot;" Value="Чтобы добавить новую запись, вам необходимо сначала заполнить все необходимые поля в соответствии с валидацией, а после нажать на кнопку &quot;добавить&quot;"></asp:TreeNode>
                        </asp:TreeNode>
                        <asp:TreeNode Text="Удаление записи" Value="Удаление записи">
                            <asp:TreeNode SelectAction="None" Text="Чтобы удалить запись вам необходимо ввести в любое поле, любую известную информацию по элементу точно, а затем нажать &quot;удалить&quot;" Value="Чтобы удалить запись вам необходимо ввести в любое поле, любую известную информацию по элементу точно, а затем нажать &quot;удалить&quot;"></asp:TreeNode>
                        </asp:TreeNode>
                        <asp:TreeNode Text="Редактирование записи" Value="Редактирование записи">
                            <asp:TreeNode SelectAction="None" Text="Чтобы редактировать отдельную запись вам необходимо назвать ключевое поле записью которую хотите отредактировать, а далее - изменить её параметры" Value="Чтобы редактировать отдельную запись вам необходимо назвать ключевое поле записью которую хотите отредактировать, а далее - изменить её параметры"></asp:TreeNode>
                        </asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode Text="Вывод таблиц БД" Value="Вывод таблиц БД">
                        <asp:TreeNode Text="Общая информация" Value="Общая информация">
                            <asp:TreeNode SelectAction="None" Text="Работа с БД выполнена через тонкий клиент" Value="Работа с БД выполнена через тонкий клиент"></asp:TreeNode>
                        </asp:TreeNode>
                        <asp:TreeNode Text="Главная таблица" Value="Главная таблица">
                            <asp:TreeNode SelectAction="None" Text="Данный блок содержит выбранную клиентом таблицу. Таблицу можно выбрать с помощью кнопок" Value="Данный блок содержит выбранную клиентом таблицу. Таблицу можно выбрать с помощью кнопок"></asp:TreeNode>
                        </asp:TreeNode>
                        <asp:TreeNode Text="Связанная таблица" Value="Связанная таблица">
                            <asp:TreeNode SelectAction="None" Text="Данный блок содержит выбранную клиентом таблицу. Таблицу можно выбрать с помощью кнопок" Value="Данный блок содержит выбранную клиентом таблицу. Таблицу можно выбрать с помощью кнопок"></asp:TreeNode>
                        </asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode Text="Автор" Value="Автор">
                        <asp:TreeNode SelectAction="None" Text="Автор Набокин Дмитрий, группа 336" Value="Автор Набокин Дмитрий, группа 336"></asp:TreeNode>
                    </asp:TreeNode>
                </Nodes>
                </asp:TreeView>
                </a>
                
            </asp:Panel>

        <asp:GridView Width="100%" ID="GridView1" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333" GridLines="None" OnPageIndexChanging="GridView1_PageIndexChanging" ToolTip="Таблица отраслей">
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
            Добавить элемент в таблицу &quot;отрасль&quot;<br />
            Код:<asp:Label ID="Label1" runat="server"></asp:Label>
            <br><asp:TextBox data-tooltip="Введите не более 4 символов" Width="100%" ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Сокращение:<asp:Label ID="Label2" runat="server"></asp:Label>
            <br><asp:TextBox data-tooltip="Введите не более 10 символов" Width="100%" ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            Название:<asp:Label ID="Label3" runat="server"></asp:Label>
            <br><asp:TextBox data-tooltip="Введите не более 20 символов" Width="100%" ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button4" data-tooltip="Все поля должны быть заполнены" runat="server" Text="Добавить" OnClick="Button4_Click" />
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Удалить" />
        </div>
    </form>
    <script src="/scripts/tooltip.js">
    </script>
</body>
</html>
