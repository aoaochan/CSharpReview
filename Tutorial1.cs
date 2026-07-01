/// [첫 번째 C# 코드 작성]
/// https://learn.microsoft.com/en-us/training/modules/csharp-write-first/1-introduction

namespace CSharpReview;

class Tutorial1
{
    public static void Lesson1()
    {
        // [연습 - 첫 번째 코드 작성]
        // https://learn.microsoft.com/en-us/training/modules/csharp-write-first/2-exercise-hello-world

        // Console.WriteLine("Hello, World!");

        // Console.Write("Congratulations!");
        // Console.Write(" ");
        // Console.Write("You wrote your first lines of code.");

        Console.WriteLine("Congratulations!");
        Console.Write("You wrote your first lines of code.");
    }

    public static void Lesson2()
    {
        // [과제]
        // https://learn.microsoft.com/en-us/training/modules/csharp-write-first/4-challenge

        Console.WriteLine("This is the first line.\nThis is the second line.");
    }

    public static void Lesson3()
    {
        // [솔루션 검토]
        // https://learn.microsoft.com/en-us/training/modules/csharp-write-first/5-solution

        Console.WriteLine("This is the first line.");

        Console.Write("This is ");
        Console.Write("the second ");
        Console.Write("line.");
    }

    public static void Run() => Lesson3();
}