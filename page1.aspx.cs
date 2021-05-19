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
    public partial class page1 : System.Web.UI.Page
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
            var dt = dbf.Execute(@"SELECT IND_CODE AS Код, IND_NAME AS Сокращение, LONG_NAME AS Название FROM D:\Labs\336LabsMomot\Lab1\DBDEMOS\industry.dbf  ");
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
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

        protected void Button4_Click(object sender, EventArgs e)
        {
            int id = 0;
            string shor = "";
            string full = "";
            try
            {
                id = Convert.ToInt32(TextBox1.Text);
            }
            catch (Exception ex)
            {
                Label1.Text = "Вы ничего не вписали";
            }

            if (id.ToString().Length < 5 && id.ToString().Length > 0)
            {
                shor = TextBox2.Text;
                Label1.Text = "";
                if (shor.Length < 11 && shor != "")
                {
                    full = TextBox3.Text;
                    Label2.Text = "";
                    if (full.Length < 21 && full != "")
                    {
                        Label3.Text = "";
                        FileDBF db = new FileDBF();
                        var dt = db.Execute(@"INSERT INTO D:\Labs\336LabsMomot\Lab1\DBDEMOS\industry.dbf  VALUES ('" + id + "','" + shor + "','" + full + "');");
                        GridView1.DataBind();
                    }
                    else Label3.Text = "Название либо слишком большое, либо вы ничего не вписали";
                }
                else Label2.Text = "Сокращение либо слишком большое, либо вы ничего не вписали";
            }
            else Label1.Text = "Код либо слишком большой, либо вы ничего не вписали";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            int id = 0;
            string shor = TextBox2.Text;
            string full = TextBox3.Text;
            try
            {
                id = Convert.ToInt32(TextBox1.Text);
            }
            catch (Exception ex)
            {
                Label1.Text = "Вы ничего не вписали";
            }
            FileDBF db = new FileDBF();
            if (id.ToString().Length < 5 && id.ToString().Length > 0)
            {
                var dt = db.Execute(@"DELETE FROM D:\Labs\336LabsMomot\Lab1\DBDEMOS\industry.dbf  WHERE IND_CODE='" + id +"';");
                GridView1.DataBind();
            }
            if (shor.Length < 11 && shor != "")
            {
                var dt = db.Execute(@"DELETE FROM D:\Labs\336LabsMomot\Lab1\DBDEMOS\industry.dbf  WHERE IND_NAME='" + shor + "';");
                GridView1.DataBind();
            }
            if (full.Length < 21 && full != "")
            {
                var dt = db.Execute(@"DELETE FROM D:\Labs\336LabsMomot\Lab1\DBDEMOS\industry.dbf  WHERE LONG_NAME='" + full + "';");
                GridView1.DataBind();
            }
        }


        protected void Button6_Click(object sender, EventArgs e)
        {
            if (!Panel1.Visible)
                Panel1.Visible = true;
            else Panel1.Visible = false;
        }
    }
}