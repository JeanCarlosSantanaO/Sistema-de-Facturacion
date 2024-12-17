using Microsoft.EntityFrameworkCore;
using Sistema_de_Facturacion.Abstraccion.Repositorios;
using Sistema_de_Facturacion.Abstraccion.Servicios;
using Sistema_de_Facturacion.Implementaciones.Repositorios;
using Sistema_de_Facturacion.Implementaciones.Servicios;
using Sistema_de_Facturacion.Modelos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//conectar la base de datos 
builder.Services.AddDbContext<SistemaDeFacturacionContext>(Options => Options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnetion")));
//Añadir los repositorios
builder.Services.AddScoped<IRepositorioCliente, RepositorioCliente>();
builder.Services.AddScoped<IRepositorioDetalleFactura, RepositorioDetalleFactura>();
builder.Services.AddScoped<IRepositorioFactura, RepositorioFactura>();
builder.Services.AddScoped<IRepositorioPago, RepositorioPago>();
builder.Services.AddScoped<IRepositorioProducto, RepositorioProducto>();

//Añadir los servicios
builder.Services.AddScoped<IServicioCliente, ServicioCliente>();
builder.Services.AddScoped<IServicioDetalleFactura, ServicioDetalleFactura>();
builder.Services.AddScoped<IServicioFactura, ServicioFactura>();
builder.Services.AddScoped<IServicioPago, ServicioPago>();
builder.Services.AddScoped<IServicioProducto, ServicioProducto>();
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
