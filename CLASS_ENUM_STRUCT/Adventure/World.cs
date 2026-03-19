using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Adventure.Player;

namespace Adventure
{
    public class World
    {
        public int[,] Map { get; set; }
        public string WorldName { get; set; }

        public Point2D StartingPoint { get; set; }

        public Point2D Goal { get; set; }

        // 2 -  Tee World klass, koos nelja andmeväljaga
        //      World klassis on üks konstruktor, kus kasutatakse kõiki andmeid
        //      andmeväljad on: int[,] Map, string WorldName, Point2D Start, Point2D Goal


        public World(int[,] thisMap, string thisWorldName, Point2D start, Point2D end)
        {
            Map = thisMap;
            WorldName = thisWorldName;
            StartingPoint = start;
            Goal = end;
        }

        public World(string thisWorldName, Point2D start, Point2D end)
        {
            Map = NewMap(10, 6);
            WorldName = thisWorldName;
            StartingPoint = start;
            Goal = end;
        }

        private int[,] NewMap(int size, int maxEventInteger)
        {
            int[,] newmap = new int[size, size];
            Random rng = new Random();
            for (int i = 0; i<size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    newmap[i, j] = rng.Next(1, maxEventInteger + 1);
                }
            }
            return newmap;
        }
    }
}
