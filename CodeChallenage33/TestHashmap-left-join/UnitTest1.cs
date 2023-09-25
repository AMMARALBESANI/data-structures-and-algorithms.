using System;
using System.Collections.Generic;
using Xunit;
using CodeChallenage33; // Make sure to reference the CodeChallenage33 namespace

namespace TestHashmap_left_join
{
    public class LeftJoinTests
    {
        [Fact]
        public void LeftJoin_WithNonEmptyDictionaries_ReturnsCorrectResult()
        {
            // Arrange
            Dictionary<string, string> synonyms = new Dictionary<string, string>
            {
                { "diligent", "employed" },
                { "fond", "enamored" },
                { "guide", "usher" },
                { "outfit", "garb" },
                { "wrath", "anger" }
            };

            Dictionary<string, string> antonyms = new Dictionary<string, string>
            {
                { "diligent", "idle" },
                { "fond", "averse" },
                { "guide", "follow" },
                { "flow", "jam" },
                { "wrath", "delight" }
            };

            List<List<string>> expected = new List<List<string>>
            {
                new List<string> { "diligent", "employed", "idle" },
                new List<string> { "fond", "enamored", "averse" },
                new List<string> { "guide", "usher", "follow" },
                new List<string> { "outfit", "garb", null },
                new List<string> { "wrath", "anger", "delight" }
            };

            // Act
            List<List<string>> result = Program.LeftJoin(synonyms, antonyms);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void LeftJoin_WithEmptyDictionaries_ReturnsEmptyResult()
        {
            // Arrange
            Dictionary<string, string> synonyms = new Dictionary<string, string>();
            Dictionary<string, string> antonyms = new Dictionary<string, string>();

            // Act
            List<List<string>> result = Program.LeftJoin(synonyms, antonyms);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void LeftJoin_WithMismatchedKeys_ReturnsCorrectResult()
        {
            // Arrange
            Dictionary<string, string> synonyms = new Dictionary<string, string>
            {
                { "apple", "fruit" },
                { "banana", "fruit" },
                { "carrot", "vegetable" },
            };

            Dictionary<string, string> antonyms = new Dictionary<string, string>
            {
                { "banana", "yellow" },
                { "carrot", "orange" },
            };

            List<List<string>> expected = new List<List<string>>
            {
                new List<string> { "apple", "fruit", null },
                new List<string> { "banana", "fruit", "yellow" },
                new List<string> { "carrot", "vegetable", "orange" },
            };

            // Act
            List<List<string>> result = Program.LeftJoin(synonyms, antonyms);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
