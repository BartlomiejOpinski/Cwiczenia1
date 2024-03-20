// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

int bob = 5;
int rob = 10;

Console.WriteLine(bob+rob);

string hello = "hello";

static double CalculateAverage(int[] array)
{
    if (array.Length == 0)
        return 0;

    int sum = 0;
    foreach (int num in array)
    {
        sum += num;
    }

    return (double)sum / array.Length;
}