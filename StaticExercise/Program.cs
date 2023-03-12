namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            double Far = 98.6;
            Console.WriteLine(TempConverter.FahrenheitToCelsius(Far));

            double Cel = 38;
            Console.WriteLine(TempConverter.CelsiusToFahrenheit(Cel));
        }
    }
}
