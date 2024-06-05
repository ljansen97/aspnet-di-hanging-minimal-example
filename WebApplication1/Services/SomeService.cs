using WebApplication1.Infra;

namespace WebApplication1.Services;

public class SomeService
{
    private readonly SomeSettings _someSettings;

    public SomeService(SomeSettings someSettings)
    {
        _someSettings = someSettings;
    }

    public string DoSomething() => _someSettings.Foo;
}