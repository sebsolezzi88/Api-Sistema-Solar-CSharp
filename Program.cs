var builder = WebApplication.CreateBuilder(args);


//Se agrega el servicio de OpenAPI (Swagger), que permite documentar y probar la API.
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer(); // Permite que Minimal APIs generen documentación
builder.Services.AddSwaggerGen();    


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();      // Genera el JSON
    app.UseSwaggerUI();    // Interfaz web para probar la API
}

//Rutas



app.UseHttpsRedirection(); //Redirige automáticamente de HTTP → HTTPS para mayor seguridad.
app.UseDefaultFiles(); // Busca index.html automáticamente
app.UseStaticFiles();  // Sirve archivos de wwwroot

app.Run(); //Inicia el servidor web y queda escuchando peticiones.

