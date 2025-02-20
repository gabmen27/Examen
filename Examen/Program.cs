
using Examen;

Asignatura asignatura = new Asignatura();


Console.WriteLine("Ingrese el nombre del Alumno: ");
asignatura.NombreAlumno = Console.ReadLine();
Console.WriteLine("Ingrese Numero de cuenta : ");
asignatura.NumeroCuenta = Console.ReadLine();
Console.WriteLine("Ingrese el correo electronico: ");
asignatura.Email = Console.ReadLine();
Console.WriteLine("Ingrese el Nombre de la Asignatura: ");
asignatura.NombreAsignatura = Console.ReadLine();
Console.WriteLine("Ingrese los Horarios: ");
asignatura.Horario = Console.ReadLine();
Console.WriteLine("Ingrese el Nombre del ocente: ");
asignatura.NombreDocente = Console.ReadLine();

try
{
    Console.WriteLine("Ingrese la nota del primer parcial 0-30%");
    asignatura.N1 = Convert.ToInt32(Console.ReadLine());
    if (asignatura.N1 > 30)
    {
        throw new Exception("La nota no puede ser mayor a 30 puntos");
    }
    Console.WriteLine("Ingrese la nota del segundo parcial 0-30%");
    asignatura.N2 = Convert.ToInt32(Console.ReadLine());
    if (asignatura.N2 > 30)
    {
        throw new Exception("La nota no puede ser mayor a 30 puntos");
    }

    Console.WriteLine("Ingrese la nota del Tercer parcial <=40%");
    asignatura.N3 = Convert.ToInt32(Console.ReadLine());

    if (asignatura.N3 > 40)
    {
        throw new Exception("La nota no puede ser mayor a 30 puntos");
    }

}
catch (Exception ex) {
    Console.WriteLine($"Error: {ex.Message}");
}

Console.WriteLine("----------------------------------");
asignatura.Imprimir();