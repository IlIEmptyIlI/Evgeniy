var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
Random x = new Random();
laba1.Company company = new laba1.Company("Samsung", "Republic of Korea", "The company is known as a manufacturer of smartphones, integrated circuits, telecommunication equipment, home appliances, audio and video devices.");

app.MapGet("1/", () => "Hello World!");
app.MapGet("2/", () => $"Company name {company.name} Company nworkers {company.location} Company description {company.industry}");
int n = x.Next(101);
app.MapGet("3/", () => $"Random number 0-100: {n}");

app.Run();
