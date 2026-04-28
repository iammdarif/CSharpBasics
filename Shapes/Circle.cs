using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            double radius;
            double thickness = 0.4;
            ConsoleColor borderColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = borderColor;

            char symbol = '*';

            radius = 10;

            Console.WriteLine();
            double rIn = radius - thickness, rOut = radius + thickness;


            for (double y = radius; y >= -radius; --y)
            {
                for (double x = -radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
