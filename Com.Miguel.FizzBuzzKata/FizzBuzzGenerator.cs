namespace Com.Miguel.FizzBuzzKata
{
    public class FizzBuzzGenerator
    {
        public static string GetChain(int numberOfElements)
        {
            return CreateDisplayString(numberOfElements);
        }

        private static string CreateDisplayString(int numberOfElements)
        {
            var result = string.Empty;
            for (var element = 1; element < numberOfElements + 1; element++)
                result += GetElementDisplay(element) + "\n";
            return result.Substring(0, result.Length - 1);
        }

        private static string GetElementDisplay(int element)
        {
            var elementDisplay = CheckElementDivisible(element);
            return (elementDisplay != string.Empty ? elementDisplay : element.ToString());
        }

        private static string CheckElementDivisible(int element)
        {
            return CheckElementDivisibleByTwo(element) + CheckElementDivisibleByThree(element);
        }

        private static string CheckElementDivisibleByTwo(int element)
        {
            return (element%2 == 0 ? "Fizz" : string.Empty);
        }

        private static string CheckElementDivisibleByThree(int element)
        {
            return (element%3 == 0 ? "Buzz" : string.Empty);
        }
    }
}