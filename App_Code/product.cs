using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for product
/// </summary>
public class product
{



    private string Product_ID;
    private string Product_Name;
    private string Product_Description;
    private int Product_Price;
    private decimal Product_Stock;

    public string Product_ID1
    {
        get
        {
            return Product_ID;
        }

        set
        {
            Product_ID = value;
        }
    }

    public string Product_Name1
    {
        get
        {
            return Product_Name;
        }

        set
        {
            Product_Name = value;
        }
    }

    public string Product_Description1
    {
        get
        {
            return Product_Description;
        }

        set
        {
            Product_Description = value;
        }
    }

    public int Product_Price1
    {
        get
        {
            return Product_Price;
        }

        set
        {
            Product_Price = value;
        }
    }

    public decimal Product_Stock1
    {
        get
        {
            return Product_Stock;
        }

        set
        {
            Product_Stock = value;
        }
    }

    public product()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public product(string product_ID, string product_Name, string product_Description, int product_Price, decimal product_Stock)
    {
        Product_ID1 = product_ID;
        Product_Name1 = product_Name;
        Product_Description1 = product_Description;
        Product_Price1 = product_Price;
        Product_Stock1 = product_Stock;
    }

    public override string ToString()
    {
        return Product_Name1;
    }

}