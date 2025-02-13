int n = int.Parse(Console.ReadLine());

/*
a #97
b #98
c #99
 */

for (char first = 'a'; first < 'a' + n; first++)
{
    for (char second = 'a'; second < 'a' + n; second++)
    {
        for (char third = 'a'; third < 'a' + n; third++)
        {

            Console.WriteLine($"{first}{second}{third}");
        }
    }
}