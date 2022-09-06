int [] RandomArray = {0, 0, 0, 0, 0, 0, 0, 0};
byte i; 
int honestCount = 0;

int HonestCalculator(int number)
{
    if (number%2 == 0)
        return (1);
    else
        return (0);
}

// Код программы
for (i = 0; i<RandomArray.Length; i++)
{
    RandomArray[i] = new Random().Next(100, 1000);
    Console.Write($"{RandomArray[i]} ");
}
Console.WriteLine("");

for (i = 0; i<RandomArray.Length; i++)
    honestCount += HonestCalculator(RandomArray[i]);

Console.Write($"В массиве {honestCount} четных числа.");