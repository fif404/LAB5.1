// Скрипников 5.1 22-ИСП-2/1
int[,] matrix = new int[16, 16];

Random rnd = new Random();

Console.WriteLine("Верхняя треугольная матрица:");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    Console.Write("\t");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (j > i)
            matrix[i, j] = rnd.Next(1, 10);

        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}