using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
Console.WriteLine("Please enter the first number: ");
int start= int.Parse(Console.ReadLine());

Console.WriteLine("Please enter the second number: ");
int end = int.Parse(Console.ReadLine());

Console.WriteLine("The prime numbers between them are :");

int sum = 0;
for (int i = start; i <= end; i++)
{
    
    for (int x = 1; x <= i; x++)
    {
        if (i%x ==0)
        {
            sum++;

        }
        
    }
    if (sum == 2)
    {
        Console.WriteLine(i);
        sum = 0;
    }
    else
    {
        sum = 0;
        continue;

    }
}
