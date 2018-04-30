using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for User
/// </summary>
public class User
{

    private string Username;
    private string password;
    private string firstname;
    private string lastname;
    private string email;

        public User()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public User(string username, string password, string firstname, string lastname, string email)
    {
        Username = username;
        this.password = password;
        this.firstname = firstname;
        this.lastname = lastname;
        this.email = email;
    }

    public string getUsername() { return this.Username; }
    public void setUsername(string Username) { this.Username = Username; }

    public string getpassword() { return this.password; }
    public void setpassword(string password) { this.password = password; }

    public string getfirstname() { return this.firstname; }
    public void setfirstname(string firstname) { this.firstname = firstname; }

    public string getlastname() { return this.lastname; }
    public void setlastname(string lastname) { this.lastname = lastname; }

    public string getemail() { return this.email; }
    public void setemail(string email) { this.email = email; }

}