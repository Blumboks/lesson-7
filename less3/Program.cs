﻿double ColculateFormula(int a, int b, int c, int d,)
{
    double numenator = a * b;
    int denomenator = c + d;
    double result = numenator / denomenator;
    return result;
}

double result = ColculateFormula(1, 2, 3, 4);
System.Console.WriteLine(result);