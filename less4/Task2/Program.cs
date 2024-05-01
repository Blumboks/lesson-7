int[,] CreateMatrix(int rowCount, int columsCount)// создание матрицы определенного размера
{
    int[,] matrix = new int[rowCount, columsCount];

    Random rnd = new Random();
    for (int i = 0; i < matrix.Getlength(0); i++)
    {
        for (int j = 0; j < matrix.(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return matrix;
}
//int[,] это содание двумерного массива
int[,] matrix  CreateMatrix(3, 4);