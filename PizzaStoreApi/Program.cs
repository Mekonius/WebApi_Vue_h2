
using Microsoft.EntityFrameworkCore;
using pizzaStoreApi.Data;

var builder = WebApplication.CreateBuilder(args);

//Add services to container
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Cors 
builder.Services.AddCors(options => {
    options.AddPolicy("AllowAll", policy => {
        policy.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});


builder.Services.AddDbContext<PizzaDbContext>(O => 
    O.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")?? "Data Source=pizzas.db"));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAll");

app.UseAuthentication();
app.MapControllers();

app.Run();
