using Microsoft.AspNetCore.Mvc;

namespace Swagger.Controllers;

[ApiController]
[Route("[controller]")]
public class MyTestController : ControllerBase
{

    private readonly ILogger<MyTestController> _logger;

    public MyTestController(ILogger<MyTestController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetTest")]
    public IEnumerable<MyTest> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new MyTest
        {
            tester = "Did it"
        })
        .ToArray();
    }
}



