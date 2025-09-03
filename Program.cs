using Planets.DB;

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
app.MapGet("/api/v1/planetas/all", () => PlanetasRepository.GetPlanetas()); //Obtener todos los planetas
app.MapGet("/api/v1/planetas/lunas/{lunas}", (int lunas) => PlanetasRepository.GetPlanetasPorLunas(lunas)); //Obtener por cantidad de lunas mayores a lo ingresado
app.MapGet("/api/v1/planetas/tipo/{tipo}", (string tipo) => PlanetasRepository.GetPlanetasPorTipo(tipo));//terrestre,gigante-terrestre gigante-helado 
app.MapGet("/api/v1/planeta/latin/{nombreLatin}", (string nombreLatin) => PlanetasRepository.GetPlanetaLatin(nombreLatin)); //Obtener un planeta por su nombre en latin
app.MapGet("/api/v1/planeta/{nombre}", (string nombre) => PlanetasRepository.GetPlaneta(nombre)); //Obtener un planeta por su nombre

app.UseHttpsRedirection(); //Redirige automáticamente de HTTP → HTTPS para mayor seguridad.
app.UseDefaultFiles(); // Busca index.html automáticamente
app.UseStaticFiles();  // Sirve archivos de wwwroot

app.Run(); //Inicia el servidor web y queda escuchando peticiones.

