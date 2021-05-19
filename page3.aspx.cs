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
    public partial class page3 : System.Web.UI.Page
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
            var dt3 = dbf.Execute(@"SELECT SYMBOL AS Символ,CO_NAME AS Название_компании, EXCHANGE AS Биржа, CUR_PRICE AS Цена, YRL_HIGH AS Наивысшая_цена, YRL_LOW AS Минимальная_цена, P_E_RATIO AS Соотношение,
            BETA AS Бета, PROJ_GRTH AS Рост, INDUSTRY AS Индустрия, PRICE_CHG AS Изменение_цены, SAFETY AS Безопасность, RATING AS Рейтинг, RANK AS Ранк, OUTLOOK AS Прогноз, RCMNDATION AS Рекомендации, RISK AS Риски FROM D:\Labs\336LabsMomot\Lab1\DBDEMOS\master.dbf  ");
            GridView3.DataSource = dt3;
            GridView3.DataBind();
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

        protected void GridView3_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView3.PageIndex = e.NewPageIndex;
            GridView3.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string sym, name, birg, rating, rcmnd, risk;
            float price, maxprice, minprice, rel, beta;
            int grow, ind, change, safe, rang, outl;

            sym = TextBox1.Text;
            
            if (sym.Length < 5 && sym != "")
            {
                name = TextBox2.Text;
                Label1.Text = "";
                if (name.Length < 30 && name != "")
                {
                    birg = TextBox3.Text;
                    Label2.Text = "";
                    if (birg.Length < 4 && birg != "")
                    {
                        price = Convert.ToInt32(TextBox4.Text);
                        Label3.Text = "";
                        if (price.ToString().Length < 10 && price.ToString().Length > 0)
                        {
                            maxprice = Convert.ToInt32(TextBox5.Text);
                            Label4.Text = "";
                            if (maxprice.ToString().Length < 10 && maxprice.ToString().Length > 0)
                            {
                                minprice = Convert.ToInt32(TextBox6.Text);
                                Label5.Text = "";
                                if (minprice.ToString().Length < 10 && minprice.ToString().Length > 0)
                                {
                                    rel = Convert.ToInt32(TextBox7.Text);
                                    Label6.Text = "";
                                    if (rel.ToString().Length < 5 && rel.ToString().Length > 0)
                                    {
                                        beta = Convert.ToInt32(TextBox8.Text);
                                        Label7.Text = "";
                                        if (beta.ToString().Length < 5 && beta.ToString().Length > 0)
                                        {
                                            grow = Convert.ToInt32(TextBox9.Text);
                                            Label8.Text = "";
                                            if (grow.ToString().Length < 5 && grow.ToString().Length > 0)
                                            {
                                                ind = Convert.ToInt32(TextBox10.Text);
                                                Label9.Text = "";
                                                if (ind.ToString().Length < 5 && ind.ToString().Length > 0)
                                                {
                                                    change = Convert.ToInt32(TextBox11.Text);
                                                    Label10.Text = "";
                                                    if (change.ToString().Length < 5 && change.ToString().Length > 0)
                                                    {
                                                        safe = Convert.ToInt32(TextBox12.Text);
                                                        Label11.Text = "";
                                                        if (safe.ToString().Length < 2 && safe.ToString().Length > 0)
                                                        {
                                                            rating = TextBox13.Text;
                                                            Label12.Text = "";
                                                            if (rating.Length < 2 && rating != "")
                                                            {
                                                                rang = Convert.ToInt32(TextBox14.Text);
                                                                Label13.Text = "";
                                                                if (rang.ToString().Length < 2 && rang.ToString().Length > 0)
                                                                {
                                                                    outl = Convert.ToInt32(TextBox15.Text);
                                                                    Label14.Text = "";
                                                                    if (outl.ToString().Length < 2 && outl.ToString().Length > 0)
                                                                    {
                                                                        rcmnd = TextBox16.Text;
                                                                        Label15.Text = "";
                                                                        if (rcmnd.Length < 5 && rcmnd != "")
                                                                        {
                                                                            risk = TextBox17.Text;
                                                                            Label16.Text = "";
                                                                            if (risk.Length < 4 && risk != "")
                                                                            {
                                                                                Label17.Text = "";
                                                                                FileDBF db = new FileDBF();
                                                                                var dt = db.Execute(@"INSERT INTO D:\3kurs\TCPP\FirstdDB\DBDEMOS\master.dbf VALUES ('" + sym + "','" + name + "','" + birg + "','" + price + "','" + maxprice + "','" + minprice + "','" + rel + "','" + beta + "','" + grow + "','" + ind + "','" + change + "','" + safe + "','" + rating + "','" + rang + "','" + outl + "','" + rcmnd + "','" + risk + "');");
                                                                                GridView3.DataBind();
                                                                            }
                                                                            else Label17.Text = "Риски либо слишком большие, либо вы ничего не вписали";
                                                                        }
                                                                        else Label16.Text = "Рекомендации либо слишком большие, либо вы ничего не вписали";
                                                                    }
                                                                    else Label15.Text = "Прогноз либо слишком большой, либо вы ничего не вписали";
                                                                }
                                                                else Label14.Text = "Ранк либо слишком большой, либо вы ничего не вписали";
                                                            }
                                                            else Label13.Text = "Рейтинг либо слишком большой, либо вы ничего не вписали";
                                                        }
                                                        else Label12.Text = "Безопасность либо слишком большая, либо вы ничего не вписали";
                                                    }
                                                    else Label11.Text = "Изменение цены либо слишком большое, либо вы ничего не вписали";
                                                }
                                                else Label10.Text = "Индустрия либо слишком большая, либо вы ничего не вписали";
                                            }
                                            else Label9.Text = "Рост либо слишком большой, либо вы ничего не вписали";
                                        }
                                        else Label8.Text = "Бета либо слишком большая, либо вы ничего не вписали";
                                    }
                                    else Label7.Text = "Соотношение либо слишком большое, либо вы ничего не вписали";
                                }
                                else Label6.Text = "Минимальная цена либо слишком большая, либо вы ничего не вписали";
                            }
                            else Label5.Text = "Наивысшая цена либо слишком большая, либо вы ничего не вписали";
                        }
                        else Label4.Text = "Цена либо слишком большая, либо вы ничего не вписали";
                    }
                    else Label3.Text = "Биржа либо слишком большая, либо вы ничего не вписали";
                }
                else Label2.Text = "Название компании либо слишком большое, либо вы ничего не вписали";
            }
            else Label1.Text = "Символ либо слишком большой, либо вы ничего не вписали";

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            int id = 0;
            string symb = TextBox2.Text;
            int part = Convert.ToInt32(TextBox3.Text);
            int price = Convert.ToInt32(TextBox4.Text);
            string date = TextBox5.Text;
            
        }
    }
}