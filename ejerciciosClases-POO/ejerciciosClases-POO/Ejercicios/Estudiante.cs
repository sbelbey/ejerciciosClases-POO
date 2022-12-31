using System;
using System.Collections.Generic;

namespace ejerciciosClases_POO.Ejercicios
{
    public class Estudiante : Persona
    {
        public List<Libro> Libros = new List<Libro>();

        public Estudiante(string nombre, string apellido, Smartphone smartphone) : base(nombre, apellido, smartphone)
        {
        }

        public void AgregarLibro(Libro libro)
        {
            Libros.Add(libro);
        }

        public void QuitarLibro (Libro libro)
        {
            Libros.Remove(libro);
        }

        public void LibrosXLeer()
        {
            int count = Libros.Count(libro => !libro.WasRead);
            Console.WriteLine("Los libros sin leer son: " + count);
        }

        public void LibrosLeidos()
        {
            List<Libro> librosLeidos = Libros.FindAll(libro => libro.WasRead);
            foreach(Libro libro in librosLeidos)
            {
                Console.WriteLine(libro.GetNombreAutor());
            }
        }

        public void PaginasLeidas()
        {
            int suma = 0;
            Libros.ForEach(libro =>
                { if (libro.WasRead)
                    {
                        suma += libro.CantPag;
                    }
                });
            Console.WriteLine("La cantidad de páginas leidas son: " + suma);
        }
    }
}

