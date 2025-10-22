namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public static List<string> Generate(int count)
        {
            return Enumerable.Range(1, count)
                .Select(n =>
                {
                    if (n % 15 == 0) return "FizzBuzz";
                    if (n % 5 == 0) return "Buzz";
                    return n.ToString();
                })
                .ToList();
        }
    }
}