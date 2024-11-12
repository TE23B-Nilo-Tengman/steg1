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
Console.WriteLine("skriv inte en siffra");
bool siffra = true;
int siffraI;
while(siffra == true)
{
    string siffraS = Console.ReadLine();
    siffra = int.TryParse(siffraS, out siffraI);
    Console.WriteLine("jag sa, inte en siffra");
}
// 7

// 8
Console.WriteLine("gissa rätt siffra (1-1000)");

int gissad = 0;
while(gissad != 839)
{
    string gissning = Console.ReadLine();
    int.TryParse(gissning, out gissad);
    if (gissad >= 839)
    {
        Console.WriteLine($"{gissad}är för högt!");
    }
    if (gissad <= 839)
    {
        Console.WriteLine($"{gissad} är för lågt!");
    }
}
Console.WriteLine("rätt");
// 8










Console.ReadLine();