using Entities.Entities;
using Domain.Interfaces.Generics;
using Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Repository.Generics;
using Domain.Interfaces.ICategory;
using Infrastructure.Repository;
using Domain.Interfaces.IUserFinancialSystem;
using Domain.Interfaces.IFinancialSystem;
using Domain.Interfaces.IExpenditure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ContextBase>(options =>
               options.UseSqlServer(
                   builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ContextBase>();

//Interface and Repository
builder.Services.AddSingleton(typeof(IGeneric<>), typeof(GenericRepository<>));
builder.Services.AddSingleton<ICategory, CategoryRepository>();
builder.Services.AddSingleton<IExpenditure, ExpenditureRepository>();
builder.Services.AddSingleton<IFinancialSystem, FinancialSystemRepository>();
builder.Services.AddSingleton<IUserFinancialSystem, UserFinancialSystemRepository>();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();