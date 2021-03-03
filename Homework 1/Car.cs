using System;
using System.Collections.Generic;
using System.Text;

namespace City
{
    class Car
    {
        public string brand;
        public string type;
        public string color;
        public int number;

        public Car(string aBrand, string aType, string aColor, int aNumber)
        {
            brand = aBrand;
            type = aType;
            color = aColor;
            number = aNumber;
        }

        public string AutoNumber()
        {
            if (number >= 67)
            {
                return "That's a good car.";
            }
            return "Not so much of a good car.";
        }

    }
}
