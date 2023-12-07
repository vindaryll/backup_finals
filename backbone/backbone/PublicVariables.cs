using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace backbone
{
    public static class PublicVariables
    {
        // customer Info
        public static string customerName = "";
        public static string customerAddress = "";
        public static string customerContact = "";

        // Item info
        public static int[] itemID = new int[0];
        public static string[] itemName = new string[0];
        public static double[] itemPrice = new double[0];
        public static string[] itemDescription = new string[0];
        public static bool[] itemAvailability = new bool[0];
        public static int indexItem; // for orderitem and view order

        // for manipulation
        public static double[] itemQuantity = new double[0];
        public static double[] mealTotal = new double[0];
        public static double totalBill; // can also use on admin
        public static double totalQuantity;
        public static string paymentMethod = "";
        public static double paymentAmount; // can also use on admin
        public static double changeAmount; // can also use on admin

        // for checking
        public static int customerID;
        public static bool isNewCustomer = false;
        public static int orderID; // can also use on admin
        public static string date = "";


        // FOR ADMIN
            // ACCOUNT
        public static string username = "";
        public static string password = "";
        public static string verification = "";

            // ITEM
        public static int adminItemIndex;
        public static double currentPrice;


            // RECORDS
        public static int[] record_itemID = new int[0];
        public static string[] record_itemName = new string[0];
        public static double[] record_quantity = new double[0];
        public static double[] record_mealtotal = new double[0];




    }

}
