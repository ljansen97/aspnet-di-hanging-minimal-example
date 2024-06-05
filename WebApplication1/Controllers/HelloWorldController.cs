using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;

namespace WebApplication1.Controllers;

[ApiController]
public class HelloWorldController
{
    private readonly SomeService _someService;

    public HelloWorldController(SomeService someService)
    {
        _someService = someService;
    }

    [HttpGet]
    [Route("hello-world")]
    public string Get() => _someService.DoSomething();
}