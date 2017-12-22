namespace FizzBuzzer.Helper
{
    public static class StringHelper
    {
        public static bool IsNew(this System.Text.StringBuilder input)
        {
            return input.Length == 0;
        }
    }
}
