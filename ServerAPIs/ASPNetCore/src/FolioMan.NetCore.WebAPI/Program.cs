var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
string serverUrl = @"http://local.cerebralskyz.com/portmgr/";
if (app.Environment.IsDevelopment() || serverUrl.Contains("/local."))
{
    app.UseSwagger();
    app.UseSwaggerUI();

    // CORS - Allow calling the API from WebBrowsers
    app.UseCors(x => x
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials()
        //.WithOrigins("https://localhost:44351")); // Allow only this origin can also have multiple origins seperated with comma
        .SetIsOriginAllowed(origin => true));// Allow any origin
}
else
{
    app.UseHttpsRedirection();

    app.UseAuthorization();
}



app.MapControllers();

app.Run();
