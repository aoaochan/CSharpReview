// [Perform basic string formatting in C#]
// https://learn.microsoft.com/en-us/training/modules/csharp-basic-formatting/

namespace CSharpReview;

class Tutorial3
{
    public static void Lesson1()
    {
        // [Exercise - Combine strings using character escape sequences]
        // https://learn.microsoft.com/en-us/training/modules/csharp-basic-formatting/2-exercise-character-escape-sequences] 
        
        // Console.WriteLine("Hello\nWorld!");
        // Console.WriteLine("Hello\tWorld!");

        // Console.WriteLine("Hello, \"World!\"");

        // Console.WriteLine("c:\\source\\repos");

        Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
        Console.WriteLine("Invoice: 1021\t\tComplete!");
        Console.WriteLine("Invoice: 1022\t\tComplete!");
        Console.Write("\nOutput Directory:\t");

        Console.WriteLine(@"c:\invoices");

        // Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

        Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
        Console.WriteLine(@"c:\invoices\app.exe -j");
    }

    public static void Lesson2()
    {
        // [Exercise - Combine strings using string concatenation]
        // https://learn.microsoft.com/en-us/training/modules/csharp-basic-formatting/3-exercise-string-concatenation

        string greeting = "Hello";
        string firstName = "Bob";
        string message = greeting + " " + firstName + "!";
        Console.WriteLine(message);
    }

    public static void Lesson3()
    {
        // [Exercise - Combine strings using string interpolation]
        // https://learn.microsoft.com/en-us/training/modules/csharp-basic-formatting/4-exercise-string-interpolation

        // string greeting = "Hello";
        // string name = "Bob";
        // string message = greeting + " " + name + "!";
        // Console.WriteLine(message);

        // int version = 11;
        // string updateText = "Update to Windows";
        // string message = $"{updateText} {version}";
        // Console.WriteLine(message);

        string projectName = "MyProject";
        Console.WriteLine($@"C:\Output\{projectName}\Data");
    }

    public static void Lesson4()
    {
        /// [Complete the challenge]
        /// https://learn.microsoft.com/en-us/training/modules/csharp-basic-formatting/5-challenge
        ///
        /// Begin solving the challenge with the following two lines of code:

        string projectName = "ACME";
        string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
    
        /// 1. You may only use either the Console.WriteLine() or the Console.Write() method twice.
        /// 2. Use character escape sequences, verbatim strings, unicode, and string interpolation to generate the output.
        /// 3. To complete this challenge, your code must produce the following output:
        /// 
        /// View English output:
        ///   c:\Exercise\ACME\data.txt
        /// Посмотреть русский вывод:
        ///   c:\Exercise\ACME\ru-RU\data.txt
        
        string englishMessage = "View English output";
        string englishLocation = $@"c:\Exercise\{projectName}\data.txt";

        string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";

        Console.WriteLine($"{englishMessage}:\n\t{englishLocation}");
        Console.WriteLine($"{russianMessage}:\n\t{russianLocation}");
    }

    public static void Run() => Lesson4();
}