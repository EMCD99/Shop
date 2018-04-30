using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Order
/// </summary>
public class Order
{

    private int order_ID;
    private string username;
    private List<Order_Line> order_Line;
    private DateTime order_Date;

    public int Order_ID
    {
        get
        {
            return order_ID;
        }

        set
        {
            order_ID = value;
        }
    }

    public string Username
    {
        get
        {
            return username;
        }

        set
        {
            username = value;
        }
    }

    public List<Order_Line> Order_Line
    {
        get
        {
            return order_Line;
        }

        set
        {
            order_Line = value;
        }
    }

    public DateTime Order_Date
    {
        get
        {
            return order_Date;
        }

        set
        {
            order_Date = value;
        }
    }

    public Order()
    {
        //
        // TODO: Add constructor logic here
        //


    }

    public Order(int order_ID, string username, List<Order_Line> order_Line, DateTime order_Date)
    {
        this.order_ID = order_ID;
        this.username = username;
        this.order_Line = order_Line;
        this.order_Date = order_Date;
    }
}