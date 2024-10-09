using Models;

// Console.WriteLine("Hello, World!");

// var asignatura = new Asignatura("Servidor", 4);
// asignatura.MostrarDeatalles();
//Crear el programa
ProgramaEducativo programa = new ProgramaEducativo();
//Crear asignaturas
Asignatura servidor = new Asignatura("Servidor", 4);
Asignatura cliente = new Asignatura("Cliente", 4);
Asignatura diseño = new Asignatura("Diseño", 4);
//Crear estudiantes
Estudiante estudiante1 = new Estudiante("Estudiante 1");
Estudiante estudiante2 = new Estudiante("Estudiante 2");
Estudiante estudiante3 = new Estudiante("Estudiante 3");
Estudiante estudiante4 = new Estudiante("Estudiante 4");
Estudiante estudiante5 = new Estudiante("Estudiante 5");
//Añadir estudiantes al programa educativo
programa.AgregarEstudiante(estudiante1);
programa.AgregarEstudiante(estudiante2);
programa.AgregarEstudiante(estudiante3);
//agregar estudiantes al programa
estudiante1.AñadirCalificacion(servidor, 10);
estudiante1.AñadirCalificacion(cliente, 8);
estudiante1.AñadirCalificacion(diseño, 9);
estudiante2.AñadirCalificacion(servidor, 9);
estudiante2.AñadirCalificacion(cliente, 7);
estudiante2.AñadirCalificacion(diseño, 8);
estudiante3.AñadirCalificacion(servidor, 10);
estudiante3.AñadirCalificacion(cliente, 9);
//Mostrar estudiantes
programa.MostrarEstudiantes();
//Mostrar calificaciones de estudiantes en especifico
List<Estudiante> lstEstudiantes = new List<Estudiante>();
{
    lstEstudiantes.Add(estudiante1);
    lstEstudiantes.Add(estudiante2);
    lstEstudiantes.Add(estudiante3);
    
    foreach (var estudiante in lstEstudiantes)
    {
        estudiante.MostrarCalificaciones();
        double promedio = estudiante.CalcularPromedio();
        Console.WriteLine($"Promedio de {estudiante.Nombre}: {promedio:F2}");
    }
}
//promedio de estudiantes globales
double promedioGlobal = programa.CalcularPromedioGlobal();
Console.WriteLine($"\n---Promedio global---");
Console.WriteLine($"Promedio global: {promedioGlobal:F2}");
Console.WriteLine(34.40M);