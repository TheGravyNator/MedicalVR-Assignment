using System;
using System.Collections.Generic;
using System.Linq;

namespace MedicalVR_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            // Part 1: Fill a List<int> with the prime numbers under 100, from highest to lowest.
            List<int> primeList = p.Reverse(Enumerable.Range(1, 100)).Where(x => p.isPrime(x)).ToList();

            // Part 2: Remove all even numbers from that list.
            primeList = primeList.Where(x => x % 2 != 0).ToList();
            // Footnote: I used the modulus operator here to show I understand how this filtering for even numbers works. However, I do realize
            // that removing even numbers from a list of prime numbers under 100 will only remove 1 number, since 2 is the only even prime number in that range.

            // Part 4: Demonstrate how to use a nullable value type.
            Person personOne = new Person()
            {
                Name = "Jan Dijkers",
                Age = 32
            };
            Person personTwo = new Person()
            {
                Name = "Henk van Dijk"
            };

            p.PrintName(personOne);
            p.PrintName(personTwo);

        }

        // Part 1 cont.
        private bool isPrime(int input)
        {
            int divisors = 0;
            for (int i = 1; i <= input; i++)
            {
                if (input % i == 0)
                {
                    divisors++;
                }
            }
            return (divisors == 2);
        }

        // Part 3: Implement List<>.Reverse()
        private IEnumerable<int> Reverse(IEnumerable<int> input)
        {
            int inputCount = input.Count();
            int[] response = new int[inputCount];

            for (int i = 0; i < inputCount; i++)
            {
                response[i] = input.ToArray()[(inputCount - i) - 1];
            }

            return new List<int>(response);
        }

        // Part 4 cont.
        private void PrintName(Person person)
        {
            Console.WriteLine($"Name: {person.Name}");
            Console.WriteLine($"Age: {(person.Age.HasValue ? person.Age.Value.ToString() : "Age Unknown")}");
            Console.WriteLine("");
        }

        class Person
        {
            public string Name { get; set; }
            public int? Age { get; set; }
        }
    }
}
