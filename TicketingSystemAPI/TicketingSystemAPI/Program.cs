using Microsoft.EntityFrameworkCore;
using TicketingSystemAPI.HubConfig;
using TicketingSystemDB;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSignalR();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TSDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString(nameof(TSDbContext)));
});
builder.Services.AddCors(options => options.AddPolicy(name: "TicketingSystemOrigins",
    policy =>
    {
        policy.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader().AllowCredentials();
    }));



var app = builder.Build();

//app.MigrateDatabase<TSDbContext>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("TicketingSystemOrigins");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapHub<SeatHub>("/seat-status");

app.Run();
