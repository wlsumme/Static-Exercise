namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var fah = TempConverter.CelsiusToFahrenhiet(17);

            var cel = TempConverter.FahrenheitToCelsius(62.8);

            Console.WriteLine($"17 degrees celsius is {fah} degees fahrenhiet.");
            Console.WriteLine($"62.8 degrees fahrenhiet is {cel} degrees celsius.");
        }
    }
}
