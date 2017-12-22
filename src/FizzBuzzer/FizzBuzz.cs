using System;
using System.Text;
using FizzBuzzer.Helper;

namespace FizzBuzzer
{
    public class FizzBuzz    
    {
        public string Execute(int number)
        {
            var sb = new StringBuilder();
            
            if(number.IsDivisibleBy(3))
                sb.Append("Fizz");
            if(number.IsDivisibleBy(5))
                sb.Append("Buzz");
            if(sb.IsNew())
                sb.Append(number);

            return sb.ToString();
        }
    }
}
