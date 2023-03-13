using System;

class Program
{
    static void Main(string[] args)
    {
        int x1, y1, w1, h1, x2, y2, w2, h2;
        Console.WriteLine("Please enter 8 digit number :");
        x1 = int.Parse(Console.ReadLine());
        y1 = int.Parse(Console.ReadLine());
        w1 = int.Parse(Console.ReadLine());
        h1 = int.Parse(Console.ReadLine());
        x2 = int.Parse(Console.ReadLine());
        y2 = int.Parse(Console.ReadLine());
        w2 = int.Parse(Console.ReadLine());
        h2 = int.Parse(Console.ReadLine());

        int area = 0;
        int overlapWidth = 0;
        int overlapHeight = 0;

        int leftX = Math.Max(x1 - w1 / 2, x2 - w2 / 2);
        int rightX = Math.Min(x1 + w1 / 2, x2 + w2 / 2);
        int bottomY = Math.Max(y1 - h1 / 2, y2 - h2 / 2);
        int topY = Math.Min(y1 + h1 / 2, y2 + h2 / 2);

        if (leftX < rightX && bottomY < topY)
        {
            overlapWidth = rightX - leftX;
            overlapHeight = topY - bottomY;
            area = overlapWidth * overlapHeight;

            if (area > 8)
            {
                Console.WriteLine("Too Much Overlapping");
            }
            else
            {
                Console.WriteLine("Not Much Overlapping");
            }
        }
        else
        {
            Console.WriteLine("No Overlapping");
        }
    }
}