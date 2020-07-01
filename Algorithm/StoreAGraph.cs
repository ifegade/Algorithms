using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class StoreAGraph
    {
        int[,] edgeList = new int[,]
        {
            { 0, 2 }, {1, 3 }, {2, 3 }, {2, 4 }, {3, 5 }, {4, 5 }
        };

        public StoreAGraph()
        {
        }

        public void AdjacentMatrics()
        {
            Console.WriteLine(" \t 0 \t 1 \t 2 \t 3 \t 4 \t 5 \t 6 \t 7 \t");
            for (int i = 0; i < edgeList.Length; i++)
            {
                Console.Write($"{i} \t");
                for (int j = 0; j < edgeList.Length; j++)
                {
                    if (j < edgeList.GetLength(1))
                    {
                        Console.Write(" 1 \t");
                    }
                    else
                    {
                        Console.Write(" 0 \t");
                    }
                    // Console.Write($"{edgeList[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public void AdjacentList()
        {

        }
    }
}
