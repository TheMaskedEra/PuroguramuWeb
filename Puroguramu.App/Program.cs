using Puroguramu.App;
using Puroguramu.App.Middlewares;

var builder = WebApplication.CreateBuilder(args);

BuilderConfigurator.Configure(builder);

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseForwardedHeaders(new ForwardedHeadersOptions());
app.UseReverseProxyLinks();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
