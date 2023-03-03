double sum = 0, a = -1.25, b = -1.5, c = 0.75;
int i = 0;
double[] arr = new double[10];
for (double x = -1.5; x <= 3.5; x += 0.5)
{
    arr[i] = (Math.Pow(10, -2) * b * c) / x + Math.Cos(Math.Sqrt(Math.Pow(a, 3) * x));
    Console.WriteLine(arr[i]);
}