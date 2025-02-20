using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Asignatura : Alumno, IAsignatura
    {

        public int N1 { get; set; }
        public int N2 { get; set; }
        public int N3 { get; set; }
        public string? NombreAsignatura { get; set; }
        public string? Horario { get; set; }
        public string? NombreDocente { get; set; }

        public double CalcularNotaFinal() {
            return N1 + N2 + N3;
        }

        public double CalcularNotaFinal(int N1, int N2, int N3)
        {
            return N1 + N2 + N3;
        }
        public string MensajeNotaFinal(double notaFinal){
            if (notaFinal < 60) {
                return "Reprobado";
            }
            if(notaFinal < 80)
            {
                return "Bueno";
            }
            if (notaFinal < 90) {
                return "Muy bueno";
            }
            else
            {
                return "Sobresaliente";
            }
        }

        public void Imprimir() {

           
            double notaFinal2 = CalcularNotaFinal(N1,N2,N3);

            Console.WriteLine($"Nombre Estudiante: {NombreAlumno}");
            Console.WriteLine($"Numero de Cuenta: {NumeroCuenta}");
            Console.WriteLine($"Correo Electronico: {Email}");
            Console.WriteLine($"Nombre de la Clase: {NombreAsignatura}");
            Console.WriteLine($"Horarios : {Horario}");
            Console.WriteLine($"Nombre del Docente: {NombreDocente}");
            Console.WriteLine($"Nota Final : {CalcularNotaFinal()}");
            Console.WriteLine($"Nota Final(n1,n2,n3): {CalcularNotaFinal(N1,N2,N3)}");


        }
      
    }
}