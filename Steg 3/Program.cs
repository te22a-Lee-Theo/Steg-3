// static void HelloWorld32()
// {
//     for (int i = 0; i < 32; i++)
//     {
//         Console.WriteLine($"Hello World");
//     }
// }

// HelloWorld32();

// static void Square()
// {
//     System.Console.WriteLine("Enter a number");
//     string input = Console.ReadLine();
//     int num; 
//     bool lyckad = int.TryParse(input, out num);
//     System.Console.WriteLine(num*num);
// }

// Square();

static void Multi()
{
    System.Console.WriteLine("Enter a number");
    string First = Console.ReadLine();
    int Num1;
    bool lyckad = int.TryParse(First, out Num1);

    System.Console.WriteLine("Enter a second number");
    string Second = Console.ReadLine();
    int Num2;
    bool lyckad2 = int.TryParse(Second, out Num2);

    System.Console.WriteLine(Num1*Num2);

}

Multi();



Console.ReadLine();