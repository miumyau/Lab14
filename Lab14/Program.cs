namespace Lab14
{
    internal class Program

    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("бебрик");
            Dog dog = new Dog("песя");
            cat.Say();
            dog.Say();
            cat.ShowInfo();
            dog.ShowInfo();
            Console.ReadKey();
        }
    }
}
