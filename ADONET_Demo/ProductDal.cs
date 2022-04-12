using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONET_Demo
{
    public class ProductDal
    {
        SqlConnection connection = new SqlConnection("server=");
        public List<Product> GetListAll()
        {
         
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand sql = new SqlCommand("SELECT * FROM Products", connection);
            SqlDataReader reader = sql.ExecuteReader();
            List<Product> PrList = new List<Product>();
            while (reader.Read())
            {
                Product prd2 = new Product {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                };
                PrList.Add(prd2);
            }
            reader.Close();
            connection.Close();
            return PrList;
        }

        public DataTable GetDataTableAll()
        {
           
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand sql = new SqlCommand("SELECT * FROM Products", connection);
            SqlDataReader reader = sql.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            reader.Close();
            connection.Close();
            return dt;
        }

        public void Add(Product models)
        {
      
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand sql = new SqlCommand("INSERT INTO PRODUCT VALUES(@NAME,@UnitPrice,@stokAmmonunt)", connection);
            sql.Parameters.AddWithValue("NAME",models.Name);
            sql.Parameters.AddWithValue("UnitPrice", models.UnitPrice);
            sql.Parameters.AddWithValue("stokAmmonunt", models.StockAmount);
            sql.ExecuteNonQuery();
            connection.Close();
        }
        public void Update(Product models)
        {

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand sql = new SqlCommand("update PRODUCT set NAME=@NAME,NAME=@UnitPrice,stokAmmonunt=@stokAmmonunt where ID=@ıd", connection);
            sql.Parameters.AddWithValue("ID", models.Id);
            sql.Parameters.AddWithValue("NAME", models.Name);
            sql.Parameters.AddWithValue("UnitPrice", models.UnitPrice);
            sql.Parameters.AddWithValue("stokAmmonunt", models.StockAmount);
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public void Delete(int models)
        {

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand sql = new SqlCommand("delete from PRODUCT  where ID=@ıd", connection);
            sql.Parameters.AddWithValue("ID", models);
         
            sql.ExecuteNonQuery();
            connection.Close();
        }
    }
}
