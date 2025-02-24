using Structure;

double length, width;
Console.Write("Enter Length of the Rectangle:");  length = double.Parse(Console.ReadLine());
Console.Write("Enter width of the Rectangle:"); width = double.Parse(Console.ReadLine());
Rectangle rectangle = new Rectangle(length, width);

Console.WriteLine($"Area of the Rectangle: {rectangle.Area()}");
Console.WriteLine($"Perimeter of the Rectangle: {rectangle.Perimeter()}");
