using Core;
using E_CommerceMVC.Data;
using IService.IServiceContract;
using IService.UseCases.Categorys;
using IService.UseCases.Products;
using IService.UseCases.Rates;
using IService.UseCases.Transactions;
using IService.UseCasesInterfaces.Categorys;
using IService.UseCasesInterfaces.Products;
using IService.UseCasesInterfaces.Rates;
using IService.UseCasesInterfaces.Transactions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("AccountContextConnection") ?? throw new InvalidOperationException("Connection string 'AccountContextConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentity<AccountIdentityUser,IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultUI()
    .AddDefaultTokenProviders();
builder.Services.AddControllersWithViews();

var app = builder.Build();


//DI

//Plugin InMemory Data
builder.Services.AddScoped<IProductService, ProductServiceInMemory>();
builder.Services.AddScoped<ITransactionService, TransactionServiceInMemory>();
builder.Services.AddScoped<IRateService, RateServiceInMemory>();
builder.Services.AddScoped<ICategoryService, CategoryServiceInMemory>();
builder.Services.AddScoped<IAccountRepositry, AccountServiceInMemory>();


//UseCases


// -- Products --

builder.Services.AddScoped<IAddProductUseCase, AddProductUseCase>();
builder.Services.AddScoped<IGetProductsUseCase, GetProductsUseCase>();
builder.Services.AddScoped<IDeleteProductUseCase, DeleteProductUseCase>();
builder.Services.AddScoped<IUpdateProductUseCase, UpdateProductUseCase>();
builder.Services.AddScoped<IGetProductByIdUseCase, GetProductByIdUseCase>();
builder.Services.AddScoped<IGetProductsByCategoryIdUseCase, GetProductsByCategoryIdUseCase>();


// -- Category --

builder.Services.AddScoped<IAddCategoryUseCase, AddCategoryUseCase>();
builder.Services.AddScoped<IUpdateCategoryUseCase, UpdateCategoryUseCase>();
builder.Services.AddScoped<IDeleteCategoryUseCase, DeleteCategoryUseCase>();
builder.Services.AddScoped<IGetCategoriesUseCase, GetCategoriesUseCase>();
builder.Services.AddScoped<IGetCategoryByIdUseCase, GetCategoryByIdUseCase>();


// -- Rate -- 

builder.Services.AddScoped<IAddRateUseCase, AddRateUseCase>();
builder.Services.AddScoped<IUpdateRateUseCase, UpdateRateUseCase>();
builder.Services.AddScoped<IDeleteRateUseCase, DeleteRateUseCase>();
builder.Services.AddScoped<IGetRateByIdUseCase, GetRateByIdUseCase>();
builder.Services.AddScoped<IGetRateListByProductIdUseCase, GetRateListByProductIdUseCase>();

// -- Transactions --

builder.Services.AddScoped<IGetAllTransactionsUseCase, GetAllTransactionsUseCase>();
builder.Services.AddScoped<IGetTransactionByIdUseCase, GetTransactionByIdUseCase>();
builder.Services.AddScoped<IRemoveTransactionUseCase, RemoveTransactionUseCase>();
builder.Services.AddScoped<ISearchForTransactionsUseCase, SearchForTransactionsUseCase>();
builder.Services.AddScoped<IEditTransactionUseCase, EditTransactionUseCase>();
builder.Services.AddScoped<IAddTransactionUSeCase, AddTransactionUSeCase>();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
