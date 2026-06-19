using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDynamicweb(builder.Environment, builder.Configuration);
builder.Services.AddHttpContextAccessor();
var app = builder.Build();
app.UseDynamicweb();

app.Run();
