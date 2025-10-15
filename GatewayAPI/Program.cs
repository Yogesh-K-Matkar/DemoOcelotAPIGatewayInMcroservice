using GatewayAPI.Middlewares;
using Ocelot.Cache.CacheManager;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddControllers();        Remove this statement if you are not using any controller  mapping
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();                          //Remove this statement if you don't want to use Swagger

//Add Ocelot configuration
builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);
builder.Services.AddOcelot().AddCacheManager(x=>x.WithDictionaryHandle()); //Add Cache Manager to Ocelot for implementing Caching

//Add CROS policy to allow all origins
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});

                                                                                                                         

var app = builder.Build();


// Add middleware 

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())        //Remove this statement if you don't want to use Swagger
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

app.UseCors("AllowAllOrigins"); //Add this statement to use CORS Middleware

app.UseHttpsRedirection();      //Add this statement if you want to use HTTPS redirection Middleware

//Custom Middleware  for checking availability of Authorization header for providing access to some of API's based on API url
app.UseMiddleware<TokenCheckerMiddleware>();

//Custom Middleware  for setting Referrer header to "Api-Gateway" to validate the incoming request in the downstream services such as UserIdentityAPI, WeatherAPI
app.UseMiddleware<InterceptionMiddleware>();

app.UseAuthorization();  //Add this statement if you want to use Authorization Middleware
//app.MapControllers();     Remove this statement if you are  not using any controller  mapping

app.UseOcelot().Wait(); //Add this statement to use Ocelot Middleware

app.Run();
