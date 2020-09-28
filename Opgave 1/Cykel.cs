using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave_1
{
    public class Cykel
    {
        private int _id;
        private string _color;
        private double _price;
        private int _gear;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Color
        {
            get { return _color; }
            set {if (value.Length<1) throw new ArgumentException(); 
                _color = value; }
        }


        public double Price
        {
            get { return _price; }
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException(); 
                _price = value; }
        }



        public int Gear
        {
            get { return _gear; }
            set { if(value<3 || value >32) throw new ArgumentOutOfRangeException();
                _gear = value; }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
