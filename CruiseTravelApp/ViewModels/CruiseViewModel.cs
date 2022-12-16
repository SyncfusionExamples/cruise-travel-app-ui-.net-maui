using System;
using System.Collections.ObjectModel;
using CruiseTravelApp.Models;

namespace CruiseTravelApp.ViewModels
{
	public class CruiseViewModel
	{ 
		private ObservableCollection<Cruise> cruiseCollection;
        private ObservableCollection<EuropeCruise> europeCruiseCollection;
        private ObservableCollection<Plan> planCollection;

        public ObservableCollection<Cruise> Cruise
		{
			get { return cruiseCollection; }
			set { cruiseCollection = value; }
		}
         
        public ObservableCollection<EuropeCruise> EuropeCruise
        {
            get { return europeCruiseCollection; }
            set { europeCruiseCollection = value; }
        }

        public ObservableCollection<Plan> Plan
        {
            get { return planCollection; }
            set { planCollection = value; }
        }
        internal void GenerateInfo()
        {
            // American Cruise
            cruiseCollection = new ObservableCollection<Cruise>();
            cruiseCollection.Add(new Cruise { Picture = "cruise1", Name = "Harmony of the Seas", Rate = "4.7/5 Rating", Location = "Los Angeles, USA", StartingFrom = "$8000-$50.000" });
            cruiseCollection.Add(new Cruise { Picture = "cruise2", Name = "Ocean Orion Viking", Rate = "4.7/5 Rating", Location = "Pennsylvania, USA", StartingFrom = "$3000-$20.000" });
            cruiseCollection.Add(new Cruise { Picture = "cruise1", Name = "Harmony of the Seas", Rate = "4.7/5 Rating", Location = "Los Angeles, USA", StartingFrom = "$8000-$50.000" });
            // Europe Cruise
            europeCruiseCollection = new ObservableCollection<EuropeCruise>();
            europeCruiseCollection.Add(new EuropeCruise { Picture = "cruise3", Name = "RMS Titanic", Rate = "4.7/5 Rating", Location = "Southampton, UK", StartingFrom = "$8000-$50.000" });
            europeCruiseCollection.Add(new EuropeCruise { Picture = "cruise4", Name = "Caribbean Skylight", Rate = "4.7/5 Rating", Location = "Pennsylvania, USA", StartingFrom = "$3000-$20.000" });
            europeCruiseCollection.Add(new EuropeCruise { Picture = "cruise3", Name = "RMS Titanic", Rate = "4.7/5 Rating", Location = "Southampton, UK", StartingFrom = "$8000-$50.000" });
            // Plan
            planCollection = new ObservableCollection<Plan>();
            planCollection.Add(new Plan { Name = "Regular", Price = "$8000" });
            planCollection.Add(new Plan { Name = "Standard", Price = "$20000" });
        }
        public CruiseViewModel()
		{
			GenerateInfo();
		}
	}
}

