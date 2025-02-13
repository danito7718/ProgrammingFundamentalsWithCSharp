int waterCapacityLitres = 255;

int n = int.Parse(Console.ReadLine());
int currentLitres = 0;
int litresAdded = 0;
for (int i = 0; i < n; i++)
{
    litresAdded = int.Parse(Console.ReadLine());
    if (currentLitres + litresAdded > waterCapacityLitres)
    {
        Console.WriteLine("Insufficient capacity!");
        continue;
    }
    currentLitres += litresAdded;
}
Console.WriteLine(currentLitres);




