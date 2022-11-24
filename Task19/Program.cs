// Задача 19. Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool Palindrom(int num)
{
    int most = num;
    int nRev = 0;
    while (num > 0)
    {
        int digit = num % 10;
        nRev = nRev * 10 + digit;
        num = num / 10;
    }
    return nRev == most;
}
{
    Console.WriteLine(Palindrom(number) ? "Число является палиндромом" : $"Число не является палиндромом");
}