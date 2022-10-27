// Напишите программу, которая принимает на вход число (N) и выдаёт
// таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите номер: ");
int number = int.Parse(Console.ReadLine()!);

int[] fillTheCubeArray(int number)
{
    int[] cube = new int[number];
    for (int i = 0; i < number; i++)
    {
        cube[i] = (i + 1) * (i + 1) * (i + 1);
    }
    return cube;
}

void printCubeArray(int[] array, int number)
{
    for (int i = 0; i < number; i++)
    {
        Console.Write(array[i] + " ");
    }
}

printCubeArray(fillTheCubeArray(number), number);