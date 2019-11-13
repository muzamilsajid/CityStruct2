using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityStruct
{
    struct Person
    {
        private string firstname;
        public string FirstName
        {
            get { return firstname; }
        }

        private string lastname;
        public string LastName
        {
            get { return lastname; }
        }

        private int age;
        public int Age
        {
            get { return age; }
        }

        public City CityLocated;

        public void CreateNewPerson(string fName,string lName)
        {
            firstname = fName;
            lastname = lName;
            age = new Random().Next(17, 35);
            CityLocated = new City();
        }
    }
}
