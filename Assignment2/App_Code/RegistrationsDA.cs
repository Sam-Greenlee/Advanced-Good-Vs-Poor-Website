using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for RegistrationsDA
/// </summary>
public class RegistrationsDA
{
    public RegistrationsDA()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    private static string GetConnectionString()
    {
        return ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    }

    public static int AddRegistration(Registrations registrations)
    {
        int numRec = 0;

        string sql = "Insert into Registrations (FirstName, LastName, Email, Phone) values (@fname, @lname, @email, @phone)";

        //We need a connection object
        SqlConnection conn = new SqlConnection(GetConnectionString());

        SqlCommand cmd = new SqlCommand(sql, conn);

        cmd.Parameters.AddWithValue("@fname", registrations.FirstName);
        cmd.Parameters.AddWithValue("@lname", registrations.LastName);
        cmd.Parameters.AddWithValue("@email", registrations.Email);
        cmd.Parameters.AddWithValue("@phone", registrations.Phone);

        conn.Open();

        numRec = cmd.ExecuteNonQuery(); //Add the value to the database

        conn.Close();

        return numRec;
    }
}