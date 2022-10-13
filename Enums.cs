class Enums
{
    static void Main(string[] args)
    {
        Console.WriteLine(Days.Sunday);
        Console.WriteLine((int)Days.Saturday);

        int heat = 32;
        if (heat <= (int)WeatherForecast.Normal)
        {
            Console.WriteLine("Let us wait for the temperature to rise to go out!");
        } else if (heat >= (int)WeatherForecast.Hot)
        {
            Console.WriteLine("A very hot day to go out!");
        }else if (heat >= (int)WeatherForecast.Normal && heat < (int)WeatherForecast.VeryHot)
        {
            Console.WriteLine("Let us go out!");
        }
    }
}

enum Days
{
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday = 23,
    Saturday,
    Sunday
}

enum WeatherForecast
{
    Cold = 5,
    Normal = 10,
    Hot = 30,
    VeryHot = 35
}