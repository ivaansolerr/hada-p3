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
                    // create
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
