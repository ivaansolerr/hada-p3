﻿using System;
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
                    string insertQuery = "INSERT INTO Products (name,code,amount,price,category,creationDate)" +
                        " VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6)";
                    SqlCommand cmd = new SqlCommand(insertQuery, myDb);
                    using (cmd)
                    {
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

        public bool Update(ENProduct product)
        {
            try
            {
                SqlConnection myDb = new SqlConnection(constring);
                using (myDb)
                {
                    myDb.Open();
                    string insertQuery = "UPDATE Products SET name=@Value2,amount=@Value3,price=@Value4,category=@Value5,creationDate=@Value6 WHERE code=@Value1";
                    SqlCommand cmd = new SqlCommand(insertQuery, myDb);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@Value1", product.Code);
                        cmd.Parameters.AddWithValue("@Value2", product.Name);
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
                    string insertQuery = "DELETE FROM Products where code=@Value1";
                    SqlCommand cmd = new SqlCommand(insertQuery, myDb);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@Value1", product.Code);

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
                    string insertQuery = "SELECT * from products WHERE code=@Value1";
                    SqlCommand cmd = new SqlCommand(insertQuery, myDb);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@Value1", product.Code);

                        SqlDataReader readd = cmd.ExecuteReader();

                        if (readd.Read())
                        {
                            product.Name = readd["name"].ToString();
                            product.Code = readd["code"].ToString();
                            product.Amount = int.Parse(readd["amount"].ToString());
                            product.Price = float.Parse(readd["price"].ToString());
                            product.Category = int.Parse(readd["category"].ToString());
                            product.CreationDate = DateTime.Parse(readd["creationDate"].ToString());
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
                    string insertQuery = "SELECT TOP (1) * from Products";
                    SqlCommand cmd = new SqlCommand(insertQuery, myDb);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@Value1", product.Code);

                        SqlDataReader readd = cmd.ExecuteReader();

                        if (readd.Read())
                        {
                            product.Name = readd["name"].ToString();
                            product.Code = readd["code"].ToString();
                            product.Amount = int.Parse(readd["amount"].ToString());
                            product.Price = float.Parse(readd["price"].ToString());
                            product.Category = int.Parse(readd["category"].ToString());
                            product.CreationDate = DateTime.Parse(readd["creationDate"].ToString());
                        } else
                        {
                            return false;
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

        public bool ReadNext(ENProduct product)
        {
            try
            {
                SqlConnection myDb = new SqlConnection(constring);
                using (myDb)
                {
                    myDb.Open();
                    string insertQuery = "SELECT * from products";
                    SqlCommand cmd = new SqlCommand(insertQuery, myDb);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@Value1", product.Code);

                        SqlDataReader readd = cmd.ExecuteReader();

                        while (readd.Read() && readd["code"].ToString() != product.Code) {
                        };

                        if (readd.Read())
                        {
                            product.Name = readd["name"].ToString();
                            product.Code = readd["code"].ToString();
                            product.Amount = int.Parse(readd["amount"].ToString());
                            product.Price = float.Parse(readd["price"].ToString());
                            product.Category = int.Parse(readd["category"].ToString());
                            product.CreationDate = DateTime.Parse(readd["creationDate"].ToString());
                        }

                        else
                        {
                            return false;
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
        public bool ReadPrev(ENProduct product)
        {
            try
            {
                SqlConnection myDb = new SqlConnection(constring);
                List<ENProduct> list = new List<ENProduct>();
                using (myDb)
                {
                    myDb.Open();
                    string insertQuery = "SELECT * from Products";
                    SqlCommand cmd = new SqlCommand(insertQuery, myDb);
                    using (cmd)
                    {

                        SqlDataReader readd = cmd.ExecuteReader();

                        while (readd.Read())
                        {
                            string name = readd["name"].ToString();
                            string code = readd["code"].ToString();
                            int amount = int.Parse(readd["amount"].ToString());
                            float price = float.Parse(readd["price"].ToString());
                            int category = int.Parse(readd["category"].ToString());
                            DateTime date = DateTime.Parse(readd["creationDate"].ToString());
                            ENProduct en = new ENProduct(code, name, amount,price,category,date);
                            list.Add(en);
                        }

                        readd.Close();

                        if (list[0].Code == product.Code) return false;

                        for (int i = 0; i < list.Count; i++)
                        {
                            
                            if (list[i].Code == product.Code)
                            {
                                if (i >= 1)
                                {
                                    ENProduct prev = new ENProduct(list[i - 1].Code, list[i - 1].Name, list[i - 1].Amount, list[i - 1].Price, list[i - 1].Category, list[i - 1].CreationDate);
                                    
                                    product.Name = prev.Name;
                                    product.Code = prev.Code;
                                    product.Amount = prev.Amount;
                                    product.Price = prev.Price;
                                    product.Category = prev.Category;
                                    product.CreationDate = prev.CreationDate;

                                    return true;
                                }
                            }
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
    }
}
