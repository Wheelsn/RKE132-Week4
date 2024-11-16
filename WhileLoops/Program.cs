Random rnd = new Random();
int cpuRandom;

bool loopActive = true; //bool - true or false

while (loopActive)
{
    cpuRandom = rnd.Next(1,4); 
    Console.WriteLine($"CPU has generated {cpuRandom}");
    Console.WriteLine("Make a guess. Enter number between 1-3");

    int userNumber = Int32.Parse(Console.ReadLine());

    if(userNumber == cpuRandom)
    {
        Console.WriteLine("You guessed it!");
        //loopActive = false;
        break;
    }
    else
    {
        Console.WriteLine("Try again!");
    }
}
Console.WriteLine("Game Over!");