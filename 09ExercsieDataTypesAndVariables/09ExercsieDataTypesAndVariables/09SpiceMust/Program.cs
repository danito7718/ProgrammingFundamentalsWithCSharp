int yield = int.Parse(Console.ReadLine());
int spicesInStorage = 0;
int consumePerDay = 26;
int daysPassed = 0;

while (yield >= 100)
{
    daysPassed++;
    spicesInStorage += yield;
    spicesInStorage -= consumePerDay;
    yield -= 10;
}
if (spicesInStorage >= 26)
{
    spicesInStorage -= 26;
}
Console.WriteLine(daysPassed);
Console.WriteLine(spicesInStorage);