using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Reflection;

namespace library
{
    public class CADProduct
    {
        private string constring;

        public string _constring
        {
            get { return constring; }
        }

        public CADProduct()
        {
            this.constring = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;
        }

        public bool Create(ENProduct product)
        {
            try
            {
                SqlConnection myDb = new SqlConnection(constring);
                using (myDb)
                {
                    myDb.Open();
                    // insert
                    string insertQuery = "INSERT INTO Products (id,name,code,amount,price,category,creationDate)" +
                        " VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7)";
                    SqlCommand cmd = new SqlCommand(insertQuery, myDb);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@Value1", product.Id);
                        cmd.Parameters.AddWithValue("@Value1", product.Name);
                        cmd.Parameters.AddWithValue("@Value2", product.Code);
                        cmd.Parameters.AddWithValue("@Value3", product.Amount);
                        cmd.Parameters.AddWithValue("@Value4", product.Price);
                        cmd.Parameters.AddWithValue("@Value5", product.Category);
                        cmd.Parameters.AddWithValue("@Value6", product.CreationDate);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                return false;
            }

            return true;
        }

        public bool Update(ENProduct product)
        {
            try
            {
                SqlConnection myDb = new SqlConnection(constring);
                using (myDb)
                {
                    myDb.Open();
                    // insert
                    string insertQuery = "UPDATE Products set id=@Value1,name=@Value2,code=@Value3,amount=@Value4,price=@Value5,category=@Value6,creationDate=@Value7";
                    SqlCommand cmd = new SqlCommand(insertQuery, myDb);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@Value1", product.Id);
                        cmd.Parameters.AddWithValue("@Value1", product.Name);
                        cmd.Parameters.AddWithValue("@Value2", product.Code);
                        cmd.Parameters.AddWithValue("@Value3", product.Amount);
                        cmd.Parameters.AddWithValue("@Value4", product.Price);
                        cmd.Parameters.AddWithValue("@Value5", product.Category);
                        cmd.Parameters.AddWithValue("@Value6", product.CreationDate);

                        cmd.ExecuteNonQuery();

                        myDb.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                return false;
            }

            return true;
        }

        public bool Delete(ENProduct product)
        {
            try
            {
                SqlConnection myDb = new SqlConnection(constring);
                using (myDb)
                {
                    myDb.Open();
                    // insert
                    string insertQuery = "DELETE FROM Products where id=@Value1";
                    SqlCommand cmd = new SqlCommand(insertQuery, myDb);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@Value1", product.Id);

                        cmd.ExecuteNonQuery();

                        myDb.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                return false;
            }

            return true;
        }

        public bool Read(ENProduct product)
        {
            try
            {
                SqlConnection myDb = new SqlConnection(constring);
                using (myDb)
                {
                    myDb.Open();
                    // insert
                    string insertQuery = "SELECT * from products WHERE id=@Value1";
                    SqlCommand cmd = new SqlCommand(insertQuery, myDb);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@Value1", product.Id);

                        SqlDataReader readd = cmd.ExecuteReader();
                        while (readd.Read())
                        {

                        }

                        myDb.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                return false;
            }

            return true;
        }

        public bool ReadFirst(ENProduct product)
        {
            try
            {
                SqlConnection myDb = new SqlConnection(constring);
                using (myDb)
                {
                    myDb.Open();
                    // insert
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                return false;
            }

            return true;
        }

        public bool ReadNext(ENProduct product)
        {
            try
            {
                SqlConnection myDb = new SqlConnection(constring);
                using (myDb)
                {
                    myDb.Open();
                    // insert
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                return false;
            }

            return true;
        }
        public bool ReadPrev(ENProduct product)
        {
            try
            {
                SqlConnection myDb = new SqlConnection(constring);
                using (myDb)
                {
                    myDb.Open();
                    // insert
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                return false;
            }

            return true;
        }
    }
}
