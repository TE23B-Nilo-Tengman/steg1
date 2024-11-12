// 1
if (6 >= 3)
{
    Console.WriteLine("Hello, World!");
}
// 1

// 2
Console.WriteLine("Write your username");
string namn = Console.ReadLine();
if (namn == "noname")
{
    Console.WriteLine("Welcome!");
}
// 2

// 3
Console.WriteLine("Write your username");
string namn3 = Console.ReadLine();


Console.WriteLine("Write your password");
string pass = Console.ReadLine();

if (namn3 == "noname" && pass == "nopass")
{
    Console.WriteLine("Welcome!");
}
else
{
    Console.WriteLine("Wrong username or password");
}
// 3

// 4
int x = 0;
while (x < 33)
{
    Console.WriteLine("Hello, World");
    x++;
}
// 4

// 5
Console.WriteLine("Write your password");
string pass2 = Console.ReadLine();
while (pass2 != "nopass")
{
    Console.WriteLine("WRONG PASSWORD");
    pass2 = Console.ReadLine();
}
// 5

// 6
int c = 0;
int z = 0;
while (z < 5)
{
    Console.WriteLine("write a number");
    string number = Console.ReadLine();
    int.TryParse(number, out c);
    if(c > 5)
    {
        Console.WriteLine("Högre än 5!");
    }
    z++;
}
// 6

// 7

// 7










Console.ReadLine();