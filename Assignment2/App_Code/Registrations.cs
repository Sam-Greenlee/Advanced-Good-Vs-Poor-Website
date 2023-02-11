using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Customer
/// </summary>
public class Registrations
{
    public int RegistrationId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    public Registrations(string fName, string lName, string theEmail, string thePhone)
    {
        FirstName = fName;
        LastName = lName;
        Email = theEmail;
        Phone = thePhone;
    }
}