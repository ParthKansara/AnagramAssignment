using AnagramsAssignment.Services;
using AnagramsAssignment.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace AnagramsAssignment
{
    class Program
    {
        /// <summary>
        /// Dependency Injection, Logger Setup and Anagram Service is called from this Main Method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Setup Dependancy Injection
            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .AddSingleton<IAnagramService, AnagramService>()
                .BuildServiceProvider();

            // Create Logger
            var logger = serviceProvider.GetService<ILoggerFactory>()
                .CreateLogger<Program>();

            logger.LogDebug("Starting application");

            // Take Input from the User
            Console.Write("Please Enter a word to find related Anagrams: ");

            string userInput;
            userInput = Console.ReadLine();

            Console.WriteLine("You have entered word: " + userInput);

            logger.LogDebug("User have Entered" + userInput);

            Console.Write("\n----------------------\n");
            Console.WriteLine("Below are list of words those are Anagrams to the " + userInput);

            // Get Anagrams
            var anagram = serviceProvider.GetService<IAnagramService>();
            
            var list = anagram.GetAnagrams(userInput);
            // Write Each Result in a New Line
            list.ForEach(Console.WriteLine);

            Console.Write("\n----------------------\n");
        }
    }
}
