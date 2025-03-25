using System;
using System.Collections.Generic;
using System.Linq;
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
        private DateTime _creationDate;

        public string Code
            { get { return _code; } set { _code = value; } }
        public string Name
            { get { return _name; } set {_name = value; } }
        public int Amount
            { get { return _amount; } set { _amount = value; } }
        public float Price
            { get { return _price; } set { _price = value; } }
        public DateTime CreationDate
            { get { return _creationDate; } set { _creationDate = value; } }

        public ENProduct()
        {
            Code = string.Empty;
            Name = string.Empty;
            Amount = 0;
            Price = 0;
            CreationDate = DateTime.MinValue;
        }

        public ENProduct(string code, string name, int amount, float price, DateTime creationDate)
        {
            Code = code;
            Name = name;
            Amount = amount;
            Price = price;
            CreationDate = creationDate;
            Code = code;
            Name = name;
            Amount = amount;
            Price = price;
            CreationDate = creationDate;
        }

        public bool Create()
        {
            if (CADProduct.Create(this)) return true;
            return false;
        }

        public bool Update()
        {
            if (CADProduct.Update(this)) return true;
            return false;
        }

        public bool Delete()
        {
            if (CADProduct.Delete(this)) return true;
            return false;
        }

        public bool Read()
        {
            if (CADProduct.Read(this)) return true;
            return false;
        }

        public bool ReadFirst()
        {
            if (CADProduct.ReadFirst(this)) return true;
            return false;
        }

        public bool ReadNext()
        {
            if (CADProduct.ReadNext(this)) return true;
            return false;
        }

        public bool ReadPrev()
        {
            if (CADProduct.ReadPrev(this)) return true;
            return false;
        }
    }
}
