namespace Test_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            while (c != 9)
            {
            Console.WriteLine("Введите первое число");
            string a = Console.ReadLine();
            float x = Convert.ToInt32(a);
            Console.WriteLine("Введите второе число");
            string b = Console.ReadLine();
            float y = Convert.ToInt32(b);
            Console.WriteLine("Выберете что требуется сделать с числами где: " +
                " 1. Сложить 2 числа" +
                " 2. Вычесть первое из второго" +
                " 3. Перемножить два числа" +
                " 4. Разделить первое на второе" +
                " 5. Возвести в степень N первое число" +
                " 6. Найти квадратный корень из числа" +
                " 7. Найти 1 процент от числа" +
                " 8. Найти факториал из числа" +
                " 9. Выйти из программы");
            string c1 = Console.ReadLine();
             c = Convert.ToInt32(c1);
                if (c == 1)
                {
                    Console.WriteLine("Ответ:");
                    Console.WriteLine(x + y);
                }
                if (c == 2)
                {
                    Console.WriteLine("Ответ:");
                    Console.WriteLine(x - y);
                }
                if (c == 3)
                {
                    Console.WriteLine("Ответ:");
                    Console.WriteLine(x * y);
                }
                if (c == 4)
                {
                    Console.WriteLine("Ответ:");
                    Console.WriteLine(x / y);
                }
                if (c == 5)
                {
                    float i = x;
                    do
                    {
                        i = i * y;
                    }
                    while (i != Math.Pow(x, y));
                    Console.WriteLine("Ответ:");
                    Console.WriteLine(i);
                }
                if (c == 6)
                {
                    Console.WriteLine("Корень первого числа");
                    Console.WriteLine(Math.Sqrt(x));
                    Console.WriteLine("Корень второго числа");
                    Console.WriteLine(Math.Sqrt(y));
                }
                if (c == 7)
                {
                    float i1 = x;
                    i1 = i1 / 100;
                    Console.WriteLine("1% от первого числа равен");
                    Console.WriteLine(i1);
                    y = y / 100;
                    Console.WriteLine("1% от второго числа равен");
                    Console.WriteLine(y);
                }
                if (c == 8)
                {
                    float n = 1;
                    float fact = 1;
                    while (n < x)
                    {
                        n = n + 1;
                        fact = fact * n;
                    }
                    Console.WriteLine("Факториал первого числа равен");
                    Console.WriteLine(fact);
                    float t = 1;
                    float fa = 1;
                    while (t < y)
                    {
                        t = t + 1;
                        fa = fa * t;
                    }
                    Console.WriteLine("Факториал второго числа равен");
                    Console.WriteLine(fa);
                }
                if (c == 9)
                {
                    break;
                }
                c1 = Console.ReadLine();
                c = Convert.ToInt32(c1);
            }
            //a это строка
            //b это строка
            //x это число float
            //y это число float
            //с это действие
        }
    }
}