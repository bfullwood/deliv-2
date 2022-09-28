Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
Console.WriteLine();

Console.Write("Enter length: ");
double length = double.Parse(Console.ReadLine());

Console.Write("Enter width: ");
double width = double.Parse(Console.ReadLine());

Console.Write("Enter height: ");
double height = double.Parse(Console.ReadLine());

//calculations//
double Rarea = length * width;
double Rperimeter = (width * 2) + (length * 2);

Console.WriteLine("Area: " + Rarea);
Console.WriteLine("Perimeter: " + Rperimeter);

//outputting size of rooms//
if (Rarea <= 250)
{
    Console.WriteLine("This is a small-sized room.");
}
else if (Rarea < 650)
{
    Console.WriteLine("This is a medium-sized room.");
}
else if (Rarea >= 650)
{
    Console.WriteLine("This is a large-sized room.");
}

Console.WriteLine("Thank you for using Grand Circus' Room Calculator!");









