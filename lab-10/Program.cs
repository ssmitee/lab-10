
namespace InheritanceExample
{
    public class ParentClass
    {
        protected double x;

        public ParentClass(double x)
        {
            this.x = x;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Parent Class");
            Console.WriteLine("x: " + x);
        }
    }

    // Класс-потомок
    public class ChildClass : ParentClass
    {
        private double range;

        public ChildClass(double x, double range) : base(x)
        {
            this.range = range;
        }

        public void ProcessData()
        {
            Console.WriteLine("Child Class");
            Console.WriteLine("x: " + x);
            Console.WriteLine("Range: " + range);

            if (x >= range && x <= range + 10)
            {
                Console.WriteLine("Число x принадлежит заданному диапазону.");
            }
            else
            {
                Console.WriteLine("Число x не принадлежит заданному диапазону.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x для класса-родителя:");
            double xParent = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение x для класса-потомка:");
            double xChild = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение диапазона для класса-потомка:");
            double range = double.Parse(Console.ReadLine());

            ParentClass parent = new ParentClass(xParent);
            ChildClass child = new ChildClass(xChild, range);

            Console.WriteLine("Информация о классе-родителе:");
            parent.DisplayInfo();

            Console.WriteLine("Информация о классе-потомке:");
            child.ProcessData();
        }
    }
}