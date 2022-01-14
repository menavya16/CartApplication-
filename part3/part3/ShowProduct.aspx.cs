using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace part3
{
    public partial class ShowProduct : System.Web.UI.Page
    {
        static int c;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["p1"]==null)
                {
                    pd.Visible = false;
                    Label3.Visible = true;

                }
            }
                

        }
    }
}