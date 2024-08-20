namespace Homework;
internal class TheShapes
{
    /// <summary>
    /// Calculates the perimeter and surface area of various geometric shapes based on user input.
    /// </summary>
    public static void Shapes()
    {
        Console.Write("Enter name of shape: ");
        string shape = Console.ReadLine();
        Console.WriteLine(Formula(shape));
        static string Formula(string shape)
        {
            double Perimeter;
            double Surface;
            switch (shape)
            {
                case "Circle":
                    Console.Write("Enter the radius of circle: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    Perimeter = 2 * Math.PI * radius;
                    Surface = Math.PI * radius * radius;
                    break;
                case "Oval":
                    Console.Write("Enter the firs radius: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter enter the second radius: ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Perimeter = 2 * Math.PI * Math.Sqrt((a * a + b * b) / 2);
                    Surface = Math.PI * a * b;
                    break;
                case "Triangle":
                    Console.Write("Enter a length: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter b length: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter c length: ");
                    double c = Convert.ToDouble(Console.ReadLine());
                    double semiperimeter = (a + b + c) / 2;
                    Surface = Math.Sqrt(semiperimeter * (semiperimeter - a) * (semiperimeter - b) * (semiperimeter - c));
                    Perimeter = a + b + c;
                    break;
                case "Square":
                    Console.Write("enter one side length: ");
                    double side = Convert.ToDouble(Console.ReadLine());
                    Perimeter = 4 * side;
                    Surface = side * side;
                    break;
                case "Rectangle":
                    Console.Write("Enter length: ");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter width: ");
                    double width = Convert.ToDouble(Console.ReadLine());
                    Perimeter = 2 * (length + width);
                    Surface = length * width;
                    break;
                case "Parallelogram":
                    Console.Write("Enter base length: ");
                    double baselength = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter side length: ");
                    double sidelength = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter height: ");
                    double height = Convert.ToDouble(Console.ReadLine());
                    Perimeter = 2 * (baselength + sidelength);
                    Surface = baselength * height;
                    break;
                case "Trapezoid":
                    Console.Write("Enter the length of side base1: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the length of side base2: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the length of side c: ");
                    c = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the length of side d: ");
                    double d = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the height: ");
                    height = Convert.ToDouble(Console.ReadLine());
                    Surface = (a + b) * height / 2;
                    Perimeter = a + b + c + d;
                    break;
                case "Pentagon":
                    Console.Write("Enter the side length of the pentagon: ");
                    side = Convert.ToDouble(Console.ReadLine());
                    Perimeter = 5 * side;
                    Surface = (Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * side * side) / 4;
                    break;
                case "Hexagon":
                    Console.Write("Enter the side length of the hexagon: ");
                    side = Convert.ToDouble(Console.ReadLine());
                    Perimeter = 6 * side;
                    Surface = (3 * Math.Sqrt(3) / 2) * Math.Pow(side, 2);
                    break;
                default:
                    return $"List doesn't have shape {shape} or try format Aa";
            }
            return $"Perimeter is {Perimeter}. Surface Area is {Surface}";
        }
    }
}