using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNameGenerator {
    class Program
    {
        public const int KeySize = 16;
        public const int SaltSize = 16;
        public const int Iterations = 10000;
        static void Main(string[] args)
        {
            MakePeople mypeople = new MakePeople();
            Console.WriteLine("This application will generate a random name, and a username and password for that person");

            while( true ) {
                Console.WriteLine("Select your gender by pressing the 'm' or 'f' key. You can select a random gender by pressing any other key");
                ConsoleKeyInfo selectGender = Console.ReadKey();
                Console.WriteLine();
                Gender userGender = Gender.Neutral;
                if( selectGender.Key == ConsoleKey.M ) {
                    userGender = Gender.Male;
                }
                else if( selectGender.Key == ConsoleKey.F ) {
                    userGender = Gender.Female;
                }

                Person person = mypeople.GetRandomPerson(userGender);
                person.SetLoginInfo();
                Console.WriteLine("Name: " + person.Name);
                Console.WriteLine("Gender: " + person.Sex);
                Console.WriteLine("Username: " + person.UserInfo.Username);
                Console.WriteLine("Password: " + person.UserInfo.Password);

                Console.WriteLine("Press the 'Enter' key to create another person");
                ConsoleKeyInfo newPerson = Console.ReadKey();

                if( newPerson.Key == ConsoleKey.Enter ) {
                    continue;
                }
                break;
            }
        }
    }
}
