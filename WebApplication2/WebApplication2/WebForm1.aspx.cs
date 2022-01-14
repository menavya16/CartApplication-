using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\navya\source\repos\WebApplication2\WebApplication2\App_Data\cookie.mdf;Integrated Security=True;");
        protected void Page_Load(object sender, EventArgs e)
        {
            visitor_count();
            Add_visitor();
            Label1.Text = "Your IP address is " + getIP();
            lblDateTime.Text = DateTime.Now.ToString();
        }
        public void visitor_count()
        {
            con.Open();
            string str = "select cnt from counts order by cnt";
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblcount.Text = dr["cnt"].ToString();
            }
            int i = int.Parse(lblcount.Text);
            i = i + 1;
            lblcount.Text = i.ToString();
            dr.Close();
            con.Close();
        }

        public void Add_visitor()
        {
            con.Open();
            string str = "insert into counts values('" + lblcount.Text + "')";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public string getIP()
        {
            string IP = string.Empty;
            if(System.Web.HttpContext.Current.Request.ServerVariables["HTTP_x_FORWARDED_FOR"]!=null)
            {
                IP = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_x_FORWARDED_FOR"].ToString();
            }else
            {
                IP = System.Web.HttpContext.Current.Request.UserHostAddress;
            }
            return IP;

        }
    }
}