Random rnd = new Random();
int cpuRandom;

bool loopActive = true; //bool - true of false

while (loopActive)
{
    cpuRandom = rnd.Next(1, 4);
    //Console.WriteLine($"cpu has generated {cpuRandom}");
    Console.WriteLine("Make a guess. Enter a number 1-3");
    int userGuess = Int32.Parse(Console.ReadLine()); 

    if (userGuess == cpuRandom)
    {
        Console.WriteLine("Congratulations, your got it!");
        loopActive = false;
        break;
    }
    else
    {
        Console.WriteLine("Oopsie, try again");
    }
}
Console.WriteLine("The end of the game");
