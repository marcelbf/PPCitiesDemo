var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();



app.MapGet("/Country", () =>
{
    return PPCitiesDemo.CityDB.GetCountries();
})
.WithName("GetCountries")
.WithOpenApi();

app.MapGet("/Cities/{country}", (string country) =>
{
    return PPCitiesDemo.CityDB.GetCities(country);
})
.WithName("GetCities")
.WithOpenApi();

app.Run();
