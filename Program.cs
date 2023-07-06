namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int a, b;
            a = 10;
            b = a;
            a = 50;
            string s = "Satr";
            Console.WriteLine(s + " " + a);
            Console.WriteLine(s + " " + b);
            */
            int intMax = int.MaxValue;
            Console.WriteLine("Int max: " + intMax);
            int intMin = int.MinValue;
            Console.WriteLine("Int min: " + intMin);

            short shortMax = short.MaxValue;
            Console.WriteLine("short max: " + shortMax);
            short shortMin = short.MinValue;
            Console.WriteLine("short min: " + shortMin);

            byte byteMax = byte.MaxValue;
            Console.WriteLine("byte max: " + byteMax);
            byte byteMin = byte.MinValue;
            Console.WriteLine("byte min: " + byteMin);

            long longMax = long.MinValue;
            long longMin = long.MinValue;
            Console.WriteLine("long max: " + longMax);
            Console.WriteLine("long min: " + longMin);

            float floatMax = float.MinValue;
            float floatMin = float.MinValue;
            Console.WriteLine("float max: " + floatMax);
            Console.WriteLine("float min: " + floatMin);

            double doubleMax = double.MinValue;
            double doubleMin = double.MinValue;
            Console.WriteLine("double max: " + doubleMax);
            Console.WriteLine("double min: " + doubleMin);


        }
    }
}