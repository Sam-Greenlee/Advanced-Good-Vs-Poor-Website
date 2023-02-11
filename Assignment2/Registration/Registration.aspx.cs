using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registration_Registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnEnterForm_Click(object sender, EventArgs e)
    {
        string firstName;
        string lastName;
        string email;
        string phone;
        int numRec = 0;

        //Get the values from the form
        firstName = txtFirstName.Text;
        lastName = txtLastName.Text;
        email = txtEmailAddress.Text;
        phone = txtPhoneNumber.Text;

        //Make a customer object
        Registrations registrations = new Registrations(firstName, lastName, email, phone);

        //Add them to the database
        numRec = RegistrationsDA.AddRegistration(registrations);

        //Send them to a thank you page
        Session["registrations"] = registrations;

        Response.Redirect("~/Registration/ThankYou.aspx");
    }
}