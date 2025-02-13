// formula PI * r^2 * h

static double CalculateVolume(double r, int h)
{
    return Math.PI * Math.Pow(r, 2) * h;
}

int n = int.Parse(Console.ReadLine());
double maxVolume = double.MinValue;
string biggestKeg = "";
for (int i = 0; i < n; i++)
{
    string keg = Console.ReadLine();
    double r = double.Parse(Console.ReadLine());
    int h = int.Parse(Console.ReadLine());

    double volume = CalculateVolume(r, h);
    if (volume > maxVolume)
    {
        maxVolume = volume;
        biggestKeg = keg;
    }
}
Console.WriteLine(biggestKeg);