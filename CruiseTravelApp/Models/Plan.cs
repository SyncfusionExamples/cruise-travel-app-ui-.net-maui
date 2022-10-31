using System;
namespace CruiseTravelApp.Models
{
    public class Plan
    {
        private string name;
        private string price;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}

