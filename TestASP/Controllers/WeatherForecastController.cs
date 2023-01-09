using Microsoft.AspNetCore.Mvc;

namespace TestASP.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private IEnumerable<Phone> phones;
    public WeatherForecastController()
    {
        this.phones = new db_a92dc1_inkainka7777Context().Phones;
    }
    

    [HttpGet]
    [Route("GetAllPhone")]
    public IEnumerable<Phone> Get()
    {
        return this.phones;
    }

    [HttpPost]
    [Route("AddPhone")]
    public void AddPhone(string title,float price)
    {
        using (db_a92dc1_inkainka7777Context context = new db_a92dc1_inkainka7777Context())
        {
            context.Add(new Phone() { Title = title, Price = price });
            context.SaveChanges();
        }
    }
}

