var builder = WebApplication.CreateBuilder(args);//Uygulama oluşturucu

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();//Uygulama

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/hello", () => "Hello World!"); // İstekleri nasıl karşılıyoruz?

app.Run();//Uygulamayı ayağa kaldır
