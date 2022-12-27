

Random rnd = new Random();
int i = 10; //rnd.Next(10, 100);                            
int j = 10; //rnd.Next(10, 100);
int[,] array = new int[i, j];
double[] averagemean = new double[i];


void GenerateArray(int row, int column)
{
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = rnd.Next(100, 1000);
        }
    }
}

void PrintArray(int row, int column)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }

}

void AverageElement(int row, int column)
{

    for (int j = 0; j < column; j++)
    {
        double average = 0;
        int count = 0;
        for (int i = 0; i < row; i++)
        {
            if (array[i, j] % 10 == array[i, j] / 100)
            {
                count++;
                average += array[i, j];
            }
        }

        if (count == 0)
        {
            averagemean[j] = 0;
        }
        else
        {
            averagemean[j] = average / (double)count;
        }
    }

}


GenerateArray(i, j);
PrintArray(i, j);
AverageElement(i, j);
foreach (int item in averagemean)
{
    Console.Write(item + " ");
}
