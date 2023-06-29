using SampleAppPractice.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IMessanger, Messanger>();
builder.Services.AddScoped<IFactory, MessageFactory>();
builder.Services.AddScoped<IClient, SmtpClient>();
builder.Services.AddScoped<SmtpSettings>(_=>
new SmtpSettings()
{
    Host = "smtp.example.com",
    Port = 25
}
);

var app = builder.Build();

app.MapDefaultControllerRoute();

app.Run();


