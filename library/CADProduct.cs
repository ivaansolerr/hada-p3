using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace library
{
    public class CADProduct
    {
        private string constring = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;
        public string _constring
        {
            get { return constring; }
        }
        public CADProduct()
        {
            
        }
    }
}
