int n = 10;
int[] array = { 1, 4, 5, 6, 7, 8, 9, 5, 77, 88 };
int i = 0;

while(i < n)
{
    if(array[i] % 2 == 0)
    {
        System.Console.Write($"{array[i]} ");
    }
    i = i + 1;
}