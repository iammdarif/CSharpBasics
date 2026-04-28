using Shapes;

class Program
{ 
    public static void Main()
    {
        //Shape shape = new Circle();

        //shape.Draw();

        DrawShape();

        Console.ReadKey();
    }

    public static void DrawShape()
    {
        Shape shape = null;

        do
        {
            Console.Clear();
            Console.WriteLine("[1] Triange");
            Console.WriteLine("[2] Circle");
            Console.WriteLine("[3] All");

            ConsoleKey input = Console.ReadKey().Key;

            switch (input)
            { 
                case ConsoleKey.D1:
                    shape = new Triangle();
                    break;
                case ConsoleKey.D2:
                    shape = new Circle();
                    break;
                case ConsoleKey.D3:
                    shape = new Shape();
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

            if (shape != null)
            {
                shape.Draw();
            }


        } while (Console.ReadKey().Key != ConsoleKey.Spacebar);
    }
}