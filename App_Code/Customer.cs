using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Customer
/// </summary>
public class Customer : User
{

    private string membershipType = "Standard";

    public Customer() : base()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public Customer(string username, string password, string firstname, string lastname, string email, string membershipType) : base(username, password, firstname, lastname, email)
    {
        this.membershipType = membershipType;
    }

    public Customer(string membershipType)
    {
        this.membershipType = membershipType;
    }

    public string getmembershipType() { return this.membershipType; }
    public void setmembershipType(string membershipType) { this.membershipType = membershipType; }
}