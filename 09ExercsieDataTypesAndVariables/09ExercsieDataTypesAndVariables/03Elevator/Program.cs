int numberOfPeople = int.Parse(Console.ReadLine());
int elevatorCapacity = int.Parse(Console.ReadLine());
int numberOfCourses = (int)Math.Ceiling((double)numberOfPeople / elevatorCapacity);

Console.WriteLine(numberOfCourses);