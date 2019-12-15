using NUnit.Framework;
using System;
using System.IO;
using System.Reflection;
using Day2;

namespace Tests
{
    public class Day2Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Example1()
        {
            var input = "2x3x4";
            var calc = new WrappingPaperCalculator();
            var result = calc.CalculateWrappingPaperRequired(input);
            Assert.AreEqual(58, result);
        }

        [Test]
        public void Example2()
        {
            var input = "1x1x10";
            var calc = new WrappingPaperCalculator();
            var result = calc.CalculateWrappingPaperRequired(input);
            Assert.AreEqual(43, result);
        }

        [Test]
        public void Puzzle1()
        {
            var input = File.ReadAllText(@"/Users/jake/Source/GitHub/advent-of-code-2015/Tests/Day2Input.txt");
            var calc = new WrappingPaperCalculator();
            var result = calc.CalculateWrappingPaperRequired(input);
            Assert.AreEqual(1588178, result);
        }

        [Test]
        public void Example3()
        {
            var input = "2x3x4";
            var calc = new WrappingPaperCalculator();
            var result = calc.CalculateRibbonRequired(input);
            Assert.AreEqual(34, result);
        }

        [Test]
        public void Example4()
        {
            var input = "1x1x10";
            var calc = new WrappingPaperCalculator();
            var result = calc.CalculateRibbonRequired(input);
            Assert.AreEqual(14, result);
        }

        [Test]
        public void Puzzle2()
        {
            var input = File.ReadAllText(@"/Users/jake/Source/GitHub/advent-of-code-2015/Tests/Day2Input.txt");
            var calc = new WrappingPaperCalculator();
            var result = calc.CalculateRibbonRequired(input);
            Assert.AreEqual(3783758, result);
        }
    }
}