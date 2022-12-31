using System;
namespace ejerciciosClases_POO.Ejercicios
{
	public class Libro
	{
		public string Nombre { get; set; }
        public Persona Autor { get; set; }
		public int CantPag { get; set; }
		public bool WasRead { get; set; }

		public string GetNombreAutor()
		{
			return Nombre + Autor.NombreCompleto;
		}
	}
}

