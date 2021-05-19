using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;


namespace webDB
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        public class FileDBF
        {
            private OleDbConnection _connection = null;

            private const string putFileName = @"D:\Labs\336LabsMomot\Lab1\DBDEMOS"; // сюда пишите ПОЛНЫЙ ПУТЬ к ПАПКЕ.

            public DataTable Execute(string command)
            {
                DataTable dt = null;
                if (_connection != null)
                {
                    try
                    {
                        _connection.Open();
                        dt = new DataTable();
                        System.Data.OleDb.OleDbCommand oCmd = _connection.CreateCommand();
                        oCmd.CommandText = command;
                        dt.Load(oCmd.ExecuteReader());
                        _connection.Close();
                    }
                    catch (Exception e)
                    {

                    }
                }
                return dt;
            }

            public DataTable GetAll(string dbpath)
            {

                return Execute("SELECT * FROM " + dbpath); ;
            }

            public FileDBF()
            {
                this._connection = new System.Data.OleDb.OleDbConnection();
                _connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + putFileName + "; Extended Properties=dBASE IV;"; ;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Update();
        }
        private void Update()
        {
            FileDBF dbf = new FileDBF();
            var dt = dbf.Execute(@"SELECT ACCT_NBR AS Номер_Аккаунта, SYMBOL AS Символ, SHARES AS Доля, PUR_PRICE AS Цена, PUR_DATE AS Дата_покупки D:\Labs\336LabsMomot\Lab1\DBDEMOS\holdings.dbf ");// сюда пишите, ПУТЬ К ПАПКЕ И ФАЙЛУ.
            GridView2.DataSource = dt;
            GridView2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("page1.aspx");
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("page2.aspx");
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("page3.aspx");
        }

        protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView2.PageIndex = e.NewPageIndex;
            GridView2.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int id = 0; 
            string symb;
            int part;
            int price;
            string date;
            try
            {
                id = Convert.ToInt32(TextBox1.Text);
            }
            catch (Exception ex)
            {
                Label1.Text = "Вы ничего не вписали";
            }


            if (id.ToString().Length < 8 && id.ToString().Length > 0)
            {
                symb = TextBox2.Text;

                if (symb.Length < 5 && symb != "")
                {
                    part = Convert.ToInt32(TextBox3.Text);
                    Label2.Text = "";
                    if (part.ToString().Length < 7 && part.ToString().Length > 0)
                    {
                        Label3.Text = "";
                        price = Convert.ToInt32(TextBox4.Text);
                        if (price.ToString().Length < 11 && price.ToString().Length > 0)
                        {
                            Label4.Text = "";
                            date = TextBox5.Text;
                            if (date != "")
                            {
                                Label5.Text = "";
                                FileDBF db = new FileDBF();
                                var dt = db.Execute(@"INSERT INTO D:\Labs\336LabsMomot\Lab1\DBDEMOS\holdings.dbf  VALUES ('" + id + "','" + symb + "','" 
                                    + part + "','" + price + "','" + date + "');");
                                GridView2.DataBind();
                            }
                            else Label5.Text = "Дата не задана";
                        }
                        else Label4.Text = "Цена либо слишком большая, либо вы ничего не вписали";
                    }
                    else Label3.Text = "Доля либо слишком большая, либо вы ничего не вписали";
                }
                else Label2.Text = "Символ либо слишком большой, либо вы ничего не вписали";
            }
            else Label1.Text = "Номер аккаунта либо слишком большой, либо вы ничего не вписали";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            int id = 0;
            string symb = TextBox2.Text;
            int part = Convert.ToInt32(TextBox3.Text);
            int price = Convert.ToInt32(TextBox4.Text);
            string date = TextBox5.Text;
            try
            {
                id = Convert.ToInt32(TextBox1.Text);
            }
            catch (Exception ex)
            {
                Label1.Text = "Вы ничего не вписали";
            }
            FileDBF db = new FileDBF();
            if (id.ToString().Length < 8 && id.ToString().Length > 0)
            {
                var dt = db.Execute(@"DELETE FROM D:\Labs\336LabsMomot\Lab1\DBDEMOS\holdings.dbf  WHERE ACCT_NBR='" + id + "';");
                GridView2.DataBind();
            }
            if (symb.Length < 5 && symb != "")
            {
                var dt = db.Execute(@"DELETE FROM D:\Labs\336LabsMomot\Lab1\DBDEMOS\holdings.dbf  WHERE SYMBOL='" + symb + "';");
                GridView2.DataBind();
            }
            if (part.ToString().Length < 7 && part.ToString().Length > 0)
            {
                var dt = db.Execute(@"DELETE FROM D:\Labs\336LabsMomot\Lab1\DBDEMOS\holdings.dbf  WHERE SHARES='" + part + "';");
                GridView2.DataBind();
            }
            if (price.ToString().Length < 11 && price.ToString().Length > 0)
            {
                var dt = db.Execute(@"DELETE FROM D:\Labs\336LabsMomot\Lab1\DBDEMOS\holdings.dbf  WHERE PUR_PRICE='" + price + "';");
                GridView2.DataBind();
            }
            if (date != "")
            {
                var dt = db.Execute(@"DELETE FROM D:\Labs\336LabsMomot\Lab1\DBDEMOS\holdings.dbf  WHERE PUR_DATE='" + date + "';");
                GridView2.DataBind();
            }
        }
    }
}