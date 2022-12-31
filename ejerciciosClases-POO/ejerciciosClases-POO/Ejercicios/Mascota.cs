using System;
namespace ejerciciosClases_POO.Ejercicios
{
	public class Mascota
	{
		public int Energia { get; set; }
		public string Nombre { get; set; }
		public string Tipo { get; set; }
		public bool MascotaPequenha { get; set; }

		public Mascota(string nombre, string tipo, bool pequeña)
		{
			Nombre = nombre;
			Tipo = tipo;
			MascotaPequenha = pequeña;
		}

		public void Alimentar()
		{
			if (Energia == 100)
			{
				Console.WriteLine(Nombre + " ya tiene toda su energía recargada.");
			}
			else
			{
                if (Energia + 30 >= 100)
				{
					Energia = 100;
				}
				else
				{
					Energia += 30;
				}
				Console.WriteLine("Has alimentado a " + Nombre + " y ahora su energía es de: " + Energia);
			}
		}

		public void Correr()
		{
			if (Energia <= 20)
			{
				Console.WriteLine(Nombre + " está con bajas energías para correr. Alimenta a tu mascota!");
			}
			else
			{
				Energia -= 10;
				Console.WriteLine(Nombre + " está corriendo ahora.");
			}
			Console.WriteLine("El nivel de energía de " + Nombre + " es de: " + Energia);
		}
	}
}

