using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Order_Line
/// </summary>
public class Order_Line
{

    private product selectedProduct;
    private int Order_Line_ID;
    private int Quantity;
    private int Line_Price;
    private int Order_ID;

    public product SelectedProduct
    {
        get
        {
            return selectedProduct;
        }

        set
        {
            selectedProduct = value;
        }
    }

    public int Order_Line_ID1
    {
        get
        {
            return Order_Line_ID;
        }

        set
        {
            Order_Line_ID = value;
        }
    }

    public int Quantity1
    {
        get
        {
            return Quantity;
        }

        set
        {
            Quantity = value;
        }
    }

    public int Line_Price1
    {
        get
        {
            return Line_Price;
        }

        set
        {
            Line_Price = value;
        }
    }

    public int Order_ID1
    {
        get
        {
            return Order_ID;
        }

        set
        {
            Order_ID = value;
        }
    }

    public Order_Line()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public Order_Line(product selectedProduct, int order_Line_ID, int quantity, int line_Price, int order_ID)
    {
        this.selectedProduct = selectedProduct;
        Order_Line_ID = order_Line_ID;
        Quantity = quantity;
        Line_Price = line_Price;
        Order_ID = order_ID;
    }


    public int line_Price()
    {

        int price = 0;

        return price;
    }

}