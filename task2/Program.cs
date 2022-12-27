Console.WriteLine();
int[,] array50 = GenerateArray();

int[,] GenerateArray()
{
    Random random = new Random();
    int[,] array = new int[random.Next(2, 11), random.Next(2, 11)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");

        }
        Console.WriteLine();
    }

}


Console.Write("Введите индекс элемента: ");
bool isParsedR = int.TryParse(Console.ReadLine(), out int r);
Console.Write("Введите индекс элемента: ");
bool isParsedC = int.TryParse(Console.ReadLine(), out int c);
if (!isParsedR || !isParsedC || r == 0 || c == 0)
{
    Console.WriteLine("Ошибка!");
    return;
}
if (r > array50.GetLength(0) || c > array50.GetLength(1))
{
    PrintArray(array50);
    Console.WriteLine($"В заданном массиве нет элемента с индексом ({r},{c})");

    return;
}
else
{
    Console.WriteLine($"Элемент {r},{c} = {array50[r - 1, c - 1]}");
    PrintArray(array50);
}
