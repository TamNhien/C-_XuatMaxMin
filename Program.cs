using System;
using System.Linq;
class Prgram
{
    static void Main()
    {
        Console.Write("Nhap ba so a, b, c: ");
        string[] input = Console.ReadLine().Split();

        double a = double.Parse(input[0]);
        double b = double.Parse(input[1]);
        double c = double.Parse(input[2]);

        double max_value = Math.Max(a, Math.Max(b, c));
        double min_value = Math.Min(a, Math.Min(b, c));

        Console.WriteLine($"Gia tri lon nhat la: {max_value}\nGia tri nho nhat la: {min_value}");"
    }
}