using System.Text;
using FizzBuzzer.Helper;

namespace FizzBuzzer
{
    public class FizzBuzz    
    {
        public string Execute(int number)
        {
            var result = new StringBuilder();

            if (number.IsDivisibleBy(3))
            {
                result.Append("Fizz");
            }

            if (number.IsDivisibleBy(5))
            {
                result.Append("Buzz");
            }

            if (result.IsNew())
            {
                result.Append(number);
            }

            return result.ToString();
        }
    }
}
