using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Runtime.InteropServices;

namespace Garden
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string add(Product product)
        {
            string msg;
            SqlConnection sqlConnection = new SqlConnection("Data Source=MSI\\SQLEXPRESS19;Initial Catalog=GardenDB;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("insert into product(name,price) values(@Name,@Price)", sqlConnection);
            //cmd.Parameters.AddWithValue("@Id", product.ID);
            cmd.Parameters.AddWithValue("@Name", product.Name);
            cmd.Parameters.AddWithValue("@Price", product.Price);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                msg = product.Name + " and " + product.Price + " Details inserted successfully";
            }
            else
            {
                msg = product.Name +" and " + product.Price + " Details not inserted successfully";

            }
            sqlConnection.Close();
            return msg;
        }
        public List<Product> getAll()
        {
            List<Product> allProducts = new List<Product>();
            DataSet productData = new DataSet();
            SqlConnection con = new SqlConnection("Data Source=MSI\\SQLEXPRESS19;Initial Catalog=GardenDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from product", con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(productData);
            cmd.ExecuteNonQuery();
            con.Close();
            for (int row = 0; row < productData.Tables[0].Rows.Count; row++)
            {
                Product product= new Product();
                product.ID = Int32.Parse(productData.Tables[0].Rows[row][0].ToString());
                product.Name = productData.Tables[0].Rows[row][1].ToString();
                allProducts.Add(product);
            }
            return allProducts;
        }
        public Product get(int id)
        {
            DataSet productData = new DataSet();
            SqlConnection con = new SqlConnection("Data Source=MSI\\SQLEXPRESS19;Initial Catalog=GardenDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from  product where id=@Id", con);
            cmd.Parameters.AddWithValue("@Id", id);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(productData);
            cmd.ExecuteNonQuery();
            con.Close();

            Product product = new Product();
            product.ID = Int32.Parse(productData.Tables[0].Rows[0][0].ToString());
            product.Name = productData.Tables[0].Rows[0][1].ToString();

            return product;
        }
        public string update(Product product)
        {
            string msg;
            SqlConnection sqlConnection = new SqlConnection("Data Source=MSI\\SQLEXPRESS19;Initial Catalog=GardenDB;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("update product set name = @Name, price = @Price where id = @Id", sqlConnection);
            cmd.Parameters.AddWithValue("@Id", product.ID);
            cmd.Parameters.AddWithValue("@Name", product.Name);
            cmd.Parameters.AddWithValue("@Price", product.Price);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                msg = product.Name + " and " + product.Price + " Details updated successfully";
            }
            else
            {
                msg = product.Name + " and " + product.Price + " Details not updated successfully";

            }
            sqlConnection.Close();
            return msg;
        }
        public string delete(Product product)
        {
            string msg;
            SqlConnection sqlConnection = new SqlConnection("Data Source=MSI\\SQLEXPRESS19;Initial Catalog=GardenDB;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("delete from product where id = @Id", sqlConnection);
            cmd.Parameters.AddWithValue("@Id", product.ID);

            int result = cmd.ExecuteNonQuery();
             if (result == 1)
            {
                msg = product.Name + " and " + product.Price + " Details deleted successfully";
            }
            else
            {
                msg = product.Name +" and " + product.Price + " Details not deleted successfully";

            }
            sqlConnection.Close();
            return msg;
        }
    }
}
