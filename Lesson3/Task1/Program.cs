double CalculateFormula (int a, int b, int c, int d)
{
double numenator = a * b;
int denominator = c + d;
double result = numenator / denominator; 
return result;
}

CalculateFormula(1, 2, 3, 4);

double answer = CalculateFormula(1, 2, 3, 4);
Console.WriteLine(answer);