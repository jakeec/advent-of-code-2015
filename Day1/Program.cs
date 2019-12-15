using System;

namespace Day1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int MoveFloors(string input)
        {
            var directions = input.ToCharArray();
            int floor = 0;
            foreach (var direction in directions)
            {
                if (direction.Equals('(')) floor++;
                if (direction.Equals(')')) floor--;
            }
            return floor;
        }

        public static int MoveFloorsUntilBasement(string input)
        {
            var directions = input.ToCharArray();
            int floor = 0;
            var i = 0;
            for (; i < directions.Length; i++)
            {
                if (floor == -1) break;
                if (directions[i].Equals('(')) floor++;
                if (directions[i].Equals(')')) floor--;
            }
            return i;
        }
    }
}
