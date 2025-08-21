
Console.WriteLine("Hello, World!");

Personas persona = new Personas();
persona.id = 1;
persona.Nombre = "Pepito Perez";
persona.Estatura = 1.60m;
persona.Viva = false;
persona.Fecha = DateTime.Now;
persona.Estado = new Estados() { id = 1, Nombre = "Viudo" };
public class Estados
{
    public int id;
    public String? Nombre;

}

public class Personas
{
    public int id;
    public String? Nombre;
    public decimal Estatura;
    public bool Viva;
    public DateTime Fecha;
    public Estados? Estado;
}

public class Estudiantes : Personas
{
    public String? Carnet;
 }