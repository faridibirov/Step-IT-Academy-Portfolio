using SampleAppPractice.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IMessanger, Messanger>();
builder.Services.AddScoped<MessageFactory>();
builder.Services.AddScoped<SmtpClient>();
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


