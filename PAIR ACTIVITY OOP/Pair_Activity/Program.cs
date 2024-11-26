using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pair_Activity
{

    static void Main(string[] args)
    {
        Calculate[] shapes = new Calculate[]
        {
                new Rectangle { Length = 10, Width = 5 },
                new Circle { Radius = 7 },
                new Triangle { Base = 24, Height = 5 }
        };
        foreach (var shape in shapes)
        {
            Console.WriteLine("Area: " + shape.CalculateArea());
        }

        Console.ReadLine();
    }
}


