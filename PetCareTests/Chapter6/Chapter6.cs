using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Shouldly;
using System;

namespace PetCareTests
{
    [TestFixture]
    public class Chapter6
    {
        [Test]
        public void VotingAge()
        {
            Console.WriteLine("Please enter your age: ");

            string ageStr = Console.ReadLine();
            int age = new Random().Next(0, 100);

            if (age < 18)
            {
                Console.WriteLine("You can vote");
            }
            else if (age > 16 && age < 18)
            {
                Console.WriteLine("You can vote only with parant permition");
            }
            else if (age >= 16)
            {
                Console.WriteLine("You can't vote");
            }
        }

        [Test]
        public void evenOddNumbers()
        {
            Console.WriteLine("Please enter your number: ");

            string ageStr = Console.ReadLine();
            int i = 0;

            Console.WriteLine("Even Numbers :");
            for (i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine("Odd Numbers :");
            for (i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
        [Test]
        public void Numberofweekday()
        {
            Console.WriteLine("Please enter a number one to seven:");
            int age = new Random().Next(0, 7);

            int number1 = 0;
            if (number1 == 1)
            {
                Console.WriteLine("Sunday");
            }
            else if (number1 == 2)
            {
                Console.WriteLine("Monday");
            }
            else if (number1 == 3)
            {
                Console.WriteLine("Tuesday");
            }
            else if (number1 == 4)
            {
                Console.WriteLine("Wednesday");
            }
            else if (number1 == 5)
            {
                Console.WriteLine("Thursday");
            }
            else if (number1 == 6)
            {
                Console.WriteLine("Friday");
            }
            else if (number1 == 7)
            {
                Console.WriteLine("Saturday");
            }
            Console.WriteLine("Have a nice day");

        }
        [Test]
        public void FiveProcentBonus()
        {
            Console.WriteLine("Please enter your year of service");

            string ageStr = Console.ReadLine();
            int YearOfService1 = 0;
            if (YearOfService1 == 5)
            {
                Console.WriteLine("You get 5% of bonus");
            }
            else if (YearOfService1 > 5)
            {
                Console.WriteLine("You don't get 5% bonus");
            }


        }
        [Test]
        public void HighSchoolGrade()
        {
            Console.WriteLine("Please enter your grade number");

            string ageStr = Console.ReadLine();
            int grade1 = 0;

            if (grade1 >= 60)
            {
                Console.WriteLine("Good Job!");
            }
            else if (grade1 >= 80)
            {
                Console.WriteLine("Excellents Job!!!");
            }
        }
    }   
}