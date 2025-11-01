using System.ComponentModel;
using System.Data.Common;
using System.Text;

namespace Interview.ConsoleRunner;

public record FizzBuzzRule(int divider, string message, int priority);

public class FizzBuzz()
{
    private List<FizzBuzzRule> rules = [
        new(3,"Fizz",2),
        new(5,"Buzz",1),
        new(7,"Bazz",3),
        new(11,"Jazz",2)
    ];


    public string Run(int number)
    {
        StringBuilder stringBuilder = new StringBuilder();

        var localRules = rules.OrderBy(w => w.priority).ThenBy(w => w.message).ToList();

        foreach (var rule in localRules)
        {
            if (number % rule.divider == 0)
            {
                stringBuilder.Append(rule.message);
            }
        }


        if (stringBuilder.Length == 0)
        {
            stringBuilder.Append($"{number}");
        }

        // if (number % 3 == 0 && number % 5 == 0)
        // {
        //     return "FizzBuzz";
        // }
        // else if (number % 5 == 0)
        // {
        //     return "Buzz";
        // }
        // else if (number % 3 == 0)
        // {
        //     return "Fizz";
        // }


        return stringBuilder.ToString();
    }
}