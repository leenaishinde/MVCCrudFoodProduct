using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using MVCProduct.Models;

namespace MVCProduct.Repository
{
    public class PrdRepository
    {

        private SqlConnection con;
        //To Handle connection related activities    
        private void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["getconn"].ToString();

            con = new SqlConnection(constr);
        }

        public bool AddProduct(ProductModel obj)
        {
            connection();
            SqlCommand com = new SqlCommand("AddNewPrdDetails", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Product_Name", obj.ProductName);
            com.Parameters.AddWithValue("@Category_Name", obj.CategoryName);
            com.Parameters.AddWithValue("@Product_Description", obj.ProductDescription);
            com.Parameters.AddWithValue("@Additional_Info", obj.AdditionalInfo);
            com.Parameters.AddWithValue("@Price", obj.Price);

            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //To Update Product details    
        public bool UpdateProduct(ProductModel obj)
        {
            connection();
            SqlCommand com = new SqlCommand("UpdatePrdDetails", con);

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Id", obj.Prdid);
            com.Parameters.AddWithValue("@Product_Name", obj.ProductName);
            com.Parameters.AddWithValue("@Category_Name", obj.CategoryName);
            com.Parameters.AddWithValue("@Product_Description", obj.ProductDescription);
            com.Parameters.AddWithValue("@Additional_Info", obj.AdditionalInfo);
            com.Parameters.AddWithValue("@Price", obj.Price);
            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteProduct(int Id)
        {

            connection();
            SqlCommand com = new SqlCommand("DeletePrdById", con);

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Id", Id);

            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<ProductModel> GetAllProducts()
        {
            connection();
            List<ProductModel> ProductList = new List<ProductModel>();

            SqlCommand com = new SqlCommand("GetProductDetails", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
        
            DataTable dt = new DataTable();

            con.Open();
            da.Fill(dt);
            con.Close();
            foreach (DataRow dr in dt.Rows)
            {

                ProductList.Add(

                    new ProductModel
                    {
                        Prdid = Convert.ToInt32(dr["Id"]),
                        ProductName = Convert.ToString(dr["Product_Name"]),
                        CategoryName = Convert.ToString(dr["Category_Name"]),
                        ProductDescription = Convert.ToString(dr["Product_Description"]),
                        AdditionalInfo = Convert.ToString(dr["Additional_Info"]),
                        Price = Convert.ToInt32(dr["Price"])
                    }
                  );
            }

            return ProductList;
        }

    }
}