using System;
using System.Collections.Generic;
using System.Text;

namespace W26Week2IntroToClasses
{
    public class Product
    {
        // fields
        private int id;
        private string _name;
        private double _price;

        // constructors
        public Product()
        {
            id = 0;
            _name = "";
            _price = 0;
        }

        public Product(int id, string name, double price)
        {
            this.id = id;
            _name = name;
            _price = price;
        }


        // getter / setter -> id
        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }


        // property -> _name
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
