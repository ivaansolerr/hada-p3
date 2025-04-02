using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENProduct
    {

        private string _code;
        private string _name;
        private int _amount;
        private float _price;
        private int _category;
        private DateTime _creationDate;

        public string Code
        { get { return _code; } set { _code = value; } }
        public string Name
        { get { return _name; } set { _name = value; } }
        public int Amount
        { get { return _amount; } set { _amount = value; } }
        public float Price
        { get { return _price; } set { _price = value; } }
        public int Category
        { get { return _category; } set { _category = value; } }
        public DateTime CreationDate
        { get { return _creationDate; } set { _creationDate = value; } }

        public ENProduct()
        {
            Code = string.Empty;
            Name = string.Empty;
            Amount = 0;
            Price = 0;
            Category = -1;
            CreationDate = DateTime.MinValue;
        }

        public ENProduct(string code, string name, int amount, float price, int category, DateTime creationDate)
        {
            Code = code;
            Name = name;
            Amount = amount;
            Price = price;
            Category = category;
            CreationDate = creationDate;
        }

        public bool Create()
        {
            CADProduct ca = new CADProduct();
            if (ca.Create(this)) return true;
            return false;
        }

        public bool Update()
        {
            CADProduct ca = new CADProduct();
            if (ca.Update(this)) return true;
            return false;
        }

        public bool Delete()
        {
            CADProduct ca = new CADProduct();
            if (ca.Delete(this)) return true;
            return false;
        }

        public bool Read()
        {
            CADProduct ca = new CADProduct();
            if (ca.Read(this)) return true;
            return false;
        }

        public bool ReadFirst()
        {
            CADProduct ca = new CADProduct();
            if (ca.ReadFirst(this)) return true;
            return false;
        }

        public bool ReadNext()
        {
            CADProduct ca = new CADProduct();
            if (ca.ReadNext(this)) return true;
            return false;
        }

        public bool ReadPrev()
        {
            CADProduct ca = new CADProduct();
            if (ca.ReadPrev(this)) return true;
            return false;
        }
    }
}
