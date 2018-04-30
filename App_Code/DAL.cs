using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

/// <summary>
/// Summary description for DAL
/// </summary>
public class DAL
{
    private string conStr;
    private SqlConnection con;

    private Dictionary<string, Staff> allStaff;
    private Dictionary<string, Customer> customers;
    public DAL()
    {
        //
        // TODO: Add constructor logic here
        //

        //Create a ConnectionString calling it "conStr" for the SqlConnection
        conStr = ConfigurationManager.ConnectionStrings["UserDBConnectionString1"].ConnectionString;
        con = new SqlConnection(conStr);
        // Create 2 new Dictionary's for the staff and the customer
        allStaff = new Dictionary<string, Staff>();
        customers = new Dictionary<string, Customer>();
    }

    public DataTable getAllUserData() {


        //create a query to check the Users database        
        string myQuery = "SELECT * FROM Users";
        var myCommand = new SqlCommand(myQuery, con);
        SqlDataReader myResults;
        DataTable myDataTable = new DataTable();
            
        //serch the database for all the data on a user   
        try
        {
            con.Open();
            myResults = myCommand.ExecuteReader();

            if (myResults.HasRows == true)
            {
                myDataTable.Load(myResults);
            }

            return myDataTable;
        }
           
        catch (Exception e)
        {
            return myDataTable;
        }

        finally
        {
            con.Close();
            myCommand.Dispose();
        }
    }


    public DataTable getAllProductData()
    {

    
        
        //create a query to check the Products database    
            
        string myQuery = "SELECT * FROM Peoducts";
        var myCommand = new SqlCommand(myQuery, con);
        SqlDataReader myResults;
        DataTable myDataTable = new DataTable();
            
        //serch the database for all the data on a user   
        try
        {
            con.Open();
            myResults = myCommand.ExecuteReader();

            if (myResults.HasRows == true)
            {
                myDataTable.Load(myResults);
            }

            return myDataTable;
        }
           
        catch (Exception e)
        {
            return myDataTable;
        }

        finally
        {
            con.Close();
            myCommand.Dispose();
        }


    }
    

    public void loadUserdata() {
        DataTable UsersTable;

        UsersTable = this.getAllUserData();

        for (int i = 0; i <= UsersTable.Rows.Count - 1; i++)
        {
            string username = Convert.ToString(UsersTable.Rows[i][1]);
            string password = Convert.ToString(UsersTable.Rows[i][2]);
            string firstname = Convert.ToString(UsersTable.Rows[i][3]);
            string lastname = Convert.ToString(UsersTable.Rows[i][4]);
            string email = Convert.ToString(UsersTable.Rows[i][5]);
            string role = Convert.ToString(UsersTable.Rows[i][6]);
           
                 if (role.Equals("C"))
            {
                //create a new Customer
                Customer cust = new Customer();

                cust.setUsername(username);
                cust.setpassword(password);
                cust.setfirstname(firstname);
                cust.setlastname(lastname);
                cust.setemail(role);

                //add customer to the dictionary

                customers.Add(username, cust);
                customers.Add(password, cust);
                customers.Add(firstname, cust);
                customers.Add(lastname, cust);
                customers.Add(role, cust);

            }

                  else if (role == "S")
            {
                //create a new Staff

                Staff sta = new Staff();

                sta.setUsername(username);
                sta.setpassword(password);
                sta.setfirstname(firstname);
                sta.setlastname(lastname);
                sta.setemail(role);

                //add to staff dictionary

                allStaff.Add(username, sta);
                allStaff.Add(password, sta);
                allStaff.Add(firstname, sta);
                allStaff.Add(lastname, sta);
                allStaff.Add(role, sta);
                

            }
        }
    }

    public string retrieveStaffRole(string username)
    {
        // Create query to serch the staff database for a table with a given username
        string sql = "select * from StaffRoles where username=@username";
        string role = "";
        try
        {
            con.Open();
            SqlCommand com = new SqlCommand(sql,con);

           
            com.Parameters.AddWithValue("@username", username);
        //serch for the staff membbers job role
            SqlDataReader rdr = com.ExecuteReader();
            if (rdr.Read())
            {
                role = rdr["role"].ToString();
            }
        }
        catch (Exception e)
        {
            String error = e.Message;
           
        } finally
        {
            con.Close();
           
        }

        return "";

    }

    //write methods to get & set customers

    public Dictionary<string, Customer> getcustomers() { return this.customers; }
    public void setcustomers(Dictionary<string, Customer> customers) { this.customers = customers; }

     

    //write methods to get & set staff

    public Dictionary<string, Staff> getallStaff() { return this.allStaff; }
    public void setallStaff(Dictionary<string, Staff> allStaff) { this.allStaff = allStaff; }



    public Customer checkCustomerLogin(string usernameIn, string passwordIn)
    {


        if (customers.ContainsKey(usernameIn))
        {
            Customer customer = customers[usernameIn];

           if (customer.getpassword().Equals(passwordIn))
            {
                return customer;
            }
            
        }    

                
        return null;
    }


    public Staff checkStaffLogin(string usernameIn, string passwordIn)
    {

        if (allStaff.ContainsKey(usernameIn))
        {
            Staff s = allStaff[usernameIn];

            if (s.getpassword().Equals(passwordIn))
            {
                return s;
            }

        }


        return null;
    }

}