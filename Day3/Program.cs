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

        public static int HousesVisited(string directions)
        {
            var startingCoords = new List<int>();
            startingCoords.Add(0);
            startingCoords.Add(0);
            var visited = new List<List<int>>();
            visited.Add(startingCoords);

            var prevCoords = visited[0];

            foreach (var direction in directions.ToCharArray())
            {
                switch (direction)
                {
                    case NORTH:
                        var coords1 = GetNewCoords(prevCoords, 0, 1);
                        prevCoords = coords1;
                        if (!visited.Any(c => c.SequenceEqual(coords1))) visited.Add(coords1);
                        break;
                    case SOUTH:
                        var coords2 = GetNewCoords(prevCoords, 0, -1);
                        prevCoords = coords2;
                        if (!visited.Any(c => c.SequenceEqual(coords2))) visited.Add(coords2);
                        break;
                    case EAST:
                        var coords3 = GetNewCoords(prevCoords, 1, 0);
                        prevCoords = coords3;
                        if (!visited.Any(c => c.SequenceEqual(coords3))) visited.Add(coords3);
                        break;
                    case WEST:
                        var coords4 = GetNewCoords(prevCoords, -1, 0);
                        prevCoords = coords4;
                        if (!visited.Any(c => c.SequenceEqual(coords4))) visited.Add(coords4);
                        break;
                    default:
                        throw new Exception("Not a valid direction!");
                        break;
                }
            }

            return visited.Count;
        }
    }
}
