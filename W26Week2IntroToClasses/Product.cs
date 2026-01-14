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
            set
            {
                if (!string.IsNullOrEmpty(value))
                   _name = value; 
            }
        }

        // expression-bodied property -> _price
        public double Price
        {
            get => _price;
            set => _price = value;
        }

        // auto-implemented property -> Quantity
        // there is no private field for quantity
        public int Quantity { get; set; }


        // keyboard shortcuts -> properties

        // propfull + tab
        private int _num;

        public int Num
        {
            get { return _num; }
            set { _num = value; }
        }

        // prop + tab
        public int MyProperty { get; set; }

        // propg + tab
        public int MyProperty1 { get; private set; }
    }
}
