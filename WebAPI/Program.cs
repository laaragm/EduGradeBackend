using Application;
using Infrastructure;
using Presentation;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

builder.Services.AddCors(options =>
{
	options.AddPolicy(name: MyAllowSpecificOrigins,
					  policy =>
					  {
						  policy.WithOrigins(configuration["Settings:FrontendBaseUrl"]!);
						  policy.AllowAnyMethod();
						  policy.AllowAnyHeader();
					  });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Registration for all of our layers
builder.Services
	.AddApplication()
	.AddInfrastructure(configuration)
	.AddPresentation();

builder.Services.AddCors(options =>
{
	options.AddDefaultPolicy(builder =>
	{
		builder.AllowAnyOrigin()
			   .AllowAnyMethod()
			   .AllowAnyHeader();
	});
});

builder.Services.AddControllers();

builder.Services.AddRouting(options => options.LowercaseUrls = true);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(MyAllowSpecificOrigins);

app.MapControllers();

app.Run();
