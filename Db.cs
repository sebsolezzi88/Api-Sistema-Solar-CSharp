namespace Planets.DB
{
    // Record para las características físicas del planeta
    public record CaracteristicasFisicas(
        string Masa,
        int Diametro,
        double Gravedad,
        int Densidad,
        double DuracionDia,
        int NumeroLunas
    );

    // Record para los datos orbitales del planeta
    public record DatosOrbitales(
        string DistanciaMediaSol,
        int PeriodoOrbital,
        double VelocidadOrbital
    );

    // Record para la información de la atmósfera
    public record Atmosfera(
        string Composicion,
        int TemperaturaMedia
    );

    // Record principal para el planeta
    public record Planeta(
        string Nombre,
        string NombreLatin,
        string Tipo,
        CaracteristicasFisicas CaracteristicasFisicas,
        DatosOrbitales DatosOrbitales,
        Atmosfera Atmosfera,
        List<string> Lunas,
        string Imagen
    );

    // Clase estática para contener la lista de planetas
    public static class PlanetasRepository
    {
        private static readonly List<Planeta> _planetas = new()
        {
            new Planeta (
                Nombre: "Mercurio",
                NombreLatin: "Mercurius",
                Tipo: "Terrestre",
                CaracteristicasFisicas: new CaracteristicasFisicas(
                    Masa: "3.30e23",
                    Diametro: 4879,
                    Gravedad: 3.7,
                    Densidad: 5427,
                    DuracionDia: 4222.6,
                    NumeroLunas: 0
                ),
                DatosOrbitales: new DatosOrbitales(
                    DistanciaMediaSol: "57.9e6 km (0.39 UA)",
                    PeriodoOrbital: 88,
                    VelocidadOrbital: 47.9
                ),
                Atmosfera: new Atmosfera(
                    Composicion: "Trazas de O2, Na, H2, He, K",
                    TemperaturaMedia: 167
                ),
                Lunas: new List<string>(),
                Imagen: "https://upload.wikimedia.org/wikipedia/commons/4/4a/Mercury_in_true_color.jpg"
            ),
            new Planeta (
                Nombre: "Venus",
                NombreLatin: "Venus",
                Tipo: "Terrestre",
                CaracteristicasFisicas: new CaracteristicasFisicas(
                    Masa: "4.87e24",
                    Diametro: 12104,
                    Gravedad: 8.87,
                    Densidad: 5243,
                    DuracionDia: 2802,
                    NumeroLunas: 0
                ),
                DatosOrbitales: new DatosOrbitales(
                    DistanciaMediaSol: "108.2e6 km (0.72 UA)",
                    PeriodoOrbital: 225,
                    VelocidadOrbital: 35.0
                ),
                Atmosfera: new Atmosfera(
                    Composicion: "96.5% CO2, 3.5% N2",
                    TemperaturaMedia: 464
                ),
                Lunas: new List<string>(),
                Imagen: "https://upload.wikimedia.org/wikipedia/commons/e/e5/Venus-real_color.jpg"
            ),
            new Planeta (
                Nombre: "Tierra",
                NombreLatin: "Terra",
                Tipo: "Terrestre",
                CaracteristicasFisicas: new CaracteristicasFisicas(
                    Masa: "5.97e24",
                    Diametro: 12742,
                    Gravedad: 9.8,
                    Densidad: 5514,
                    DuracionDia: 24,
                    NumeroLunas: 1
                ),
                DatosOrbitales: new DatosOrbitales(
                    DistanciaMediaSol: "149.6e6 km (1 UA)",
                    PeriodoOrbital: 365,
                    VelocidadOrbital: 29.8
                ),
                Atmosfera: new Atmosfera(
                    Composicion: "78% N2, 21% O2, 1% Ar",
                    TemperaturaMedia: 15
                ),
                Lunas: new List<string>{ "Luna" },
                Imagen: "https://upload.wikimedia.org/wikipedia/commons/9/97/The_Earth_seen_from_Apollo_17.jpg"
            ),
            new Planeta (
                Nombre: "Marte",
                NombreLatin: "Mars",
                Tipo: "Terrestre",
                CaracteristicasFisicas: new CaracteristicasFisicas(
                    Masa: "6.42e23",
                    Diametro: 6779,
                    Gravedad: 3.71,
                    Densidad: 3933,
                    DuracionDia: 24.6,
                    NumeroLunas: 2
                ),
                DatosOrbitales: new DatosOrbitales(
                    DistanciaMediaSol: "227.9e6 km (1.52 UA)",
                    PeriodoOrbital: 687,
                    VelocidadOrbital: 24.1
                ),
                Atmosfera: new Atmosfera(
                    Composicion: "95% CO2, 2.7% N2, 1.6% Ar",
                    TemperaturaMedia: -63
                ),
                Lunas: new List<string>{ "Fobos", "Deimos" },
                Imagen: "https://upload.wikimedia.org/wikipedia/commons/0/02/OSIRIS_Mars_true_color.jpg"
            ),
            new Planeta (
                Nombre: "Júpiter",
                NombreLatin: "Iuppiter",
                Tipo: "Gigante gaseoso",
                CaracteristicasFisicas: new CaracteristicasFisicas(
                    Masa: "1.90e27",
                    Diametro: 139820,
                    Gravedad: 24.79,
                    Densidad: 1326,
                    DuracionDia: 9.9,
                    NumeroLunas: 95
                ),
                DatosOrbitales: new DatosOrbitales(
                    DistanciaMediaSol: "778.5e6 km (5.20 UA)",
                    PeriodoOrbital: 4333,
                    VelocidadOrbital: 13.1
                ),
                Atmosfera: new Atmosfera(
                    Composicion: "90% H2, 10% He",
                    TemperaturaMedia: -110
                ),
                Lunas: new List<string>{ "Ío", "Europa", "Ganimedes", "Calisto" },
                Imagen: "https://upload.wikimedia.org/wikipedia/commons/e/e2/Jupiter.jpg"
            ),
            new Planeta (
                Nombre: "Saturno",
                NombreLatin: "Saturnus",
                Tipo: "Gigante gaseoso",
                CaracteristicasFisicas: new CaracteristicasFisicas(
                    Masa: "5.68e26",
                    Diametro: 116460,
                    Gravedad: 10.44,
                    Densidad: 687,
                    DuracionDia: 10.7,
                    NumeroLunas: 146
                ),
                DatosOrbitales: new DatosOrbitales(
                    DistanciaMediaSol: "1.43e9 km (9.58 UA)",
                    PeriodoOrbital: 10759,
                    VelocidadOrbital: 9.7
                ),
                Atmosfera: new Atmosfera(
                    Composicion: "96% H2, 3% He",
                    TemperaturaMedia: -140
                ),
                Lunas: new List<string>{ "Titán", "Encélado", "Rea", "Japeto" },
                Imagen: "https://upload.wikimedia.org/wikipedia/commons/c/c7/Saturn_during_Equinox.jpg"
            ),
            new Planeta (
                Nombre: "Urano",
                NombreLatin: "Uranus",
                Tipo: "Gigante helado",
                CaracteristicasFisicas: new CaracteristicasFisicas(
                    Masa: "8.68e25",
                    Diametro: 50724,
                    Gravedad: 8.87,
                    Densidad: 1270,
                    DuracionDia: 17.2,
                    NumeroLunas: 27
                ),
                DatosOrbitales: new DatosOrbitales(
                    DistanciaMediaSol: "2.87e9 km (19.2 UA)",
                    PeriodoOrbital: 30687,
                    VelocidadOrbital: 6.8
                ),
                Atmosfera: new Atmosfera(
                    Composicion: "83% H2, 15% He, 2% CH4",
                    TemperaturaMedia: -195
                ),
                Lunas: new List<string>{ "Titania", "Oberón", "Umbriel", "Ariel", "Miranda" },
                Imagen: "https://upload.wikimedia.org/wikipedia/commons/3/3d/Uranus2.jpg"
            ),
            new Planeta (
                Nombre: "Neptuno",
                NombreLatin: "Neptunus",
                Tipo: "Gigante helado",
                CaracteristicasFisicas: new CaracteristicasFisicas(
                    Masa: "1.02e26",
                    Diametro: 49244,
                    Gravedad: 11.15,
                    Densidad: 1638,
                    DuracionDia: 16.1,
                    NumeroLunas: 14
                ),
                DatosOrbitales: new DatosOrbitales(
                    DistanciaMediaSol: "4.50e9 km (30.1 UA)",
                    PeriodoOrbital: 60190,
                    VelocidadOrbital: 5.4
                ),
                Atmosfera: new Atmosfera(
                    Composicion: "80% H2, 19% He, 1.5% CH4",
                    TemperaturaMedia: -200
                ),
                Lunas: new List<string>{ "Tritón", "Nereida", "Proteo", "Larisa" },
                Imagen: "https://upload.wikimedia.org/wikipedia/commons/5/56/Neptune_Full.jpg"
            )
        };


        // Método público para acceder a los planetas
        public static List<Planeta> GetPlanetas() => _planetas;

        public static List<Planeta> GetPlanetasPorTipo(string tipo)
        {
            string normalizado = tipo.Replace("-", " ").Trim();
            return _planetas.Where(p => p.Tipo.Equals(normalizado, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public static List<Planeta> GetPlanetasPorLunas(int lunas)
        {
            return _planetas.Where(p => p.CaracteristicasFisicas.NumeroLunas > lunas).ToList();
        }

        public static Planeta GetPlaneta(string nombre)
        {
            return _planetas.FirstOrDefault(p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
        }
        public static Planeta GetPlanetaLatin(string nombreLatin)
        {
            return  _planetas.FirstOrDefault(p => p.NombreLatin.Equals(nombreLatin, StringComparison.OrdinalIgnoreCase));
        }


    }
}