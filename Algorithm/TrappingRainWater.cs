using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    public class TrappingRainWater
    {
        public TrappingRainWater()
        {
            Console.WriteLine(this.StackTrap(new int[]{
                0,1,0,2,1,0,1,3,2,1,2,1
            }));
        }
        public int StackTrap(int[] height)
        {
            int max = 0;
            Stack<int> level = new Stack<int>();
            int current = 0;

            while(current < height.Length)
            {
                while(level.Count > 0 && height[current] > height[level.Peek()])
                {
                    int top = level.Peek();
                    level.Pop();
                    if (level.Count == 0)
                        break;
                    int distance = current - level.Peek() - 1;
                    int boundd = Math.Max(height[current], height[level.Peek()]) - height[top];
                    max = max + distance * boundd;
                }
                level.Push(current++);
            }

            return max;

        }
            public int Trap(int[] height)
        {
            int max = 0;

            for (int i = 0; i < height.Length; i++)
            {
                int left_max = 0;
                int right_max = 0;

                for (int j = 0; j < height.Length; j++)
                {
                    if (i <= j)
                        left_max = Math.Max(left_max, height[j]);
                    if (i >= j)
                        right_max = Math.Max(right_max, height[j]);
                }

                max = max + Math.Min(left_max, right_max) - height[i];
            }
            return (max);
        }
    }
}
