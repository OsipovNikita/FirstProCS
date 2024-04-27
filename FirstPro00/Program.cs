namespace FirstPro00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = 2.7, x2 = 15.8;
            double y1 = x1 + x2;
            Console.WriteLine($"Hello, {y1}");
            Console.WriteLine(NumberTranslation.TransNumber((int)y1, 2));

        }
    }
}
