

using System.Net.Sockets;

namespace BankAccount
{
    public class Person
    {
        //attributes|Properties|Data Points that we want to store for our objects

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }

        //Constructors - build the object

        //Default Constructor
        public Person()
        {
            FirstName = "No Name Given";
            LastName = "No Name Given";
            DOB = DateTime.Now;
        }

        //Parameterized Constructor
        public Person(string firstName, string lastName, int month, int day, int year)
        {
            FirstName = firstName;
            LastName = lastName;

            DOB = new DateTime(year, month, day);

        }

        public Person(string firstName, string lastName, string dob)
        {
            FirstName = firstName;
            LastName = lastName;

            string[] dobSplit = dob.Split('-');

            DOB = new DateTime(Int32.Parse(dobSplit[2]), Int32.Parse(dobSplit[0]), Int32.Parse(dobSplit[1]));

        }

    }
}
