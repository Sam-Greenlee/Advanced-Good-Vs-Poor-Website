using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registration_ThankYou : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //This is where we will retrive session info
        Registrations registrations;
        if (Session["registrations"] != null)
        {
            registrations = (Registrations)Session["registrations"];
            lblUser.Text = registrations.FirstName;

            Session.Remove("registrations");
        }
        else
        {
            Response.Redirect("~/Default.aspx");
        }
    }
}