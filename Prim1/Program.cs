using System.Collections.Generic;
Console.WriteLine("Define a positive integer 'n': ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Define a positive integer 'm' that is larger than 'n' : ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine($"Here are all of the prime numbers between {n} and {m}:");

for (int i = n; i <= m; i++)
{
    if((i%2 != 0 && i%3 != 0 && i%5 != 0 && i%7 != 0) || i == 2 || i == 3 || i == 5 || i == 7){
        Console.WriteLine(i);
    }
}

Console.WriteLine("Press enter to leave the program.");
Console.ReadLine();