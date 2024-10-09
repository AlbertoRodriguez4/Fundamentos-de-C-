


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
    public double CalcularPromedioGlobal() {
        double sumaPromedios = 0;
        int contadorEstudiantes = 0;
    foreach (var estudiante in estudiantes) {
        sumaPromedios += estudiante.CalcularPromedio();
        contadorEstudiantes++;
    }
        return sumaPromedios / contadorEstudiantes;
    }
}