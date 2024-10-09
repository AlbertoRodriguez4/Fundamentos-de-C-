


namespace Models;
class ProgramaEducativo
{
    private List<Estudiante> estudiantes;
    public ProgramaEducativo()
    {
        estudiantes = new List<Estudiante>();
    }
    public void AgregarEstudiante(Estudiante estudiante)
    {
        estudiantes.Add(estudiante);
        if (estudiantes.Exists(a => a.Nombre == estudiante.Nombre))
        {
            Console.WriteLine("El estudiante  " + estudiante.Nombre + " ya existe");
        }
        else
        {
            estudiantes.Add(estudiante);
            Console.WriteLine("El estudiante  " + estudiante.Nombre + " fue agregado");
        }
    }
    public void MostrarEstudiantes()
    {
        int x = 1;
        Console.WriteLine("\n---Lista de estudiantes--- ");
        foreach (var estudiante in estudiantes)
        {
            estudiante.MostrarDeatalles(x);
            x++;
        }
    }

    public Estudiante ObtenerEstudiante(Estudiante estudiante)
    {
        return estudiante;
    }

    //función para eliminar a un estudiante
    public void EliminarEstudiante(string estudiante)
    {
        bool estudianteEncontrado = false;
        foreach (var est in estudiantes)
        {
            if (est.Nombre == estudiante)
            {
                Console.WriteLine("El estudiante " + estudiante + " fue eliminado");
                estudiantes.Remove(est);
                estudianteEncontrado = true;
                break;
            }

        }
        if (!estudianteEncontrado)
        {
            Console.WriteLine("Estudiante no encontrado");
        }
    }
    //función para buscar uno o varios estudiantes
    public void buscarEstudiantes(String nombre)
    {
        bool estudianteEncontrados = false;

        foreach (var estudiante in estudiantes)
        {
            if (estudiante.Nombre.StartsWith(nombre))
            {
                Console.WriteLine("Se ha encontrado al o los estudiante/s: " + estudiante.Nombre);
                estudianteEncontrados = true;
            }
        }
        if (!estudianteEncontrados)
        {
            Console.WriteLine("No se ha encontrado al o los estudiante/s");
        }
    }
    //función para calcular el promedio global de todos los estudiantes y sus asignaturas
    public double CalcularPromedioGlobal()
    {
        double sumaPromedios = 0;
        int contadorEstudiantes = 0;
        foreach (var estudiante in estudiantes)
        {
            sumaPromedios += estudiante.CalcularPromedio();
            contadorEstudiantes++;
        }
        return sumaPromedios / contadorEstudiantes;
    }
}
