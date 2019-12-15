using NUnit.Framework;
using System;
using System.IO;
using System.Reflection;
using Day1;

namespace Tests
{
    public class Day1Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Example1()
        {
            var input1 = "(())";

            var input2 = "()()";
            var result1 = Program.MoveFloors(input1);
            var result2 = Program.MoveFloors(input2);
            Assert.AreEqual(result1, 0);
            Assert.AreEqual(result2, 0);
        }

        [Test]
        public void Example2()
        {
            var input1 = "(((";
            var input2 = "(()(()(";
            var result1 = Program.MoveFloors(input1);
            var result2 = Program.MoveFloors(input2);
            Assert.AreEqual(result1, 3);
            Assert.AreEqual(result2, 3);
        }

        [Test]
        public void Example3()
        {
            var input = "))(((((";
            var result = Program.MoveFloors(input);
            Assert.AreEqual(result, 3);
        }

        [Test]
        public void Example4()
        {
            var input1 = "())";
            var input2 = "))(";
            var result1 = Program.MoveFloors(input1);
            var result2 = Program.MoveFloors(input2);
            Assert.AreEqual(result1, -1);
            Assert.AreEqual(result2, -1);
        }

        [Test]
        public void Example5()
        {
            var input1 = ")))";
            var input2 = ")())())";
            var result1 = Program.MoveFloors(input1);
            var result2 = Program.MoveFloors(input2);
            Assert.AreEqual(result1, -3);
            Assert.AreEqual(result2, -3);
        }

        [Test]
        public void Puzzle1()
        {
            var input = File.ReadAllText(@"/Users/jake/Source/GitHub/advent-of-code-2015/Tests/Day1Input.txt");
            var result = Program.MoveFloors(input);
            Assert.AreEqual(232, result);
        }

        [Test]
        public void Puzzle2()
        {
            var input = File.ReadAllText(@"/Users/jake/Source/GitHub/advent-of-code-2015/Tests/Day1Input.txt");
            var result = Program.MoveFloorsUntilBasement(input);
            Assert.AreEqual(1783, result);
        }
    }
}