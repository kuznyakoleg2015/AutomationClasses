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
        public void DayTime()
        {
            var name = "Oleg";
            var coffee = "Starbucks";
            var movie = "Marvel";
            var time = DateTime.Now.ToString();
            string message = $"Good Afternoon, {name}! Let's watch {movie}tonight!";
            if (time.Contains("AM"))
            {
                message = $"Good Morning, {name}! Have you had a cup of {coffee} coffe yet?";
            }
            else
            {
                message = $"Good Morning, {name}! Let's watch a movie {coffee} coffe yet?";
            }
                Console.WriteLine(message);
            
        }


        [Test]

        public void DrivingAge()
        {
            int age = new Random().Next(100);
            if (age == 16)
            {
                Console.WriteLine("You can drive, but only with 1 passanger");

            }
            else if (age< 16)
            {
                Console.WriteLine("You can't drive!");

            }
            else
            {
                Console.WriteLine("You can drive alone or with multiple passengers!");

            }
            Console.WriteLine($"Your age was {age}");

        }

        [Test]
        public void Compatison()
        {
            var random = new Random();
            int number = random.Next(9999);
            int number2 = random.Next(100);
           
            if (number ==number2)
            {
                Console.WriteLine($"Numbers {number} and {number2} are equal");
            }
            else 
            {
                Console.WriteLine($"Numbers {number} and {number2} are not equal");
            }
            
            

           
            
            
        }


    }
}







