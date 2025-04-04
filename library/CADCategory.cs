using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace library
{
    public class CADCategory
    {
        private List<ENCategory> enCategories = new List<ENCategory>();
        private string constring;

        public string _constring
        {
            get { return constring; }
        }

        public CADCategory()
        {
            this.constring = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;
        }
        public bool read(ENCategory en)
        {
            try
            {
                SqlConnection myDb = new SqlConnection(constring);
                using (myDb)
                {
                    myDb.Open();
                    string insertQuery = "SELECT * from categories WHERE id=@Value1";
                    SqlCommand cmd = new SqlCommand(insertQuery, myDb);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@Value1", en.Id);

                        SqlDataReader readd = cmd.ExecuteReader();

                        if (readd.Read())
                        {
                            en.Name = readd["name"].ToString();
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

            enCategories.Add(en);

            return true;
        }
        public List<ENCategory> readAll()
        {
            return enCategories;
        }
    }
}