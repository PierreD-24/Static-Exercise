namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            double tempFahrenheit = TempConverter.CelsiusToFarenheit(50);
            double tempCelsius = TempConverter.FahrenheitToCelsius(50);
            
            Console.WriteLine($"Temp Fahrenheit: {tempFahrenheit}");
            Console.WriteLine($"Temp Celsius: {tempCelsius}");
        }
    }
}
