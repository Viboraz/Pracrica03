using System;

namespace Practica03    
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello to CSharp Classes and Objects!");

            var tony = new Person("Tony", 24);
            var john = new Person("John", 42);
            var elsa = new Person("Elsa", 26);

            tony.printPerson();
            john.printPerson();
            elsa.printPerson();


            Console.WriteLine("Exemple becomeOlder");
            elsa.becomeOlder();
            elsa.printPerson();

            john.becomeOlder();


            for (int i = 0; i <= 10; i = i + 1)
            {
                Console.WriteLine("Exemple becomeOlder inside for, " + i + " : tony is becoming older one year");
                tony.becomeOlder();
            }
            tony.printPerson();

            Person[] people = { tony, john, elsa };

            Console.WriteLine("Exemple foreach");
            foreach (Person p in people)
            {

                p.printPerson();
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
