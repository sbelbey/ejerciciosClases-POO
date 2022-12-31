using System;
namespace ejerciciosClases_POO.Ejercicios
{
	public class Smartphone
	{
		public string Marca {get; set;}
		public string Modelo { get; set; }
		private Boolean Encendido { get; set; }
        private Boolean Silencio { get; set; }
        private int Volumen { get; set; }
        private int Brillo { get; set; }


        public Smartphone(string marca, string modelo)
		{
			Marca = marca;
			Modelo = modelo;
		}

		public void Encender()
		{
			if (!Encendido)
			{
				Console.WriteLine("Has encendido el Smartphone");
                Encendido = true;
			}else
			{
				Console.WriteLine("El smartphone ya se encuentra encendido");
            }
		}


        public void Apagar()
        {
            if (!Encendido)
            {
                Console.WriteLine("El smartphone ya se encuentra apagado");
            }
            else
            {
                Console.WriteLine("Has apagado el Smartphone");
                Encendido = false;
            }
        }

        public void SubirVolumen()
		{
            if (Encendido && Volumen < 100)
            {
                Volumen++;
                Console.WriteLine("El volumen del smartphone es ahora de " + Volumen + ".");
            }
            else
            {
                Console.WriteLine("No se puede subir más el volumen.");
            }
        }

		public void BajarVolumen()
		{
            if (Encendido && Volumen > 0)
            {
                Volumen--;
                Console.WriteLine("El volumen del smartphone es ahora de " + Volumen + ".");
            }
            else
            {
                Console.WriteLine("No se puede bajar más el volumen.");
            }
        }

        public void Silenciar()
        {
            if (!Silencio)
            {
                Silencio = true;
                Console.WriteLine("El smartphone está ahora en silenciado.");
            }
            else
            {
                Silencio = false;
                Console.WriteLine("Se ha quitado el silenciado al smartphone y su volumen es: " + Volumen);
            }
        }

        public void SubirBrillo()
        {
            if (Encendido && Brillo < 100)
            {
                Brillo++;
                Console.WriteLine("El brillo del smartphone es ahora de " + Brillo + ".");
            }
            else
            {
                Console.WriteLine("No se puede subir más el brillo.");
            }
        }

        public void BajarBrillo()
        {
            if (Encendido && Brillo > 0)
            {
                Brillo--;
                Console.WriteLine("El brillo del smartphone es ahora de " + Brillo + ".");
            }
            else
            {
                Console.WriteLine("No se puede bajar más el brillo.");
            }
        }
        
        public override string ToString()
        {
            return "Marca: " + Marca + " modelo: " + Modelo;
        }

    }
}

