namespace WebApplication1;

public class WeatherForecast
{
    public DateOnly Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }//Test
    //test2


    //Test 3 - after tag v1.0.1
    //test 4
    //test 5
}
