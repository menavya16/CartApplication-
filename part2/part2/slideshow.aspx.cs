using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace part2
{
    public partial class slideshow : System.Web.UI.Page
    {
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\navya\source\repos\part2\part2\App_Data\slideshow.mdf;Integrated Security=True;");
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {    
                  sequentialImageDisplay();
            }

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Timer1.Enabled = true;
            Timer2.Enabled = false;
            Timer3.Enabled = false;
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            Timer1.Enabled = false;
            Timer2.Enabled = false;
            Timer3.Enabled = true;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (Timer1.Enabled || Timer3.Enabled || Timer2.Enabled)
            {
                Timer1.Enabled = false;
                Timer2.Enabled = false;
                Timer3.Enabled = false;

            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (Timer2.Enabled==false)
            {
                Timer1.Enabled = false;//displays images randomly
                Timer2.Enabled = true;// goes backward
                Timer3.Enabled = false;//goes forward
                Button4.Text = ">>";
            }
            else
            {
                Timer1.Enabled = false;
                Timer2.Enabled = false;
                Timer3.Enabled = true;
                Button4.Text = "<<";
            }
           
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int i = rand.Next(1, 19);
            //i++;
            ViewState["ImageDisplayed"] = i;
            DataRow imageDataRow = ((DataSet)ViewState["ImageData"]).Tables["image"].Select().FirstOrDefault(x => x["order"].ToString() == i.ToString());
            if (imageDataRow != null)
            {
                Image1.ImageUrl = "~/Images/" + imageDataRow["name"].ToString();
                lblImageName.Text = imageDataRow["description"].ToString();
                lblImageOrder.Text = imageDataRow["order"].ToString();
            }
            else
            {
                randomImageDisplay();
            }
        }
       
        protected void Timer3_Tick(object sender, EventArgs e)
        {
            int i = (int)ViewState["ImageDisplayed"];
            i++;
            ViewState["ImageDisplayed"] = i;
            DataRow imageDataRow = ((DataSet)ViewState["ImageData"]).Tables["image"].Select().FirstOrDefault(x => x["order"].ToString() == i.ToString());
            if (imageDataRow!=null)
            {
                Image1.ImageUrl = "~/Images/" + imageDataRow["name"].ToString();
                lblImageName.Text = imageDataRow["description"].ToString();
                lblImageOrder.Text = imageDataRow["order"].ToString();
            }
            else
            {
                sequentialImageDisplay();
            }    
        }

        protected void Timer2_Tick(object sender, EventArgs e)
        {
            int i = (int)ViewState["ImageDisplayed"];
            i--;
            ViewState["ImageDisplayed"] = i;
            DataRow imageDataRow = ((DataSet)ViewState["ImageData"]).Tables["image"].Select().FirstOrDefault(x => x["order"].ToString() == i.ToString());
            if (imageDataRow != null)
            {
                Image1.ImageUrl = "~/Images/" + imageDataRow["name"].ToString();
                lblImageName.Text = imageDataRow["description"].ToString();
                lblImageOrder.Text = imageDataRow["order"].ToString();
            }
            else
            {
                sequentialImageDisplaybkwd();
            }
        }

        private void randomImageDisplay()
        {
            DataSet ds = new DataSet();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("spGetImageData", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(ds, "image");
            ViewState["ImageData"] = ds;
            ViewState["ImageDisplayed"] = 1;
            DataRow imageDataRow = ds.Tables["image"].Select().FirstOrDefault(x => x["order"].ToString() == "1");
            Image1.ImageUrl = "~/Images/" + imageDataRow["name"].ToString();
            lblImageName.Text = imageDataRow["description"].ToString();
            lblImageOrder.Text = imageDataRow["order"].ToString();
        }

        public void sequentialImageDisplay()
        {
            DataSet ds = new DataSet();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("spGetImageData", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(ds, "image");
            ViewState["ImageData"] = ds;
            ViewState["ImageDisplayed"] = 1;
            DataRow imageDataRow = ds.Tables["image"].Select().FirstOrDefault(x => x["order"].ToString() == "1");
            Image1.ImageUrl = "~/Images/" + imageDataRow["name"].ToString();
            lblImageName.Text = imageDataRow["description"].ToString();
            lblImageOrder.Text = imageDataRow["order"].ToString();
        }

        public void sequentialImageDisplaybkwd()
        {
            DataSet ds = new DataSet();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("spGetImageData", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(ds, "image");
            ViewState["ImageData"] = ds;
            ViewState["ImageDisplayed"] = 18;
            DataRow imageDataRow = ds.Tables["image"].Select().FirstOrDefault(x => x["order"].ToString() == "18");
            Image1.ImageUrl = "~/Images/" + imageDataRow["name"].ToString();
            lblImageName.Text = imageDataRow["description"].ToString();
            lblImageOrder.Text = imageDataRow["order"].ToString();
        }       
    }
}


