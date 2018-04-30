using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Staff
/// </summary>
public class Staff : User
{
    private string staffRole;

    public Staff() : base()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public Staff(string username, string password, string firstname, string lastname, string email, string staffRole) : base(username, password, firstname, lastname, email)
    {
        this.staffRole = staffRole;
    }

    public Staff(string staffRole)
    {
        this.staffRole = staffRole;
    }

    public string getstaffRole() { return this.staffRole; }
    public void setstaffRole(string staffRole) { this.staffRole = staffRole; }

}