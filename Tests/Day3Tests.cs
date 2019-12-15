using NUnit.Framework;
using System;
using System.IO;
using System.Reflection;
using Day3;

namespace Tests
{
    public class Day3Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Example1()
        {
            var input = ">";
            var result = Program.HousesVisited(input);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Example2()
        {
            var input = "^>v<";
            var result = Program.HousesVisited(input);
            Assert.AreEqual(4, result);
        }

        [Test]
        public void Example3()
        {
            var input = "^v^v^v^v^v";
            var result = Program.HousesVisited(input);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Puzzle1()
        {
            var input = File.ReadAllText(@"/Users/jake/Source/GitHub/advent-of-code-2015/Tests/TestData/Day3Input.txt");
            var result = Program.HousesVisited(input);
            Assert.AreEqual(2, result);
        }
    }
}