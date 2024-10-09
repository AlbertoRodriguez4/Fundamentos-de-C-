
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
    //Función para modificar la calificación de una asignatura de un estudiante
    public void modificarNotaAlumno(Asignatura asignatura, double calificacion)
    {
        bool asignaturaEncontrada = false;

        // Recorremos las calificaciones para buscar la asignatura
        foreach (var entrada in calificaciones)
        {
            if (entrada.Key.Nombre.Equals(asignatura.Nombre))
            {
                Console.WriteLine("Calificación modificada de la asignatura " + entrada.Key.Nombre + " al alumno " + Nombre + ". Se le ha sustituido la nota de " + calificaciones[asignatura] + " por " + calificacion);
                calificaciones[asignatura] = calificacion;
                asignaturaEncontrada = true;
                break;
            }
        }
        if (!asignaturaEncontrada)
        {
            Console.WriteLine("Asignatura no encontrada");
        }
    }
}