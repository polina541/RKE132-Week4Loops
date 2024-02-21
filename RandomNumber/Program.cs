Random rnd = new Random();



int randomSum = 0;
for (int  i = 0; i < 5; i++) 
{

    int myRandomNum = rnd.Next(0, 15);  //0 - 14 
    randomSum = randomSum + myRandomNum;
    Console.WriteLine($"Your random number is: {myRandomNum}");

}
Console.WriteLine($"random sum total: {randomSum}");