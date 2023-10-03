namespace GarbageCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("Caluclator Object is Now on " + GC.GetGeneration(calculator) +  "Generation");
            Console.WriteLine("Generationn Colletion occured in 0th Generation "+ " "+GC.CollectionCount(0));
            Console.WriteLine("Generationn Colletion occured in 1th Generation " + " " + GC.CollectionCount(1));
            Console.WriteLine("Generationn Colletion occured in 2th Generation " + " " + GC.CollectionCount(2));
            GC.Collect(0);
            Console.WriteLine("Generationn Colletion occured in 0th Generation " + " " + GC.CollectionCount(0));
            GC.Collect(1);
            Console.WriteLine("Generationn Colletion occured in 1th Generation " + " " + GC.CollectionCount(1));
            
        }
        public class Calculator
        {
            public int Add(int a, int b)
            {
                return a + b;
            }
            public int Subtract(int a, int b)
            {
                return a - b;
            }
            public int Miltiplication(int a, int b)
            {
                return a * b;
            }
            public int Divide(int a, int b)
            {
                return a / b;
            }
        }

    }
}