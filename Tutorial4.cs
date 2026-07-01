// [Perform basic operations on numbers in C#]
// https://learn.microsoft.com/en-us/training/modules/csharp-basic-operations/

namespace CSharpReview;

class Tutorial4
{
    static void Lesson1()
    {
        // [Exercise - Perform addition with implicit data conversion]
        // https://learn.microsoft.com/en-us/training/modules/csharp-basic-operations/2-exercise-add-numbers

        int firstNumber = 12;
        int secondNumber = 7;
        Console.WriteLine(firstNumber + secondNumber); // 19

        string firstName = "Bob";
        int widgetSold = 7;
        Console.WriteLine(firstName + " sold " + widgetSold + " widgets."); // Bob sold 7 widgets.
        Console.WriteLine(firstName + " sold " + widgetSold + 7 + " widgets."); // Bob sold 77 widgets.
        Console.WriteLine(firstName + " sold " + (widgetSold + 7) + " widgets."); // Bob sold 14 widgets.
    }

    static void Lesson2()
    {
        // [Exercise - Perform math operations]
        // https://learn.microsoft.com/en-us/training/modules/csharp-basic-operations/3-exercise-math-operators

        // int sum = 7 + 5;
        // int difference = 7 - 5;
        // int product = 7 * 5;
        // int quotient = 7 / 5;

        // Console.WriteLine("Sum: " + sum);
        // Console.WriteLine("Difference: " + difference);
        // Console.WriteLine("Product: " + product);
        // Console.WriteLine("Quotient: " + quotient);

        // decimal decimalQuotient = 7.0m / 5;
        // Console.WriteLine($"Decimal quotient: {decimalQuotient}");

        // decimal decimalQuotient1 = 7 / 5.0m;
        // decimal decimalQuotient2 = 7.0m / 5.0m;
        // int decimalQuotient3 = 7 / 5.0m;
        // int decimalQuotient4 = 7.0m / 5;
        // int decimalQuotient5 = 7.0m / 5.0m;
        // decimal decimalQuotient6 = 7 / 5;

        // int first = 7;
        // int second = 5;
        // decimal quotient = (decimal)first / (decimal)second;
        // Console.WriteLine(quotient);

        // Console.WriteLine($"Modules of 200 / 5: {200 % 5}");
        // Console.WriteLine($"Modules of 7 / 5: {7 % 5}");

        int value1 = 3 + 4 * 5;
        int value2 = (3 + 4) * 5;
        Console.WriteLine(value1);
        Console.WriteLine(value2);
    }

    static void Lesson3()
    {
        // [Exercise - Increment and decrement values]
        // https://learn.microsoft.com/en-us/training/modules/csharp-basic-operations/4-exercise-increment-decrement

        // int value = 0; // 0
        // value = value + 5; // 5
        // value += 5; // 10

        // int value = 0; // 0
        // value = value + 1; // 1
        // value++; // 2

        // int value = 1;

        // value = value + 1;
        // Console.WriteLine(value);

        // value += 1;
        // Console.WriteLine(value);

        // value++;
        // Console.WriteLine(value);

        // value = value - 1;
        // Console.WriteLine(value);

        // value -= 1;
        // Console.WriteLine(value);

        // value--;
        // Console.WriteLine(value);

        int value = 1;
        value++;
        Console.WriteLine(value);
        Console.WriteLine(value++);
        Console.WriteLine(value);
        Console.WriteLine(++value);
    }

    static void Lesson4()
    {
        // [Complete the challenge to convert Fahrenheit to Celsius]
        // https://learn.microsoft.com/en-us/training/modules/csharp-basic-operations/5-challenge

        int fahrenheit = 94;

        Console.WriteLine($"The temperature is {(fahrenheit - 32.0m) * (5.0m / 9.0m)} Celsius.");
    }

    public static void Run() => Lesson4();
}