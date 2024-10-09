namespace Models;

class Asignatura
{
    public string Nombre { get; set; }
    public int Creditos { get; set; }
    public Asignatura(string nombre, int creditos)
    {
        Nombre = nombre;
        Creditos = creditos;
    }
    public void MostrarDeatalles()
    {
        Console.WriteLine($"Asignatura: {Nombre}, Creditos: {Creditos}");
    }
}