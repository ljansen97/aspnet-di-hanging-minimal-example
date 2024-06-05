using WebApplication1.Extensions;
using WebApplication1.Infra;
using WebApplication1.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddSettingsFiles();
builder.Services.AddControllers();
builder.Services.AddSettings();

builder.Services.AddSingleton(p => p.GetRequiredService<Settings>().SomeSettings!);
builder.Services.AddSingleton(p => p.GetRequiredService<SomeSettings>());
builder.Services.AddSingleton<SomeService>();

var app = builder.Build();

app.MapControllers();

app.Run();