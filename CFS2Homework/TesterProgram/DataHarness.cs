using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;

namespace TesterProgram
{
    class DataHarness
    {
        static void Main(string[] args)
        {
            ////then test the class you created in TesterProgram by creating objects using both constructors and writing them to the screen. 

            Student s1 = new Student();
            s1.FirstName = "Elizardbreath";
            s1.LastName = "Needs Ham";
            s1.ID = "1234";
            s1.GPA = 3.6f;

            Console.WriteLine($"Student first name: {s1.FirstName}\nStudent last name: {s1.LastName}\nStudent ID: {s1.ID}\nStudent GPA: {s1.GPA}");

            Student s2 = new Student();
            Console.WriteLine(s2);

            Vehicle v1 = new Vehicle();
            v1.Make = "Subaru";
            v1.Model = "Forester";
            v1.Year = 2018;
            v1.Weight = 2000;

            Vehicle v2 = new Vehicle();

            Console.WriteLine($"Car make: {v1.Make}\nCar Model: {v1.Model}\nCar year: {v1.Year}\nCar Weight: {v1.Weight}");
            Console.WriteLine(v2);

            Login l1 = new Login();
            l1.Username = "Eneedham";
            l1.Password = "Password";

            Login l2 = new Login();

            Console.WriteLine($"Username: {l1.Username}\nPassword: {l1.Password}");
            Console.WriteLine(l2);

            ContactInfo c = new ContactInfo();
            c.StreetAddress = "brain broke";
            c.City = "brain brok";
            c.State = "brain bro";
            c.Zip = "brain br";
            c.Phone = "brain b";
            c.Email = "brain ";

            ContactInfo c2 = new ContactInfo();

            Console.WriteLine($"{c.StreetAddress}\n{c.City}\n{c.State}\n{c.Zip }\n{c.Phone}\n{c.Email}");
            Console.WriteLine(c2.StreetAddress); //what is it supposed to look like when I print out the thing I made with the default method???

            Customer cust1 = new Customer();
            cust1.CustomerId = "who cares";
            cust1.FirstName = "Elizardbreath";
            cust1.LastName = "Needsham";
            cust1.ContactInformation = c;

            Console.WriteLine($"{cust1.CustomerId}\n{cust1.FirstName}\n {cust1.LastName}\n{cust1.ContactInformation}"); //here I was making it more difficult than it was - Once I assigned the values to the fields of the customer all I had to do was the linebelow and all the customer info is printed out
            Console.WriteLine(cust1);

            Customer cust2 = new Customer();
            Console.WriteLine(cust2);

            CreditCardAccount a = new CreditCardAccount(13545, cust1, 1000, false, 4);
            Console.WriteLine("\n" + a);

            CreditCardAccount b = new CreditCardAccount();
            Console.WriteLine("\n" + b);

            Book book1 = new Book("Stuff White People Like", "Christian Lander", 211);
            Console.WriteLine(book1);
            Book book2 = new Book();
            book2.Title = "Lord of the Rings";
            //Console.WriteLine(book2);

            List<Book> books = new List<Book>();
            books.Add(book1);
            books.Add(book2);
            //Console.WriteLine(books);

            Library lib1 = new Library(books, "Plaza Branch", " 50000 Holmes st", "KC", "MO", "65454");
            Console.WriteLine(lib1); //it's not writing the books out here.....

            //Library lib2 = new Library();
            //Console.WriteLine(lib2);
            ////TODO get help with why this isn't printing off the empty properties or whatever

            Song song1 = new Song("Billy Joel", "some billy joel song", 546545);
            Console.WriteLine(song1);

            Song song2 = new Song();
            Console.WriteLine(song2);

            Song[] songs = { song1, song2 };
            //foreach (Song song in songs)
            //{
            //    Console.WriteLine(song);
            //}

            Artist artist1 = new Artist(songs, "Billy Joel", "random genre");
            Console.WriteLine(artist1);

            //Artist artist2 = new Artist();
            //Console.WriteLine(artist2); //TODOgetting error messages for the classes that have lists in them as properties - they won't print off if no value is passed to them I just get an error msg on the consol

            MotorHome minnieWinnie = new MotorHome("winnie", "winnie model", 1986, 54654, 5);
            Console.WriteLine(minnieWinnie);

            Truck newTruck = new Truck("Toyota", "Tundra", 1995, 2050, 500);
            Console.WriteLine(newTruck);





        }
    }
}
