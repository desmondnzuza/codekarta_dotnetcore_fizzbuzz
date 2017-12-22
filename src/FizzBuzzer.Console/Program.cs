namespace FizzBuzzer.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var buzzer = new FizzBuzz();

            for (int i = 1; i <= 100; i++)
            {
                System.Console.WriteLine(buzzer.Execute(i));
            }
        }
    }
}
