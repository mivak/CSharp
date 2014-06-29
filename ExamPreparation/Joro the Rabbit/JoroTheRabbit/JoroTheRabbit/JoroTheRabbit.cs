namespace JoroTheRabbit
{
    using System;

    public class JoroTheRabbit
    {
        private static int[] terrain;

        public static void Main()
        {
            string input = Console.ReadLine();
            string[] digits = input.Split(',');

            for (int i = 0; i < digits.Length; i++)
            {
                digits[i] = digits[i].Trim();
            }
            
            terrain = new int[digits.Length];
            for (int i = 0; i < digits.Length; i++)
            {
                terrain[i] = int.Parse(digits[i]);
            }

            int maxNumberOfSteps = 0;
            for (int numberInField = 0; numberInField < terrain.Length; numberInField++)
            {
                int numberOfSteps = 0;

                for (int stepSize = 1; stepSize <= terrain.Length; stepSize++)
                {
                    numberOfSteps = GetNumberOfSteps(numberInField, stepSize);
                    if (numberOfSteps > maxNumberOfSteps)
                    {
                        maxNumberOfSteps = numberOfSteps;
                    }
                }
            }

            Console.WriteLine(maxNumberOfSteps);
        }

        private static int GetNumberOfSteps(int start, int step)
        {    
            int numberOfSteps = 1;
            int index = start;
            for (int i = 0; i < terrain.Length; i++)
            {
                int newIndex = index + step;
                if (newIndex >= terrain.Length)
                {
                    newIndex = newIndex - terrain.Length;
                }

                if (terrain[newIndex] > terrain[index])
                {
                    numberOfSteps++;
                    index = newIndex;
                }
                else
                {
                    break;
                }
            }
         
            return numberOfSteps;
        }
    }
}