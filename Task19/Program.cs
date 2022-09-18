Console.WriteLine();
Console.Write("Введите целое число:   ");
string number = Console.ReadLine();
int length = number.Length;

bool IsPalindrome()
{
    for (int i = 0; i < length / 2; i++)
        while (number[i] == number[length - 1])
        {
            return true;
        }
    return false;
}

Console.WriteLine("Ответ:");
if (IsPalindrome()) Console.WriteLine($"1. Введенное число - {number} - является палиндромом");
else Console.WriteLine($"1. Число {number} не является палиндромом");
Console.WriteLine();
