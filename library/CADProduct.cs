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
            SqlConnection myDb = new SqlConnection(constring);
            using (myDb)
            {
                myDb.Open(); // idk if this has to be done in every method, I think so
            }
        }

        public bool Create(ENProduct product)
        {

            return true;
        }
    }
}
