
namespace Models;

class Estudiante
{
    public string Nombre { get; set; }
    public Dictionary<Asignatura, double> calificaciones;
    public Estudiante(string nombre)
    {
        Nombre = nombre;
        calificaciones = new Dictionary<Asignatura, double>();
    }

    public void AñadirCalificacion(Asignatura asignatura, double calificacion)
    {
        calificaciones[asignatura] = calificacion;
    }
    public void MostrarCalificaciones()
    {
        Console.WriteLine($"\n---Calificaciones de {Nombre}---");
        foreach (var entrada in calificaciones)
        {
            Console.WriteLine($"{entrada.Key.Nombre}: {entrada.Value:F2}");
        }
    }
    public double CalcularPromedio()
    {
        double suma = 0;
        foreach (var entrada in calificaciones)
        {
            suma += entrada.Value;
        }
        return suma / calificaciones.Count;
    }

    public void MostrarDeatalles(int x)
    {
        Console.WriteLine($"Estudiante número {x}: {Nombre}");
    }
}