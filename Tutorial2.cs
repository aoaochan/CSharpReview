/// [C에서 리터럴 및 변수 값을 사용하여 데이터 저장 및 검색#]
/// https://learn.microsoft.com/en-us/training/modules/csharp-literals-variables/

namespace CSharpReview;

class Tutorial2
{
    public static void Lesson1()
    {
        // [연습 - 리터럴 값 출력]
        // https://learn.microsoft.com/en-us/training/modules/csharp-literals-variables/2-exercise-literal-values

        // Console.WriteLine('b'); // Okay
        // Console.WriteLine('Hello, world!'); // Error!
        // Console.WriteLine(123);

        /// Float Type - Precision
        /// float        ~6-9 digits
        /// double       ~15-17 digits
        /// decimal      ~28-29 digits
        // Console.WriteLine(0.25f); // float
        // Console.WriteLine(2.625); // double
        // Console.WriteLine(12.39816m); // decimal

        // Console.WriteLine(true);
        // Console.WriteLine(false);

        Console.WriteLine("123");
        Console.WriteLine(123);
        Console.WriteLine("true");
        Console.WriteLine(true);
    }

    public static void Lesson2()
    {
        // [변수 선언]
        // https://learn.microsoft.com/en-us/training/modules/csharp-literals-variables/3-declaring-variables

        // string firstName;
        // char userOption;
        // int gameScore;
        // decimal particlesPerMillion;
        // bool processedCustomer;
    }

    public static void Lesson3()
    {
        // 연습 - 변수 값 설정 및 가져오기
        // https://learn.microsoft.com/en-us/training/modules/csharp-literals-variables/4-exercise-variables

        // string firstName;
        // firstName = "Bob";
        // Console.WriteLine(firstName);
        // firstName = "Liem";
        // Console.WriteLine(firstName);
        // firstName = "Isabella";
        // Console.WriteLine(firstName);
        // firstName = "Yasmin";
        // Console.WriteLine(firstName);

        // string firstName;
        // Console.WriteLine(firstName); // Error!
        
        string firstName = "Bob";
        Console.WriteLine(firstName);
    }

    public static void Lesson4()
    {
        // [암시적 형식 지역 변수 선언]
        // https://learn.microsoft.com/en-us/training/modules/csharp-literals-variables/5-implicitly-typed-local-variables

        // var message = "hello"; // string

        // var message = "Hello, World!";
        // message = 10.703m; // Error!

        // var message; // Error!
    }

    public static void Lesson5()
    {
        // [과제]
        // https://learn.microsoft.com/en-us/training/modules/csharp-literals-variables/6-challenge

        string firstName = "Bob";
        int messages = 3;
        decimal celsius = 34.4m;

        Console.WriteLine($"Hello, {firstName}! You have {messages} messages in your inbox. The temperature is {celsius} celsius.");
    }

    public static void Run() => Lesson5();
}