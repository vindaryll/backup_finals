using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using backbone;



namespace backbone
{
    public class Functions
    {            

        DbConnect dbcon = new DbConnect();

        public void Displaydata(DataGridView dgv, string query)
        {

            dbcon.OpenCon();
            // query = "SELECT ItemID, ItemName, Price, Description, Availability FROM Item ORDER BY ItemID;";
            DataTable dt = new DataTable();
            MySqlDataAdapter adapt= new MySqlDataAdapter(query, dbcon.Getcon());
            adapt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dgv.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No data found.");
            }

            dbcon.CloseCon();

        }


        public void VarReset()
        {
            // reseting strings, arrays, and numeric values to default
            PublicVariables.customerName = string.Empty;
            PublicVariables.customerAddress = string.Empty;
            PublicVariables.customerContact = string.Empty;

            for (int i = 0; i < PublicVariables.itemID.Length; i++)
            {
                PublicVariables.itemID[i] = 0;
            }
            for (int i = 0; i < PublicVariables.itemName.Length; i++)
            {
                PublicVariables.itemName[i] = string.Empty;
            }
            for (int i = 0; i < PublicVariables.itemPrice.Length; i++)
            {
                PublicVariables.itemPrice[i] = 0;
            }
            for (int i = 0; i < PublicVariables.itemDescription.Length; i++)
            {
                PublicVariables.itemDescription[i] = string.Empty;
            }
            for (int i = 0; i < PublicVariables.itemAvailability.Length; i++)
            {
                PublicVariables.itemAvailability[i] = false;
            }
            for (int i = 0; i < PublicVariables.itemQuantity.Length; i++)
            {
                PublicVariables.itemQuantity[i] = 0;
            }
            for (int i = 0; i < PublicVariables.mealTotal.Length; i++)
            {
                PublicVariables.mealTotal[i] = 0;
            }

            PublicVariables.indexItem = 0;
            PublicVariables.paymentMethod = string.Empty;
            PublicVariables.paymentAmount = 0;
            PublicVariables.changeAmount = 0;
            PublicVariables.totalQuantity = 0;
            PublicVariables.totalBill = 0;
            PublicVariables.customerID = 0;
            PublicVariables.isNewCustomer = false;
            PublicVariables.orderID = 0;
            PublicVariables.transacID = 0;
            PublicVariables.orderItemID = 0;
            PublicVariables.date = string.Empty;


            // wala pa yung asa admin
        }

        // REFRESHING DATA ON DB
        public void refreshCustomer()
        {
            try
            {
                dbcon.OpenCon();
                string query = "UPDATE Customer AS c JOIN (SELECT CustomerID, ROW_NUMBER() OVER (ORDER BY CustomerID) AS new_customer_id FROM Customer) AS rc ON c.CustomerID = rc.CustomerID SET c.CustomerID = rc.new_customer_id";
                MySqlCommand cmd = new MySqlCommand(query, dbcon.Getcon());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbcon.CloseCon();
            }
        }

        public void refreshOrders()
        {
            try
            {
                dbcon.OpenCon();
                string query = "UPDATE Orders AS o JOIN (SELECT OrderID, ROW_NUMBER() OVER (ORDER BY OrderID) AS new_order_id FROM Orders) AS ro ON o.OrderID = ro.OrderID SET o.OrderID = ro.new_order_id";
                MySqlCommand cmd = new MySqlCommand(query, dbcon.Getcon());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbcon.CloseCon();
            }
        }

        public void refreshOrderTransaction()
        {
            try
            {
                dbcon.OpenCon();
                string query = "UPDATE OrderTransaction AS ot JOIN (SELECT TransactionID, ROW_NUMBER() OVER (ORDER BY TransactionID) AS new_transaction_id FROM OrderTransaction) AS rot ON ot.TransactionID = rot.TransactionID SET ot.TransactionID = rot.new_transaction_id";
                MySqlCommand cmd = new MySqlCommand(query, dbcon.Getcon());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbcon.CloseCon();
            }
        }

        public void refreshOrderItem()
        {
            try
            {
                dbcon.OpenCon();
                string query = "UPDATE OrderItem AS oi JOIN (SELECT OrderItemID, ROW_NUMBER() OVER (ORDER BY OrderItemID) AS new_orderitem_id FROM OrderItem) AS roi ON oi.OrderItemID = roi.OrderItemID SET oi.OrderItemID = roi.new_orderitem_id";
                MySqlCommand cmd = new MySqlCommand(query, dbcon.Getcon());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbcon.CloseCon();
            }
        }

        // FOR INSERTING DATA ON DB
        public void InsertCustomers(string customername, string customercontact, string customeraddress)
        {
            try
            {
                dbcon.OpenCon();
                string query = $"INSERT INTO Customer (CustomerName, ContactNumber, Address) VALUES ('{customername}', '{customercontact}', '{customeraddress}');";
                MySqlCommand cmd = new MySqlCommand(query, dbcon.Getcon());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbcon.CloseCon();
            }
        }

        public void InsertOrders(int customerid, string paymentmethod)
        {
            try
            {
                dbcon.OpenCon();
                string query = $"INSERT INTO Orders (CustomerID, OrderTime, PaymentMethod) VALUES ({customerid}, CURRENT_TIMESTAMP, '{paymentmethod}');";
                MySqlCommand cmd = new MySqlCommand(query, dbcon.Getcon());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbcon.CloseCon();
            }
        }

        public void InsertOrderTransaction(int orderid, double total, double paymentamount, double changeamount)
        {
            try
            {
                dbcon.OpenCon();
                string query = $"INSERT INTO OrderTransaction (OrderID, Total, AmountPaid, ChangeAmount) VALUES ({orderid}, {total}, {paymentamount}, {changeamount});";
                MySqlCommand cmd = new MySqlCommand(query, dbcon.Getcon());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbcon.CloseCon();
            }
        }

        public void InsertOrderItem(int orderid, int itemid, double itemquantity, double mealtotal)
        {
            try
            {
                dbcon.OpenCon();
                string query = $"INSERT INTO OrderItem (OrderID, ItemID, Quantity, MealTotal) VALUES ({orderid}, {itemid}, {itemquantity}, {mealtotal})";
                MySqlCommand cmd = new MySqlCommand(query, dbcon.Getcon());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbcon.CloseCon();
            }
        }

        public void getCustomerID(string name, string contact)
        {
            try
            {
                dbcon.OpenCon();
                string query = "SELECT CustomerID FROM customer WHERE CustomerName = '" + name + "' AND ContactNumber = '" + contact + "' LIMIT 1;";
                MySqlCommand cmd = new MySqlCommand(query, dbcon.Getcon());
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    PublicVariables.customerID = reader.GetInt32(reader.GetOrdinal("CustomerID"));     
                }
                else
                {
                    dbcon.CloseCon();

                    dbcon.OpenCon();
                    string query2 = "SELECT CustomerID FROM customer ORDER BY CustomerID DESC LIMIT 1;";
                    cmd = new MySqlCommand(query2, dbcon.Getcon());
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {          
                        reader.Read();
                        PublicVariables.customerID = reader.GetInt32(reader.GetOrdinal("CustomerID")) + 1;
                        PublicVariables.isNewCustomer = true;
                    }
                    else
                    {
                        PublicVariables.customerID = 1;
                        PublicVariables.isNewCustomer = true;
                    }
                    
                 

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbcon.CloseCon();
            }
        }

        public void getOrderID()
        {
            try
            {
                dbcon.OpenCon();
                string query = "SELECT OrderID FROM orders ORDER BY OrderID DESC LIMIT 1;";
                MySqlCommand cmd = new MySqlCommand(query, dbcon.Getcon());
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    PublicVariables.orderID = reader.GetInt32(reader.GetOrdinal("OrderID")) + 1;
                    reader.Close();
                }
                else
                {
                    PublicVariables.orderID = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbcon.CloseCon();
            }
            

        }

        public void getDate()
        {
            try
            {
                dbcon.OpenCon();
                string query = $"SELECT OrderTime FROM ORDERS WHERE OrderID = {PublicVariables.orderID};";
                MySqlCommand cmd = new MySqlCommand(query, dbcon.Getcon());
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    PublicVariables.date = reader.GetString(reader.GetOrdinal("OrderTime"));
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Insert the data on the db first");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbcon.CloseCon();
            }
        }

        // FOR ORDER PROCESS
        public void getItemInfo()
        {
            int i = 0;
            int rowCount = 0;
            try
            {
                dbcon.OpenCon();

                string query = "SELECT ItemID, ItemName, Price, Description, Availability FROM Item ORDER BY ItemID;";
                MySqlCommand cmd = new MySqlCommand(query, dbcon.Getcon());
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        rowCount++; // to get the size of array
                    }

                    PublicVariables.itemID = new int[rowCount];
                    PublicVariables.itemName = new string[rowCount];
                    PublicVariables.itemPrice = new double[rowCount];
                    PublicVariables.itemDescription = new string[rowCount];
                    PublicVariables.itemAvailability = new bool[rowCount];

                    PublicVariables.itemQuantity = new double[rowCount];
                    PublicVariables.mealTotal = new double[rowCount];


                    reader.Close();

                    // start new reading
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        PublicVariables.itemID[i] = reader.GetInt32(reader.GetOrdinal("ItemID"));
                        PublicVariables.itemName[i] = reader.GetString(reader.GetOrdinal("ItemName"));
                        PublicVariables.itemPrice[i] = reader.GetDouble(reader.GetOrdinal("Price"));
                        PublicVariables.itemDescription[i] = reader.GetString(reader.GetOrdinal("Description"));
                        PublicVariables.itemAvailability[i] = reader.GetBoolean(reader.GetOrdinal("Availability"));

                        i++;
                    }


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbcon.CloseCon();
            }
        }



        // FOR PICTURES
        public void picture(int index, PictureBox pictureBox1)
        {
            string[] maindish = new string[10];
            string[] Umaindish = new string[10];
            string[] sidedish = new string[5];
            string[] Usidedish = new string[5];
            string[] beverage = new string[7];
            string[] Ubeverage = new string[7];

            // for maindish
            for (int i = 0; i < 10; i++)
            {
                maindish[i] = $"C:\\Users\\daryll\\OneDrive\\Documents\\Project\\backbone\\backbone\\picture\\order\\maindish{i + 1:D2}.png";
                Umaindish[i] = $"C:\\Users\\daryll\\OneDrive\\Documents\\Project\\backbone\\backbone\\picture\\order\\Umaindish{i + 1:D2}.png";
            }
            // for sidedish
            for (int i = 0; i < 5; i++)
            {
                sidedish[i] = $"C:\\Users\\daryll\\OneDrive\\Documents\\Project\\backbone\\backbone\\picture\\order\\sidedish{i + 1:D2}.png";
                Usidedish[i] = $"C:\\Users\\daryll\\OneDrive\\Documents\\Project\\backbone\\backbone\\picture\\order\\Usidedish{i + 1:D2}.png";
            }
            // for beverages
            for (int i = 0; i < 7; i++)
            {
                beverage[i] = $"C:\\Users\\daryll\\OneDrive\\Documents\\Project\\backbone\\backbone\\picture\\order\\beverage{i + 1:D2}.png";
                Ubeverage[i] = $"C:\\Users\\daryll\\OneDrive\\Documents\\Project\\backbone\\backbone\\picture\\order\\Ubeverage{i + 1:D2}.png";
            }

            if (index <= 9 && index >= 0)
            {
                if (PublicVariables.itemAvailability[index])
                {
                    if (System.IO.File.Exists(maindish[index]))
                    {
                        pictureBox1.Image = Image.FromFile(maindish[index]);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        MessageBox.Show("Image file not found!");
                    }
                }
                else
                {
                    if (System.IO.File.Exists(Umaindish[index]))
                    {
                        pictureBox1.Image = Image.FromFile(Umaindish[index]);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        MessageBox.Show("Image file not found!");
                    }
                }
            }
            else if (index <= 14 && index >= 10)
            {
                if (PublicVariables.itemAvailability[index])
                {
                    if (System.IO.File.Exists(sidedish[index - 10]))
                    {
                        pictureBox1.Image = Image.FromFile(sidedish[index - 10]);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        MessageBox.Show("Image file not found!");
                    }
                }
                else
                {
                    if (System.IO.File.Exists(Usidedish[index - 10]))
                    {
                        pictureBox1.Image = Image.FromFile(Usidedish[index - 10]);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        MessageBox.Show("Image file not found!");
                    }
                }
            }
            else if (index <= 21 && index >= 15)
            {
                if (PublicVariables.itemAvailability[index])
                {
                    if (System.IO.File.Exists(beverage[index - 15]))
                    {
                        pictureBox1.Image = Image.FromFile(beverage[index - 15]);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        MessageBox.Show("Image file not found!");
                    }
                }
                else
                {
                    if (System.IO.File.Exists(Ubeverage[index - 15]))
                    {
                        pictureBox1.Image = Image.FromFile(Ubeverage[index - 15]);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        MessageBox.Show("Image file not found!");
                    }
                }
            }
        }

        public void picsUpdate(int index, Button btn1, Button btn2)
        {
            string[] maindish = new string[10];
            string[] Umaindish = new string[10];
            string[] sidedish = new string[5];
            string[] Usidedish = new string[5];
            string[] beverage = new string[7];
            string[] Ubeverage = new string[7];

            // for maindish
            for (int i = 0; i < 10; i++)
            {
                maindish[i] = $"C:\\Users\\daryll\\OneDrive\\Documents\\Project\\backbone\\backbone\\picture\\update\\maindish{i + 1:D2}.png";
                Umaindish[i] = $"C:\\Users\\daryll\\OneDrive\\Documents\\Project\\backbone\\backbone\\picture\\update\\Umaindish{i + 1:D2}.png";
            }
            // for sidedish
            for (int i = 0; i < 5; i++)
            {
                sidedish[i] = $"C:\\Users\\daryll\\OneDrive\\Documents\\Project\\backbone\\backbone\\picture\\update\\sidedish{i + 1:D2}.png";
                Usidedish[i] = $"C:\\Users\\daryll\\OneDrive\\Documents\\Project\\backbone\\backbone\\picture\\update\\Usidedish{i + 1:D2}.png";
            }
            // for beverages
            for (int i = 0; i < 7; i++)
            {
                beverage[i] = $"C:\\Users\\daryll\\OneDrive\\Documents\\Project\\backbone\\backbone\\picture\\update\\beverage{i + 1:D2}.png";
                Ubeverage[i] = $"C:\\Users\\daryll\\OneDrive\\Documents\\Project\\backbone\\backbone\\picture\\update\\Ubeverage{i + 1:D2}.png";
            }

            if (index <= 9 && index >= 0)
            {
                if (System.IO.File.Exists(maindish[index]))
                {
                    btn1.BackgroundImage = Image.FromFile(maindish[index]);
                    btn1.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else
                {
                    MessageBox.Show("Image file not found!");
                }

                if (System.IO.File.Exists(Umaindish[index]))
                {
                    btn2.BackgroundImage = Image.FromFile(Umaindish[index]);
                    btn2.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else
                {
                    MessageBox.Show("Image file not found!");
                }
            }
            else if (index <= 14 && index >= 10)
            {
                if (System.IO.File.Exists(sidedish[index - 10]))
                {
                    btn1.BackgroundImage = Image.FromFile(sidedish[index - 10]);
                    btn1.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else
                {
                    MessageBox.Show("Image file not found!");
                }
                if (System.IO.File.Exists(Usidedish[index - 10]))
                {
                    btn2.BackgroundImage = Image.FromFile(Usidedish[index - 10]);
                    btn2.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else
                {
                    MessageBox.Show("Image file not found!");
                }
            }
            else if (index <= 21 && index >= 15)
            {
                if (System.IO.File.Exists(beverage[index - 15]))
                {
                    btn1.BackgroundImage = Image.FromFile(beverage[index - 15]);
                    btn1.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else
                {
                    MessageBox.Show("Image file not found!");
                }
                if (System.IO.File.Exists(Ubeverage[index - 15]))
                {
                    btn2.BackgroundImage = Image.FromFile(Ubeverage[index - 15]);
                    btn2.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else
                {
                    MessageBox.Show("Image file not found!");
                }
            }
        }

        // ORDER PICTURES
        public void mainDish(PictureBox[] pictureBoxes)
        {
            string[] imagePaths = new string[10];
            for (int i = 0; i < 10; i++)
            {
                if (PublicVariables.itemAvailability[i])
                {
                    imagePaths[i] = $"C:\\Users\\daryll\\OneDrive\\Documents\\Project\\backbone\\backbone\\picture\\order\\maindish{i + 1:D2}.png";
                }
                else
                {
                    imagePaths[i] = $"C:\\Users\\daryll\\OneDrive\\Documents\\Project\\backbone\\backbone\\picture\\order\\Umaindish{i + 1:D2}.png";
                }
            }
            for (int i = 0; i < imagePaths.Length; i++)
            {
                pictureBoxes[i].Image = Image.FromFile(imagePaths[i]);
                pictureBoxes[i].SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        public void sideDish(PictureBox[] pictureBoxes)
        {
            string[] imagePaths = new string[5];
            for (int i = 0; i < 5; i++)
            {
                if (PublicVariables.itemAvailability[i + 10])
                {
                    imagePaths[i] = $"C:\\Users\\daryll\\OneDrive\\Documents\\Project\\backbone\\backbone\\picture\\order\\sidedish{i + 1:D2}.png";
                }
                else
                {
                    imagePaths[i] = $"C:\\Users\\daryll\\OneDrive\\Documents\\Project\\backbone\\backbone\\picture\\order\\Usidedish{i + 1:D2}.png";
                }
            }
            for (int i = 0; i < imagePaths.Length; i++)
            {
                pictureBoxes[i].Image = Image.FromFile(imagePaths[i]);
                pictureBoxes[i].SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        public void beverages(PictureBox[] pictureBoxes)
        {
            string[] imagePaths = new string[7];
            for (int i = 0; i < 7; i++)
            {
                if (PublicVariables.itemAvailability[i + 15])
                {
                    imagePaths[i] = $"C:\\Users\\daryll\\OneDrive\\Documents\\Project\\backbone\\backbone\\picture\\order\\beverage{i + 1:D2}.png";
                }
                else
                {
                    imagePaths[i] = $"C:\\Users\\daryll\\OneDrive\\Documents\\Project\\backbone\\backbone\\picture\\order\\Ubeverage{i + 1:D2}.png";
                }
            }
            for (int i = 0; i < imagePaths.Length; i++)
            {
                pictureBoxes[i].Image = Image.FromFile(imagePaths[i]);
                pictureBoxes[i].SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        // UPDATE

        public void updateAvailability(int index, bool var)
        {
            try
            {
                string query = $"UPDATE Item SET Availability = {var} WHERE ItemID = {index + 1};";
                dbcon.OpenCon();
                MySqlCommand cmd = new MySqlCommand(query, dbcon.Getcon());
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbcon.CloseCon();
            }
        }



        public void showItemOnDT(DataGridView dtv)
        {
            dtv.Rows.Clear();
            for (int i = 0; i < PublicVariables.itemID.Length; i++)
            {
                if (PublicVariables.itemQuantity[i] > 0)
                {
                    dtv.Rows.Add(
                        PublicVariables.itemID[i],
                        PublicVariables.itemName[i],
                        PublicVariables.itemQuantity[i],
                        PublicVariables.mealTotal[i]
                                );
                }

            }

        }



        // ADMIN
        public void getAdminInfo()
        {
            try
            {
                dbcon.OpenCon();
                string query = "SELECT Username, Password, Verification FROM Admin;";
                MySqlCommand cmd = new MySqlCommand(query, dbcon.Getcon());
                MySqlDataReader reader = cmd.ExecuteReader();

                reader.Read();
                PublicVariables.username = reader.GetString(reader.GetOrdinal("Username"));
                PublicVariables.password = reader.GetString(reader.GetOrdinal("Password"));
                PublicVariables.verification = reader.GetString(reader.GetOrdinal("Verification"));
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbcon.CloseCon();
            }
        }
        public void updatePass(string new_pass)
        {
            try
            {
                string query = $"UPDATE Admin SET Password = '{new_pass}' WHERE Username = 'Admin'";
                dbcon.OpenCon();
                MySqlCommand cmd = new MySqlCommand(query, dbcon.Getcon());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbcon.CloseCon();
            }
        }

        public void getCurrentPrice(int index)
        {
            try
            {
                string query = $"SELECT Price FROM item WHERE ItemID = '{index + 1}';";
                dbcon.OpenCon();
                MySqlCommand cmd = new MySqlCommand(query, dbcon.Getcon());
                MySqlDataReader reader = cmd.ExecuteReader();

                reader.Read();
                PublicVariables.currentPrice = reader.GetInt32(reader.GetOrdinal("Price"));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbcon.CloseCon();
            }
        }
        public void updatePrice(double price, int index)
        {
            try
            {
                string query = $"UPDATE Item SET Price = '{price}' WHERE ItemID = '{index + 1}';";
                dbcon.OpenCon();
                MySqlCommand cmd = new MySqlCommand(query, dbcon.Getcon());
                cmd.ExecuteNonQuery();
                // MessageBox.Show("Updated OrderItem!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbcon.CloseCon();
            }
        }








        //public void Exec(string query)
        //{
        //    try
        //    {
        //        dbcon.OpenCon();
        //        MySqlCommand cmd = new MySqlCommand(query, dbcon.Getcon());
        //        cmd.ExecuteNonQuery();
        //        // MessageBox.Show("Updated OrderItem!");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        dbcon.CloseCon();
        //    }
        //}

        //public void calcuTotal()
        //{
        //    for (int i = 0; i < PublicVariables.mealTotal.Length; i++)
        //    {
        //        PublicVariables.totalBill += PublicVariables.mealTotal[i];
        //        PublicVariables.totalQuantity += PublicVariables.itemQuantity[i];
        //    }
        //}
    }
}
