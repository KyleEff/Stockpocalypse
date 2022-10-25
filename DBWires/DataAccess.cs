﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using StockForms.Forms;

namespace StockForms.DBWires
{
    public class DataAccess
    {
        private string SqlStatement { get; set; }
        private string Stored_Procedure { get; set; }

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

        public List<Order> ViewOrders()
        {

            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("portfolios")))
            {
                var output = connection.Query<Order>("SELECT * FROM orders;").ToList();
                return output;
            }
        }

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
    }
}