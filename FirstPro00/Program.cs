namespace FirstPro00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = 2.7, x2 = 15.8;
            double y1 = x1 + x2;
            Console.WriteLine($"Hello, {y1}");

            // Проверка даты и времени
            Console.WriteLine(DateTimeDemo.DateTimeNow());

            // проверка стека
            Console.WriteLine(NumberTranslation.TransNumber((int)y1, 2));

            // проверка очереди
            int[] ms = {11,3,41,52,63,71,89,10};
            ReorderingQueue.Reordering(ms);
        }
    }
}
