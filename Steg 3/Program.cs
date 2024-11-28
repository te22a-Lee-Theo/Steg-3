// static void HelloWorld32()
// {
//     for (int i = 0; i < 32; i++)
//     {
//         Console.WriteLine($"Hello World");
//     }
// }

// HelloWorld32();

using System.Net.Http.Headers;
using System.Runtime.InteropServices.Marshalling;

static int Square()
{
    // System.Console.WriteLine("Enter a number");
    // string input = Console.ReadLine();
    int num = GetNumberInput(); 
    // bool lyckad = int.TryParse(input, out num);
    // System.Console.WriteLine(num*num);
    int ans = num*num;
    return ans;
}

int Ans = Square();
System.Console.WriteLine(Ans);


static int Multi()
{
    // System.Console.WriteLine("Enter a number");
    // string First = Console.ReadLine();
    int Num1 = GetNumberInput();
    // bool lyckad = int.TryParse(First, out Num1);

    // System.Console.WriteLine("Enter a second number");
    // string Second = Console.ReadLine();
    int Num2 = GetNumberInput();
    // bool lyckad2 = int.TryParse(Second, out Num2);

    int ans = Num1*Num2;
    return ans;

}

Ans = Multi();
System.Console.WriteLine(Ans);

static int RightTriangleArea()
{
    // System.Console.WriteLine("Enter the length of the triangle");
    // string length = Console.ReadLine();
    int Length = GetNumberInput();
    // bool lyckad = int.TryParse(length, out Length);

    // System.Console.WriteLine("Enter the height of the triangle");
    // string height = Console.ReadLine();
    int Height = GetNumberInput();
    // bool lyckad2 = int.TryParse(height, out Height);

    int ans = Length*Height/2;
    return ans;
}

Ans = RightTriangleArea();
System.Console.WriteLine(Ans);



static int GetNumberInput()
{
    while (true)
    {
        System.Console.WriteLine("Enter a number");
        string input = Console.ReadLine();
        int number;
        bool True = int.TryParse(input, out number);

        if (True)
        {
            return number;
        }
        else
        {
            System.Console.WriteLine("Invalid input");
        }

    }
}

// GetNumberInput();





Console.ReadLine();