using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENCategory
    {
        private int _id;
        private string _name;

        public int Id
        { get { return _id; } set { _id = value; } }

        public string Name
        { get { return _name; } set { _name = value; } }

        public ENCategory()
        {
            Id = 0;
            Name = null;
        }

        public ENCategory(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public bool addCategory()
        {
            CADCategory category = new CADCategory();
            if (category.read(this)) return true;
            return false;
        }
    }
}