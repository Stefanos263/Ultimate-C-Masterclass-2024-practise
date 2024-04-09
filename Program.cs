//var internationalPizzaDay23 = new DateTime(2023, 2, 9);

//Console.WriteLine("year is " + internationalPizzaDay23.Year);
//Console.WriteLine("Month is " + internationalPizzaDay23.Month);
//Console.WriteLine("Day is " + internationalPizzaDay23.Day);
//Console.WriteLine("Day of the week is " + internationalPizzaDay23.DayOfWeek);

//var internationalPizzaDay24 = internationalPizzaDay23.AddYears(1);

//Console.WriteLine();
//Console.WriteLine("year is " + internationalPizzaDay24.Year);
//Console.WriteLine("Month is " + internationalPizzaDay24.Month);
//Console.WriteLine("Day is " + internationalPizzaDay24.Day);
//Console.WriteLine("Day of the week is " + internationalPizzaDay24.DayOfWeek);

//var rectangle1 = new Rectangle(5, 10);

//Console.WriteLine($"Width is " + rectangle1.Width);
//Console.WriteLine($"Height is " + rectangle1.Height);
//Console.WriteLine($"Area is " + rectangle1.CalculateArea());
//Console.WriteLine($"Circumference is " + rectangle1.CalculateCircumference());

//Console.ReadKey();

//class Rectangle
//{
//    public int Width = 3;
//    public int Height = 4;

//    public Rectangle(int width, int height)
//    {
//        Width = width;
//        Height = height;
//    }

//    public int CalculateCircumference()
//    {
//        return 2 * Width + 2 * Height;
//    }

//    public int CalculateArea()
//    {
//        return Width * Height;
//    }




//}


using System.Linq.Expressions;

Console.WriteLine("Please enter a number:");
string input = Console.ReadLine();
try
{
    int number = ParseStringToInt(input);
    Console.WriteLine("String succesfully parsed, the result is " + number);
}
catch
{
    Console.WriteLine("An exception was thrown.");
}
finally
{
    Console.WriteLine(" Finally Block is being executed.");
}

int ParseStringToInt(string input)
{ 

 try
 {
    return int.Parse(input);
 }
 catch
 {
        Console.WriteLine($"Parsing error" + $"in the {nameof(ParseStringToInt)} method.");
        return 0;
 }

}
Console.ReadKey();