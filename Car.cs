using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpMasterclass
{
    internal class Car
    {
        // member variable
        // private hides the variable from other Classes
        private string _model = "";

        // Property
        public string Model
        {
            get
            {
                if (IsLuxury)
                {
                    return _model + " - Luxury Edition";
                }
                else
                {
                    return _model;
                }
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    System.Console.WriteLine("You entered Nothing");
                    _model = "DEFAULTVALUE";
                }
                else
                {
                    _model = value;
                }
            }
        }

        public bool IsLuxury { get; set; }

        //Constructor
        public Car(string model, bool isLuxury)
        {
            Model = model;
            IsLuxury = isLuxury;
        }

    }
}