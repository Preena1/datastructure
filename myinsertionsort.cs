using System;
namespace myinsertionsort
{
class isort
{
static void Mainde(string[]args)
        {
            int[] element = { 45, 87, 45, 98, 13, 39 };
            int count = element.Length;
            int j, temp;
            for (int i = 1; i < count; i++)
            {
                temp = element[i+1];
                j= i;
                while (j>= 0 && temp < element[j])
             {
                element[j+1] = element[j];
                j = j-1;
            }
                element[j+1] = temp;
            }
             for (int i = 1; i < count; i++)
             Console.WriteLine(element[i]);

    }
}
}