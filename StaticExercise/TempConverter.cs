public static class TempConverter
{
    public static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    public static double CelsiusToFarenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
}