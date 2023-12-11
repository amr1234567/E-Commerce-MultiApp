using IService.IServiceContract;
using IService.UseCases.Categorys;
using IService.UseCases.Products;
using IService.UseCases.Rates;
using IService.UseCases.Transactions;
using IService.UseCasesInterfaces.Categorys;
using IService.UseCasesInterfaces.Products;
using IService.UseCasesInterfaces.Rates;
using IService.UseCasesInterfaces.Transactions;
using Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//DI

//Plugin InMemory Data
builder.Services.AddScoped<IProductService, ProductServiceInMemory>();
builder.Services.AddScoped<ITransactionService, TransactionServiceInMemory>();
builder.Services.AddScoped<IRateService, RateServiceInMemory>();
builder.Services.AddScoped<ICategoryService, CategoryServiceInMemory>();


//UseCases

// -- Products --

builder.Services.AddScoped<IAddProductUseCase,AddProductUseCase>();
builder.Services.AddScoped<IGetProductsUseCase,GetProductsUseCase>();
builder.Services.AddScoped<IDeleteProductUseCase,DeleteProductUseCase>();
builder.Services.AddScoped<IUpdateProductUseCase,UpdateProductUseCase>();
builder.Services.AddScoped<IGetProductByIdUseCase,GetProductByIdUseCase>();
builder.Services.AddScoped<IGetProductsByCategoryIdUseCase,GetProductsByCategoryIdUseCase>();

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


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
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

app.Run();
