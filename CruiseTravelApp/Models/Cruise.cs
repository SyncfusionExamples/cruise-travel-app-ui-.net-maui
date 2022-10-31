using System;
namespace CruiseTravelApp.Models
{
    public class Cruise
    {
        private string picture;
        private string name;
        private string rate;
        private string location;
        private string startingfrom;

        public string Picture
        {
            get { return picture; }
            set { picture = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public string StartingFrom
        {
            get { return startingfrom; }
            set { startingfrom = value; }
        }
    }
}

