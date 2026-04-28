using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private int _width;
        private int _height;
        private int _locationX;
        private int _locationY;

        private ConsoleColor _borderColor;

        public override void Draw()
        {
            _width = 20;
            _height = 5;
            _locationX = 1;
            _locationY = 5;
            _borderColor = ConsoleColor.Green;

            Console.ForegroundColor = _borderColor;
            Console.CursorTop = _locationY;
            Console.CursorLeft = _locationX;

            string s = ""; ;


        }
    }
}
