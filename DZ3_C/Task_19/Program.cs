// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int array = number.Length;
if (array == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
else
{
    Console.WriteLine("число не является пятизначным");
}