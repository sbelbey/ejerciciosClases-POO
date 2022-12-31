using System;
using System.Xml.Linq;

namespace ejerciciosClases_POO.Ejercicios
{
	public class Persona
	{

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public Smartphone PersonPhone { get; set; }

        public Persona (string nombre, string apellido, Smartphone smartphone)
        {
            Nombre = nombre;
            Apellido = apellido;
            PersonPhone = smartphone;
        }

        public string NombreCompleto => "Persona: " + Nombre + " " + Apellido;

        public int CalcEdad()
        {
            DateTime hoy = DateTime.Today;
            int edad = hoy.Year - FechaDeNacimiento.Year;

            if (hoy < FechaDeNacimiento.AddYears(edad))
            {
                edad--;
            }
            return edad;
        }

        public string Cellphone() => PersonPhone.ToString();
    }
}

