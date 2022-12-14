// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Number(int num)
{
    int n = num;
    int rev = 0;
    while (n != 0)
    {
        int r = n % 10;
        rev = rev * 10 + r;
        n = n / 10;
    }
    if(num == rev)
    {
        Console.Write($"{num} является палиндромом!");
    }
    else
    {
        Console.Write($"{num} не является палиндромом!");
    }
}

Console.WriteLine("Введите пятизначное число: ");
int N = int.Parse(Console.ReadLine()!);
if(N > 9999 && N <=100000)
{
    // int n = N;
    // int rev = 0;
    // while (n != 0)
    // {
    //     int r = n % 10;
    //     rev = rev * 10 + r;
    //     n = n / 10;
    // }
    // if(rev == N)
    // {
    //     Console.WriteLine($"{N} является палиндромом!");
    // }
    // else
    // {
    //     Console.WriteLine($"{N} не является палиндромом!");
    // }
    Number(N);
}
else 
{
    Console.WriteLine($"Ваше число {N} не является пятизначным, попробуйте ввести заново");
}