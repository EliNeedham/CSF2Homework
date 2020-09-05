using System;
using System.Collections.Generic;
using System.Text;



namespace ClassesLibrary
{
    public class MotorHome : Vehicle
    {

        private int _numberOfBeds;

        public int NumberOfBeds { get; set; }

        public MotorHome(string make, string model, int year, float weight, int numberOfBeds) : base(make, model, year, weight)
        {
            NumberOfBeds = numberOfBeds;
        }

        public MotorHome() { }

        public override string ToString()
        {
            return base.ToString() + "\nNumber of Beds: " + NumberOfBeds;
        }


    }//end class
}//end Namespace
