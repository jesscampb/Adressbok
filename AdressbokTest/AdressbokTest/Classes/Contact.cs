using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressbokTest.Classes
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Contact(string firstName, string lastName, string street,
                            string postalCode, string city, string phone, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Street = street;
            PostalCode = postalCode;
            City = city;
            Phone = phone;
            Email = email;
        }

        //Skickar in värden till metoden WriteToFile() i FileHandler-klassen för att spara
        //en ny kontakt i textfilen
        public void Save()
        {
            FileHandler fileHandler = new FileHandler(@"C:\Users\jessc\Desktop\Inlämningsuppgift 1\Adressbok.txt");
            string text = $"{FirstName}, {LastName}, {Street}, {PostalCode}, {City}, {Phone}, {Email}";
            fileHandler.WriteToFile(text);

        }

        
    }
}
