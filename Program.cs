int n = InputInt("Введите пятизначное число: ");
int MinValue = 9999;
int MaxValue = 100000;
int firstNumber = n / 10000;
int secondNumber = (n / 1000) % 10;
int penultimateNumber = (n / 10) % 10;
int lastNumber = n % 10;
if(n > MinValue && n < MaxValue)
{
    if (firstNumber == lastNumber && secondNumber == penultimateNumber)
    {
        Console.WriteLine($"{n} - да");
    }
    else
    {
        Console.WriteLine($"{n} - нет");
    }
}
else
{
    Console.WriteLine("Число должно быть пятизначным");
}

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}