using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Dapper;

namespace StockForms.DBWires
{
    /*
     * This Class gets a lot of use, because it is used to talk back and forth to the database.
     * There are no attributes, only functions. None static.
     * 
     * GetCustomers uses the name of a customer and returns the data as a List.
     *  This function is not used in the main software. It was used to test the
     *  connections to the database.
     *  
     * SendOrder is for sending the order to the database. This is for simply storing every order.
     *  The version that is obsolete was created before I wised up and just used an object for encapsulation.
     *  
     * ViewOrders is mainly for debugging. This function pulls all orders from the database.
     * 
     * ViewMostRecentOrder is to display the most recent order, such as after a purchase or a sale
     * 
     * ViewPortfolio is an obsolete function that I wrote before I discovered the DataGridView class
     * 
     * AlterPortfolio is for changing the data within the user portfolio. This function DOES NOT make
     *  use of the ALTER statement in SQL which changes the design of a table. This function DOES NOT
     *  change the the design of a table.
     */

    public class DataAccess {

        // DEBUG FUNCTION
        public List<Customer> GetCustomers(string name)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("portfolios")))
            {
                if (connection == null)
                    MessageBox.Show("CONNECTION PROBLEM!!!");

                else
                {
                    // Raw SQL (low security)
                    //var output = connection.Query<Customer>($"SELECT * FROM customers WHERE name = '{ name }';").ToList();

                    // Stored Procedure
                    var output = connection.Query<Customer>("dbo.Customers_GetByName @Name",
                        new { Name = name }).ToList();

                    return output;
                }
            }

            return null;
        }

        // OBSOLETE
        public void SendOrder(bool Buy, string StockTicker, string StockName, double Price, int Quantity)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("portfolios")))
            {
                /*
                Order Dummy = new Order
                {
                    StockTicker = "'" + StockTicker + "'",
                    StockName = "'" + StockName + "'",
                    Price = Price,
                    Quantity = Quantity
                };

                List<Order> Dummys = new List<Order>();

                Dummys.Add(new Order
                {
                    StockTicker = StockTicker,
                    StockName = StockName,
                    Price = Price,
                    Quantity = Quantity
                });

                foreach (var order in Dummys) MessageBox.Show(order.StockName);
                */
                //connection.Execute($"IF NOT EXISTS (SELECT 1 FROM stocks WHERE stock_ticker = '{StockTicker}') INSERT INTO stocks VALUES ('{StockTicker}', '{StockName}');");

                using (var comm = new SqlCommand("dbo.Stocks_Add", (SqlConnection)connection) { CommandType = CommandType.StoredProcedure })
                {
                    connection.Open();

                    comm.Parameters.AddWithValue("@StockTicker", StockTicker);
                    comm.Parameters.AddWithValue("@StockName", StockName);
                }

                //var output = connection.Execute(
                //"INSERT INTO orders VALUES (DEFAULT, '$AMD', 'Advanced Micro Devices', 65.15, 100");
                //"dbo.Orders_Place @StockTicker, @StockName, @Price, @Quantity", Dummys);

                using (var comm = new SqlCommand("dbo.Orders_Place", (SqlConnection)connection) { CommandType = CommandType.StoredProcedure })
                {
                    //connection.Open();

                    comm.Parameters.AddWithValue("@Buy", Buy);
                    comm.Parameters.AddWithValue("@StockTicker", StockTicker);
                    comm.Parameters.AddWithValue("@StockName", StockName);
                    comm.Parameters.AddWithValue("@Price", Price);
                    comm.Parameters.AddWithValue("@Quantity", Quantity);
                }


                //MessageBox.Show(output.ToString());
            }
        }

        // IN-USE
        public void SendOrder(Order order)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("portfolios")))
            {
                /*
                Order Dummy = new Order
                {
                    StockTicker = "'" + StockTicker + "'",
                    StockName = "'" + StockName + "'",
                    Price = Price,
                    Quantity = Quantity
                };

                List<Order> Dummys = new List<Order>();

                Dummys.Add(new Order
                {
                    StockTicker = StockTicker,
                    StockName = StockName,
                    Price = Price,
                    Quantity = Quantity
                });

                foreach (var order in Dummys) MessageBox.Show(order.StockName);
                */
                //connection.Execute($"IF NOT EXISTS (SELECT 1 FROM stocks WHERE stock_ticker = '{StockTicker}') INSERT INTO stocks VALUES ('{StockTicker}', '{StockName}');");
                /*
                using (var comm = new SqlCommand("dbo.Stocks_Add", (SqlConnection)connection) { CommandType = CommandType.StoredProcedure })
                {
                    connection.Open();

                    comm.Parameters.AddWithValue("@StockTicker", order.Stock_Ticker);
                    comm.Parameters.AddWithValue("@StockName", order.Stock_Name);
                }

                //var output = connection.Execute(
                //"INSERT INTO orders VALUES (DEFAULT, '$AMD', 'Advanced Micro Devices', 65.15, 100");
                //"dbo.Orders_Place @StockTicker, @StockName, @Price, @Quantity", Dummys);

                using (var comm = new SqlCommand("dbo.Orders_Place", (SqlConnection)connection) { CommandType = CommandType.StoredProcedure })
                {
                    //connection.Open();

                    comm.Parameters.AddWithValue("@Buy", Buy);
                    comm.Parameters.AddWithValue("@StockTicker", order.Stock_Ticker);
                    comm.Parameters.AddWithValue("@StockName", order.Stock_Name);
                    comm.Parameters.AddWithValue("@Price", order.Price);
                    comm.Parameters.AddWithValue("@Quantity", order.Quantity);
                }
                */
                //MessageBox.Show(output.ToString());

                // This block is for inserting stocks into the database that are not already there
                try {
                    connection.Query(
                        $"INSERT INTO stocks VALUES ({ order.Stock_Ticker }, { order.Stock_Name })"
                    );
                } catch (Exception ex) { } //MessageBox.Show(ex.Message); }

                // This block enters the order into the database
                try {
                    connection.Query(
                        $"INSERT INTO orders " +
                        $"VALUES (" +
                            $"{ (order.Buy ? "1" : "0") }, " +
                            $"DEFAULT, " +
                            $"{ order.Stock_Ticker }, " +
                            $"{ order.Stock_Name }, " +
                            $"{ order.Price }, " +
                            $"{ order.Quantity });"
                    );}
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        // DEBUG FUNCTION
        public List<Order> ViewOrders()
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("portfolios")))
            {
                var output = connection.Query<Order>("SELECT * FROM orders;").ToList();
                return output;
            }
        }

        // IN-USE
        public List<Order> ViewMostRecentOrder() {

            using (IDbConnection conn = new SqlConnection(Helper.CnnVal("portfolios")))
            {
                var output = conn.Query<Order>(
                    "SELECT * " + //"date_time, stock_ticker, stock_name, price, quantity " +
                    "FROM orders " +
                    "WHERE date_time = " +
                        "(SELECT max(o1.date_time) " +
                        "FROM orders o1);"
                ).ToList();

                return output;
            }
        }

        // OBSOLETE
        public List<Customer_Portfolio> ViewPortfolio() {

            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("portfolios"))) {

                var rows = connection.Query<Customer_Portfolio>("SELECT * FROM portfolio;").ToList();
                return rows;
            }
        }

        // IN-USE
        public void AlterPortfolio(Order order) {
            // THIS FUNCTION DOES NOT UTILIZE THE ALTER SQL STATEMENT
            // NO TABLES ARE BEING ALTERED

            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("portfolios"))) {

                // If this is a BUY order
                if (order.Buy) {

                    // Store the row from the db
                    var rows = connection.Query<Customer_Portfolio>(
                        $"SELECT * FROM portfolio WHERE stock_ticker = { order.Stock_Ticker };"
                    ).ToList();

                    // If the list is not empty, this means that there is an existing security in the portfolio
                    if (rows.Count > 0) {

                        // Calculate the new stats of the security
                        int totalQuantity = rows[0].Quantity_Owned + order.Quantity; // new Quantity (added together)
                        double totalTotal = rows[0].Total + order.Total; // New Totals (added together)
                        double newDca = totalTotal / totalQuantity; // New DCA (total divided by quantity)

                        // Update the database with the new information
                        connection.Query(
                            $"UPDATE portfolio " +
                            $"SET " +
                                $"quantity_owned =  { totalQuantity }, " +
                                $"dollar_cost_average = {newDca}, " +
                                $"total = { totalTotal } " +
                            $"WHERE stock_ticker = { order.Stock_Ticker }" +
                            ";"
                        );
                    }

                    // If the list is empty, there there are no existing securities in the portfolio
                    else {
                        //MessageBox.Show("ELSE");
                        
                        // This statement inserts the raw order values, because there is nothing to add to
                        connection.Query(
                            $"INSERT INTO portfolio VALUES(" +
                                $"{ order.Stock_Ticker }, " +
                                $"{ order.Stock_Name }, " +
                                $"{ order.Quantity }, " +
                                $"{ order.Price }, " +
                                $"{ order.Price * order.Quantity }" + 
                            ");"
                        );
                    }
                }
                // If it is a SELL order
                else {

                    // Store the portfolio row in a Customer_Portfolio object
                    var row = connection.Query<Customer_Portfolio>(
                        $"SELECT * FROM portfolio WHERE stock_ticker LIKE {order.Stock_Ticker};"
                    ).ToList()[0];

                    // If the user owns more shares than the order calls for
                    if (row.Quantity_Owned > order.Quantity)
                    {
                        // Calculate new stats
                        int totalQuantity = row.Quantity_Owned - order.Quantity; // Remove the order from the quantity owned
                        double totalTotal = row.Total - order.Total; // Remove the total of the order from the total of the owned securities

                        // Update the database with the new data
                        connection.Query(
                            $"UPDATE portfolio " +
                            $"SET " +
                                $"quantity_owned =  {totalQuantity}, " +
                                $"total = {totalTotal} " +
                            $"WHERE stock_ticker = {order.Stock_Ticker}" +
                            ";"
                        );
                    }
                    // If the amount owned is equal to the quantity on the order
                    else if (row.Quantity_Owned == order.Quantity)
                    {
                        // Remove all data
                        connection.Query(
                            $"DELETE FROM portfolio WHERE stock_ticker LIKE '{ order.Stock_Ticker }';"
                        );
                    }
                    // If there are more shares on the order than in the portfolio, this message is kicked
                    else MessageBox.Show("You do not have enough shares for this trade!!");
                }
            }
        }
    }
}
