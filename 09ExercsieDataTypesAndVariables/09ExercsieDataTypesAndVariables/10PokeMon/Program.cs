//The poke power of the Pokemon N
int Power = int.Parse(Console.ReadLine());

//The distance between the poke targets M
int Distance = int.Parse(Console.ReadLine());

//THe exhaustionFactor
int ExhaustionFactor = int.Parse(Console.ReadLine());

int reachedTarget = 0;
int startingPower = Power;
while (Power >= Distance)
{

    reachedTarget++;
    Power -= Distance;
    if (Power == startingPower / 2 && ExhaustionFactor != 0)
    {
         Power /= ExhaustionFactor;
    }
}

Console.WriteLine(Power);
Console.WriteLine(reachedTarget);
