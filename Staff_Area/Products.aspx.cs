using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Staff_Area_Products : System.Web.UI.Page
{

    private  Dictionary<string, product> allProductsDisplay;

    protected void Page_Load(object sender, EventArgs e)
    {


        


        GridView1.DataSource = allProductsDisplay;





    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}