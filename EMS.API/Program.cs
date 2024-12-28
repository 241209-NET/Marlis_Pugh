using Microsoft.EntityFrameworkCore;
using EMS.API.Data;
using EMS.API.Service;
using EMS.API.Repository;
using EMS.API.Model;


var builder = WebApplication.CreateBuilder(args);

//Add dbcontext and connect it to connection string
builder.Services.AddDbContext<EmployeeContext>(options => 
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Dependency Inject the Service Connected to the Interface
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IDepartmentService, DepartmentService>();
builder.Services.AddScoped<IAccountHolderService, AccountHolderService>();
builder.Services.AddScoped<IRoleService, RoleService>();
builder.Services.AddScoped<IProductsService, ProductsService>();

//Dependency Inject the Repository Connected to the Interface
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
builder.Services.AddScoped<IAccountHolderRepository, AccountHolderRepository>();
builder.Services.AddScoped<IRoleRepository, RoleRepository>();
builder.Services.AddScoped<IProductsRepository, ProductsRepository>();



//Add All Controllers for the Route Method Handlers
builder.Services.AddControllers()
  .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseHttpsRedirection();
// After adding Controllers for the Route Method Handlers also Map the Controllers
app.MapControllers();
app.Run();


