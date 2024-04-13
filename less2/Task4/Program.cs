int n = 5;
int[] array = { 2, 5, 6, 9, 7 };
int i = 0;
int max = array[0];
while(i < n)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i = i + 1;
}
System.Console.WriteLine(max);


max = array[0];
for(int j = 0; j < n; j++)// j В данном случае счетчик вместо i
{
    if (array[j] > max)
    {
        max = array[j];
    }
}
System.Console.WriteLine(max);

max = array[0];
foreach(int e in array )// Меняется только способ обращения к элементу массива
{
    if (e > max)
    {
        max = e;
    }
}
System.Console.WriteLine(max);