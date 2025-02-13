using System;
using System.Numerics;

int snowballs = int.Parse(Console.ReadLine());
BigInteger bestSnowballValue = -10000000000;
string output = "";
for (int i = 0; i < snowballs; i++)
{
    int snow = int.Parse(Console.ReadLine());
    int time = int.Parse(Console.ReadLine());
    int quality = int.Parse(Console.ReadLine());

    BigInteger snowballValue = BigInteger.Pow((snow / time), quality);
    if (snowballValue >= bestSnowballValue)
    {
        bestSnowballValue = snowballValue;
        output = $"{snow} : {time} = {bestSnowballValue} ({quality})";
    }
}

Console.WriteLine(output);
