using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesLibrary
{
    public class Truck : Vehicle
    {
        //fields

        //property
        public float LoadCapacityLbs { get; set; }

        //ctor
        public Truck(string make, string model, int year, float weight, float loadCapacityLbs) : base(make, model, year, weight)
        {
            LoadCapacityLbs = loadCapacityLbs;
        }

        public Truck() { }

        public override string ToString()
        {
            return base.ToString() + "\nLoad Capacity: " + LoadCapacityLbs;
        }


    }//end class
}//end namespace
