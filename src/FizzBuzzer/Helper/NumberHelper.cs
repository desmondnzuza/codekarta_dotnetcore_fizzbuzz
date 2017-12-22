namespace FizzBuzzer.Helper
{
    public static class NumberHelper    
    {
        public static bool IsDivisibleBy(this int number, int divident)
        {
            return number % divident == 0;
        }
    }
}
