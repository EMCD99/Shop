using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Practice : System.Web.UI.Page
{

    private Dictionary<string, product> allProducts;

    public Dictionary<string, product> AllProducts
    {
        get
        {
            return allProducts;
        }

        set
        {
            allProducts = value;
        }
    }

    public Practice(Dictionary<string, product> allProducts)
    {
        this.AllProducts = allProducts;
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void load_Products_Click(object sender, EventArgs e)
    {

        product prod1 = new product("001", "Jeff", "A man", 2, 100);
        product prod2 = new product("002", "Geoff", "A smaller man", 1, 140);
        product prod3 = new product("003", "Water", "Some water", 30, 283);
        product prod4 = new product("004", "Air", "You can breathe it", 0, 999);
        product prod5 = new product("005", "Black", "Its just some black", 56, 458);
        


        AllProducts = new Dictionary<string, product>();
        AllProducts.Add("001", prod1);
        AllProducts.Add("002", prod2);
        AllProducts.Add("003", prod3);
        AllProducts.Add("004", prod4);
        AllProducts.Add("005", prod5);


        
        Drop1.DataSource = AllProducts;
        Drop1.DataTextField = "Value";
        Drop1.DataValueField = "Key";


        Drop1.DataBind();

 

    }

protected void load_customer_Click(object sender, EventArgs e)
    {

    }
}