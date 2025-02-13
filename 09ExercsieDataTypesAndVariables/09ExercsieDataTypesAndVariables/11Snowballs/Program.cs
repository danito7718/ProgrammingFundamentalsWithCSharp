//N the number of snowballs being made by Tony and Andi
int N = int.Parse(Console.ReadLine());

double bestSnowballValue = double.MinValue;
int bestSnowballSnow = 0;
int bestSnowballTime = 0;
int bestSnowballQuality = 0;

double snowballValue(int snowballSnow, int snowballTime, int snowballQuality)
{
    return Math.Pow((double)snowballSnow / snowballTime, snowballQuality);
}

for (int i = 0; i < N; i++)
{
    int snowballSnow = int.Parse(Console.ReadLine());
    int snowballTime = int.Parse(Console.ReadLine());
    int snowballQuality = int.Parse(Console.ReadLine());

    double currentValue = snowballValue(snowballSnow, snowballTime, snowballQuality);

    if (currentValue > bestSnowballValue)
    {
        bestSnowballValue = currentValue;
        bestSnowballSnow = snowballSnow;
        bestSnowballTime = snowballTime;
        bestSnowballQuality = snowballQuality;
    }
}
Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {bestSnowballValue} ({bestSnowballQuality})");