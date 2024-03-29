
using katalog_3d_api.Controllers;
using katalog_3d_api.data;
using katalog_3d_api.entities;
using katalog_3d_api.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<KatalogContext>();


// Register your repository and controllers
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<GenericController<User>, UserController>();
builder.Services.AddScoped<GenericController<UserProfile>, UserProfileController>();
builder.Services.AddScoped<GenericController<UploadModelDetail>, UploadModelDetailController>();
builder.Services.AddScoped<GenericController<UploadModel>, UploadModelController>();
builder.Services.AddScoped<GenericController<OrderItem>, OrderItemController>();
builder.Services.AddScoped<GenericController<Order>, OrderController>();
builder.Services.AddScoped<GenericController<OfferedService>, OfferedServiceController>();
builder.Services.AddScoped<GenericController<NewsArticle>, NewsArticleController>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
