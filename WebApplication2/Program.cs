using Elastic.Apm.NetCoreAll;

var builder = WebApplication.CreateBuilder();

builder.Services.AddControllers();

builder.Services.AddReverseProxy()
    .LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));

var app = builder.Build();

app.UseAllElasticApm(app.Configuration);

app.MapControllers();

app.MapReverseProxy();

app.Run();