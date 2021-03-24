using AnagramsAssignment.Services;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Anagrams.Test.Services
{
    public class AnagramServiceTests
    {
        /// <summary>
        /// True is Silent Returns Silent and Listen from the List
        /// </summary>
        [Fact]
        public void AnagramTest_ReturnsTwoValuesInList()
        {
            // Arrange
            string input = "race";
            List<string> expected = new List<string>() { "care", "race" };
            // Act
            AnagramService anagramService = new AnagramService();
            List<string> result = anagramService.GetAnagrams(input);

            // Assert
            Assert.Equal(expected, result);
        }

        /// <summary>
        /// Returns Only Account as no other anagram for that.
        /// </summary>
        [Fact]
        public void AnagramTest_ReturnsSingleValuesInList()
        {
            // Arrange
            string input = "account";
            List<string> expected = new List<string>() { "account" };
            // Act
            AnagramService anagramService = new AnagramService();
            List<string> result = anagramService.GetAnagrams(input);

            // Assert
            Assert.Equal(expected, result);
        }

        /// <summary>
        /// Parth is not part of dictionary so result will be empty.
        /// </summary>
        [Fact]
        public void AnagramTest_ReturnsNoData()
        {
            // Arrange
            string input = "parth";
            
            // Act
            AnagramService anagramService = new AnagramService();
            List<string> result = anagramService.GetAnagrams(input);

            // Assert
            Assert.Empty(result);
        }
    }
}
