
//for (int = 1; i < 11; i++)
//{
// Console.WriteLine($"i = {i}");      // 1-10 (1 variant)
//}

//for (int i = 0; i < 10; i++)
//{
// Console.WriteLine($"i = {i + 1}");  // 1-10 (2 variant)    {i + 1} - +1 kuvab, ei mõjuta {i}
//}

//for (int i = 10; i > 0; i--) //i-- = i-1 (step)
//{
//Console.WriteLine($"i = {i}");
//}

int sum = 0;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"i = {i}");
    Console.WriteLine($"Current total: {sum}");
    sum = sum + i; //sum += i;
}
