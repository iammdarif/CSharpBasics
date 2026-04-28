using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Shape
    {
        public virtual void Draw()
        { 
            List<Shape> shapes = new List<Shape>()
            {
                new Triangle(),
                new Circle()
                //new Rectangle()
            };

            foreach (var shape in shapes)
            {
                shape.Draw();
                Console.WriteLine();
            }
        }


    }
}
