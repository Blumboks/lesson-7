int[,] matrix = new int[3, 5];

Random rnd = new Random();
for (int i = 0; i < matrix.Getlength(0); i++)
{
    for (int j = 0; j < matrix.Getlength(1); j++)
    {
        matrix[i, j] = rnd.Next(1, 11);
    }
}

for (int i = 0; i < matrix.Getlength(0); i++)
{
    for (int j = 0; j < matrix.Getlength(1); j++)
    {
        System.Console.WriteLine($"{matrix[i, j]} ");
    }
    System.Console.WriteLine();//перенос на новую строчку
}

int[,] CreateMatrix(int rowCount, int columsCount)// создание матрицы определенного размера
{
    int[,] matrix = new int[rowCount, columsCount];

    Random rnd = new Random();
    for (int i = 0; i < matrix.Getlength(0); i++)
    {
        for (int j = 0; j < matrix.Getlength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.Getlength(0); i++)
    {
        for (int j = 0; j < matrix.Getlength(1); j++)
        {
            System.Console.WriteLine($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();//перенос на новую строчку
    }
}

int[,] matrix = CreateMatrix(4, 5);
ShowMatrix(matrix);