var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/greetings", () => "Hello from virtual machine! Thanks Vagrant for it!");
app.MapGet("/random/number", () => new Random().Next(0, 100));

app.Run();
