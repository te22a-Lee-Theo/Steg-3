// static void HelloWorld32()
// {
//     for (int i = 0; i < 32; i++)
//     {
//         Console.WriteLine($"Hello World");
//     }
// }

// HelloWorld32();

static void Square()
{
    System.Console.WriteLine("Enter a number");
    string input = Console.ReadLine();
    int num; 
    bool lyckad = int.TryParse(input, out num);
    System.Console.WriteLine(num*num);
}

Square();


Console.ReadLine();