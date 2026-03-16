using DatabaseMastery.TransportMongoDb.Mapping;
using DatabaseMastery.TransportMongoDb.Services.AboutServices;
using DatabaseMastery.TransportMongoDb.Services.BrandServices;
using DatabaseMastery.TransportMongoDb.Services.GetInTouchServices;
using DatabaseMastery.TransportMongoDb.Services.HowItWorkServices;
using DatabaseMastery.TransportMongoDb.Services.OfferServices;
using DatabaseMastery.TransportMongoDb.Services.ProjectSectionServices;
using DatabaseMastery.TransportMongoDb.Services.QuestionServices;
using DatabaseMastery.TransportMongoDb.Services.ShipmentServices;
using DatabaseMastery.TransportMongoDb.Services.ShipmentTrackingServices;
using DatabaseMastery.TransportMongoDb.Services.SliderServices;
using DatabaseMastery.TransportMongoDb.Services.TestimonialServices;
using DatabaseMastery.TransportMongoDb.Settings;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Servis Kayýtlarý
builder.Services.AddScoped<ISliderService, SliderService>();
builder.Services.AddScoped<IBrandService, BrandService>();
builder.Services.AddScoped<IOfferService, OfferService>();
builder.Services.AddScoped<IAboutService, AboutService>();
builder.Services.AddScoped<IGetInTouchService, GetInTouchService>();
builder.Services.AddScoped<IHowItWorkService, HowItWorkService>();
builder.Services.AddScoped<ITestimonialService, TestimonialService>();
builder.Services.AddScoped<IProjectSectionService, ProjectSectionService>();
builder.Services.AddScoped<IQuestionService, QuestionService>();
builder.Services.AddScoped<IShipmentService, ShipmentService>();
builder.Services.AddScoped<IShipmentTrackingService, ShipmentTrackingService>();

// AutoMapper
builder.Services.AddAutoMapper(typeof(GeneralMapping));

// MongoDB Ayarlarý
builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("DatabaseSettingsKey"));
builder.Services.AddScoped<IDatabaseSettings>(sp =>
{
    return sp.GetRequiredService<IOptions<DatabaseSettings>>().Value;
});

builder.Services.AddControllersWithViews();

var app = builder.Build();

// HTTP Pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Default}/{action=Index}/{id?}");

app.Run();