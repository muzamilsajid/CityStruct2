using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityStruct
{
    public partial class Form1 : Form
    {
        List<City> myListOfCities = new List<City>();
        List<Person> myListOfPersons = new List<Person>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            City newCity = new City();

            newCity.CreateNewCity(txtCityName.Text);

            myListOfCities.Add(newCity);

            listBoxCities.Items.Clear();

            foreach (City mycities in myListOfCities)
            {
                listBoxCities.Items.Add(mycities.Name);
            }

            cmbCities.Items.Clear();

            foreach (City mycities in myListOfCities)
            {
                cmbCities.Items.Add(mycities.Name);
            }
        }

        private void cmdChangeCityName_Click(object sender, EventArgs e)
        {
            foreach (City myCities in myListOfCities)
            {
                if(myCities.Name == txtCityName.Text)
                {
                    myListOfCities.Remove(myCities);
                    myCities.ChangeCityName(txtChangeCityName.Text);
                    myListOfCities.Add(myCities);
                    break;
                }
            }

            listBoxCities.Items.Clear();

            foreach (City mycities in myListOfCities)
            {
                listBoxCities.Items.Add(mycities.Name);
            }

            cmbCities.Items.Clear();

            foreach (City mycities in myListOfCities)
            {
                cmbCities.Items.Add(mycities.Name);
            }
        }

        private void listBoxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxCityDetails.Items.Clear();

            foreach (City cities in myListOfCities)
            {
                if (cities.Name == listBoxCities.Text)
                {
                    listBoxCityDetails.Items.Add($"{cities.Name} | {cities.Population} | {cities.Area}");
                    foreach (Person person in cities.ListOfPersons)
                    {
                        listBoxCityDetails.Items.Add(person.FirstName);
                    }
                }
            }
        }

        private void btnIncPop_Click(object sender, EventArgs e)
        {
            foreach (City myCities in myListOfCities)
            {
                if (myCities.Name == txtCityName.Text)
                {
                    myListOfCities.Remove(myCities);
                    myCities.IncreasePopulation(10);
                    myListOfCities.Add(myCities);
                    break;
                }
            }

            listBoxCities.Items.Clear();

            foreach (City mycities in myListOfCities)
            {
                listBoxCities.Items.Add(mycities.Name);
            }
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            Person newPerson = new Person();


            newPerson.CreateNewPerson(txtFirstName.Text, txtLastName.Text);
            myListOfPersons.Add(newPerson);

            listBoxPersons.Items.Add(newPerson.FirstName);

            foreach (City cities in myListOfCities)
            {
                if (cities.Name == cmbCities.Text)
                {

                    cities.ListOfPersons.Add(newPerson);
                }
            }
        }
    }
}
