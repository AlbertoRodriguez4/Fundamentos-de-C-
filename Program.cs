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
Asignatura ingles = new Asignatura("Ingles", 4);
//Crear estudiantes
Estudiante estudiante1 = new Estudiante("Estudiante 1");
Estudiante estudiante2 = new Estudiante("Estudiante 2");
Estudiante estudiante3 = new Estudiante("Estudiante 3");
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
estudiante3.AñadirCalificacion(ingles, 10);
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
//modificar asignatura
Console.WriteLine($"\n---Modificando nota al alumno---");
estudiante1.modificarNotaAlumno(cliente, 9); //modificando la nota de una asignatura que el alumno cursa
estudiante1.modificarNotaAlumno(ingles, 1); //modificando la nota de una asignatura que el alumno no cursa
//eliminar a un estudiuante
Console.WriteLine($"\n---Eliminando a un alumno---");
programa.EliminarEstudiante("Estudiante 1"); //eliminando a un estudiante que existe
programa.EliminarEstudiante("Paco"); //eliminando a un estudiante que no existe
//buscar a uno o varios estudiantes
Console.WriteLine($"\n---Buscando a uno o varios estudiantes---");
programa.buscarEstudiantes("Est"); //Aparecen varios estudiantes
programa.buscarEstudiantes("Estudiante 2"); //Aparece solo un estudiante
programa.buscarEstudiantes("Asdf"); //No aparecen estudiantes