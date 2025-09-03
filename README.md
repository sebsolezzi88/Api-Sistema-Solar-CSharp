# 🌌 API Sistema Solar en .NET C

Este proyecto es una **API minimalista en .NET C#** que expone
información detallada sobre los planetas del sistema solar.\
Incluye datos físicos, orbitales, atmosféricos, lunas y enlaces a
imágenes de cada planeta.

## 🚀 Tecnologías utilizadas

-   .NET 8 (Minimal APIs)
-   Swagger / OpenAPI (documentación interactiva)
-   C#
-   HTML + Tailwind (para la interfaz en `wwwroot`)

## 📂 Estructura del proyecto

-   `Program.cs` → configuración principal de la API.
-   `Planets.DB` → contiene los registros y repositorio con la
    información de los planetas.
-   `wwwroot/index.html` → página de inicio con documentación visual.

## 📸 Captura

![Imagen sitio Principal Api](https://i.imgur.com/tFmIahQ.png)


## 🔗 Endpoints disponibles

### 1. Obtener todos los planetas

    GET /api/v1/planetas/all

### 2. Obtener un planeta por nombre

    GET /api/v1/planeta/{nombre}

👉 Ejemplo: `/api/v1/planeta/Júpiter`

### 3. Obtener un planeta por nombre en latín

    GET /api/v1/planeta/latin/{nombreLatin}

👉 Ejemplo: `/api/v1/planeta/latin/Neptunus`

### 4. Obtener planetas por tipo

    GET /api/v1/planetas/tipo/{tipo}

👉 Ejemplo: `/api/v1/planetas/tipo/terrestre`\
Tipos disponibles: `terrestre`, `gigante gaseoso`, `gigante helado`

### 5. Obtener planetas por cantidad de lunas

    GET /api/v1/planetas/lunas/{lunas}

👉 Devuelve los planetas con una cantidad **mayor** al valor ingresado.

## 🌍 Ejecución local

1.  Clonar el repositorio:

``` bash
git clone https://github.com/sebsolezzi88/Api-Sistema-Solar-CSharp.git
cd Api-Sistema-Solar-CSharp
```

2.  Restaurar dependencias:

``` bash
dotnet restore
```

3.  Ejecutar la API:

``` bash
dotnet run
```

4.  Abrir en el navegador:

-   API Swagger UI → `https://localhost:5163/swagger`
-   Página principal → `https://localhost:5163/`

## 🧑‍💻 Autor

Desarrollado por **Sebastián Solezzi** © 2025