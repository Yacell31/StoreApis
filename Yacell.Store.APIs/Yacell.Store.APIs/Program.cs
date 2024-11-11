using Microsoft.EntityFrameworkCore;
using Yacell.Store.APIs.Repositories;
using Yacell.Store.APIs.Repositories.Contracts;
using Yacell.Store.APIs.Services;
using Yacell.Store.APIs.Services.Contracts;
using Yacell.StoreAPIs.Data;
using Yacell.StoreAPIs.Data.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
var connectionString = builder.Configuration.GetConnectionString("StoreDatabase");
//builder.Services.AddSqlite<StoreContext>(connectionString);
builder.Services.AddDbContext<YacellStoreContext>(o => o.UseSqlServer(connectionString));
builder.Services.AddTransient(typeof(IYacellStoreContext), typeof(YacellStoreContext));
builder.Services.AddTransient(typeof(ICustomerRepository), typeof(CustomerRepository));
builder.Services.AddTransient(typeof(ICustomerService), typeof(CustomerService));



//serviceCollection.AddDbContext<YourContext>(options => options.UseSqlServer(_configuration.GetConnectionString("ConnectionString"), b => b.MigrationsAssembly("Your.Assembly")));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
   
    app.UseSwaggerUI(c =>
    {

        app.UseSwagger();
        app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyAPI v1"));

    });

}


using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<YacellStoreContext>();
    dbContext.Database.Migrate();
}



app.UseHttpsRedirection();

app.UseAuthorization();

app.UseRouting();

app.MapControllers();

app.Run();


public partial class Program { }
