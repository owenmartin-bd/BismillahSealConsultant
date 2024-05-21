//using Microsoft.AspNetCore.Components;
//using Microsoft.AspNetCore.Components.Web;
//using BismillahSealConsultant.Service;
//using Blazored.LocalStorage;
//using Blazored.Modal;
//using BismillahSealConsultant.DataContext; // Ensure this is the correct namespace for your DbContext
//using Microsoft.EntityFrameworkCore;

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddRazorPages();
//builder.Services.AddServerSideBlazor();
//builder.Services.AddScoped<IFileUpload, FileUpload>();
//builder.Services.AddScoped<DispachList>();
//builder.Services.AddBlazoredLocalStorage();
//builder.Services.AddBlazoredModal();

//// Register your DbContext here, adjust for your specific database provider and connection string
//builder.Services.AddDbContext<sealConsultantContext>(options =>
//    options.UseNpgsql(builder.Configuration.GetConnectionString("YourConnectionStringName")));

//var app = builder.Build();

//// Ensure database is created
//using (var scope = app.Services.CreateScope())
//{
//    var dbContext = scope.ServiceProvider.GetRequiredService<sealConsultantContext>();
//    dbContext.Database.EnsureCreated();
//}

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseHttpsRedirection();
//app.UseStaticFiles();
//app.UseRouting();

//app.MapBlazorHub();
//app.MapFallbackToPage("/_Host");

//app.Run();

/// blow part is for for blazore only

//using Microsoft.AspNetCore.Components;
//using Microsoft.AspNetCore.Components.Web;
//using BismillahSealConsultant.Service;
//using Blazored.LocalStorage;
//using Blazored.Modal;


//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddRazorPages();
//builder.Services.AddServerSideBlazor();
//builder.Services.AddScoped<IFileUpload, FileUpload>();
//builder.Services.AddScoped<DispachList>();
//builder.Services.AddBlazoredLocalStorage();
//builder.Services.AddBlazoredModal();



//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseHttpsRedirection();

//app.UseStaticFiles();

//app.UseRouting();

//app.MapBlazorHub();

//app.MapFallbackToPage("/_Host");

//app.Run();

// blazor plus api

//using Microsoft.AspNetCore.Components;
//using Microsoft.AspNetCore.Components.Web;
//using BismillahSealConsultant.Service;
//using Blazored.LocalStorage;
//using Blazored.Modal;
//using System.Net.Http;

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddRazorPages();
//builder.Services.AddServerSideBlazor();
//builder.Services.AddScoped<IFileUpload, FileUpload>();
//builder.Services.AddScoped<DispachList>();
//builder.Services.AddBlazoredLocalStorage();
//builder.Services.AddBlazoredModal();

//// Register HttpClient for making REST API calls.
//builder.Services.AddScoped<HttpClient>(sp =>
//{
//    var client = new HttpClient
//    {
//        BaseAddress = new Uri("/")
//    };
//    return client;
//});

//// Add CORS policy to allow requests from any origin.
//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("AllowAll", policy =>
//    {
//        policy.AllowAnyOrigin()
//              .AllowAnyMethod()
//              .AllowAnyHeader();
//    });
//});

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Error");
//    app.UseHsts();
//}

//app.UseHttpsRedirection();
//app.UseStaticFiles();
//app.UseRouting();

//// Use the CORS policy.
//app.UseCors("AllowAll");

//app.MapBlazorHub();
//app.MapFallbackToPage("/_Host");

//app.Run();


////.............................................................................................................................

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using BismillahSealConsultant.Service;
using Blazored.LocalStorage;
using Blazored.Modal;
using System.Net.Http;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor().AddHubOptions(o =>
{
    o.MaximumReceiveMessageSize = 1024 * 1024; // 64 KB
});
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<IFileUpload, FileUpload>();
builder.Services.AddScoped<DispachList>();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddBlazoredModal();

// Configure CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
});


var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");

    app.UseHsts();
}

// Enable CORS
app.UseCors("AllowAllOrigins");

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
