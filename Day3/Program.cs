using System;
using System.Collections.Generic;
using System.Linq;

namespace Day3
{
    public class Program
    {
        const char NORTH = '^';
        const char SOUTH = 'v';
        const char EAST = '>';
        const char WEST = '<';

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private static List<int> GetNewCoords(List<int> prevCoords, int x, int y)
        {
            List<int> coords = new List<int>();
            coords.Add(prevCoords[0] + x);
            coords.Add(prevCoords[1] + y);
            return coords;
        }

        private static void AddCoords(List<List<int>> visited, List<int> coords)
        {
            if (!visited.Any(c => c.SequenceEqual(coords))) visited.Add(coords);
        }

        private static List<int> Move(bool santa, ref List<int> santaCoords, ref List<int> robotCoords, int x, int y)
        {
            List<int> coords;
            if (santa)
            {
                coords = GetNewCoords(santaCoords, x, y);
                santaCoords = coords;
            }
            else
            {
                coords = GetNewCoords(robotCoords, x, y);
                robotCoords = coords;
            }
            return coords;
        }

        public static int HousesVisited(string directions, bool robotHelper = false)
        {
            var startingCoords = new List<int>();
            startingCoords.Add(0);
            startingCoords.Add(0);
            var visited = new List<List<int>>();
            visited.Add(startingCoords);

            var santaCoords = visited[0];
            var robotCoords = visited[0];

            var santa = true;

            foreach (var direction in directions.ToCharArray())
            {
                switch (direction)
                {
                    case NORTH:
                        List<int> coords1 = Move(santa, ref santaCoords, ref robotCoords, 0, 1);
                        if (!visited.Any(c => c.SequenceEqual(coords1))) visited.Add(coords1);
                        break;
                    case SOUTH:
                        List<int> coords2 = Move(santa, ref santaCoords, ref robotCoords, 0, -1);
                        if (!visited.Any(c => c.SequenceEqual(coords2))) visited.Add(coords2);
                        break;
                    case EAST:
                        List<int> coords3 = Move(santa, ref santaCoords, ref robotCoords, 1, 0);
                        if (!visited.Any(c => c.SequenceEqual(coords3))) visited.Add(coords3);
                        break;
                    case WEST:
                        List<int> coords4 = Move(santa, ref santaCoords, ref robotCoords, -1, 0);
                        if (!visited.Any(c => c.SequenceEqual(coords4))) visited.Add(coords4);
                        break;
                    default:
                        throw new Exception("Not a valid direction!");
                        break;
                }

                if (robotHelper) santa = !santa;
            }

            return visited.Count;
        }
    }
}
