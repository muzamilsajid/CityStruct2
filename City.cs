using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityStruct
{
    struct City
    {
        public List<Person> ListOfPersons;

        private string name;
        public string Name
        {
            get { return name; }
        }

        private int population;
        public int Population
        {
            get { return population; }
        }

        private float area;
        public float Area
        {
            get { return area; }
        }

        public void CreateNewCity(string cName)
        {
            name = cName;
            population = 2;
            area = new Random().Next(10000,1000000);
            ListOfPersons = new List<Person>();
        }

        public void ChangeCityName(string cName)
        {
            name = cName;
        }

        public void IncreasePopulation(int cPop)
        {
            population += cPop;
        }
    }
}
