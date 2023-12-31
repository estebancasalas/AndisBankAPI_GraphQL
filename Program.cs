using AndisbankAPI_GraphQL.Controllers;
using AndisbankAPI_GraphQL.GraphQL.SchemaGraph;
using AndisbankAPI_GraphQL.Repositories;
using HotChocolate;
using HotChocolate.Types; 

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddGraphQLServer().AddQueryType<LoanQueries>() ;
builder.Services.AddSingleton<LoanRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGraphQL();

app.Run();
