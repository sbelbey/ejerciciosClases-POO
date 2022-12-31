using System;
namespace ejerciciosClases_POO.Ejercicios
{
	public class Auto
	{
        private Mascota _mascotaTransportada;
        private int _capacidad;
        private int _sobreRegazo;

		public string Modelo { get; set; }
		public string Marca { get; set; }
		public string Color { get; set; }
        private bool MotorEncendido { get; set; }
        private double Velocidad { get; set; }
        private double Aceleracion { get; set; }
        public Persona Conductor { get; set; }
        private List<Persona> Pasajeros = new List<Persona>();


        private bool ConductorHabilitado()
        {
                return Conductor != null && Conductor.CalcEdad() >= 18;
        }

        public void EncederMotor()
		{
            if (ConductorHabilitado())
            {
                if (!MotorEncendido)
                {
                    MotorEncendido = true;
                    Console.WriteLine("El motor se ha encendido.");
                }
                else
                {
                    Console.WriteLine("El motor ya estaba encendido.");
                }
            }
            else
            {
                Console.WriteLine("No se puede encender el vehículo sin un conductor autorizado.");
            }
        }

		public void ApagarMotor()
		{
            if (MotorEncendido)
            {
                MotorEncendido = false;
                Aceleracion = 0;
                Velocidad = 0;
                Console.WriteLine("El motor se ha apagado.");
            }
            else
            {
                Console.WriteLine("El motor ya estaba apagado.");
            }
        }

        public void Acelerar()
        {
            if (MotorEncendido)
            {
                if (Velocidad == 0)
                {
                    Velocidad = 10;
                }
                else
                {
                    Aceleracion += 0.10;
                    Velocidad *= 1 + Aceleracion;
                }
                Console.WriteLine("La velocidad actual es: " + Velocidad);
            }
            else
            {
                Console.WriteLine("Debe encender el auto para acelerarlo");
            }
        }

        public void Frenar()
        {
            if (Velocidad == 0)
            {
                Console.WriteLine("El vehículo se encuentra detenido");
            }
            else
            {
                if (Velocidad < 1)
                {
                    Velocidad = 0;
                    Aceleracion = 0;
                    Console.WriteLine("Ha detenido completamente el vehículo");
                }
                else
                {
                    Velocidad *= 0.8;
                    Console.WriteLine("El vehículo ha frenado y su velocidad actual es: " + Velocidad);
                }
            }
        }

        public void VelocidadAct()
        {
            Console.WriteLine("La velocidad actual es de: " + Velocidad);
        }

        public void AceleracionActal()
        {
            Console.WriteLine("El índice de aceleración actual es de: " + Aceleracion * 100 + "%");
        }

        public void SetMascotaTransportada(Mascota mascota)
        {
            if (ConductorHabilitado() && (_capacidad > 0 || mascota.MascotaPequenha))
            {
                _mascotaTransportada = mascota;
                if (!_mascotaTransportada.MascotaPequenha)
                {
                    _capacidad--;
                }
                else
                {
                    MoverMascota();             
                }
            }
            else
            {
                Console.WriteLine("No se puede transportar la Mascota.");
            }

        }

        public void CapacidadVehiculo(int capcidad = 4) {
            _capacidad = capcidad -1;
        }

        public void SentarPasajero(Persona pasajero)
        {
            if (_capacidad > 0)
            {
                Pasajeros.Add(pasajero);
                _capacidad--;
            }
            else
            {
                Console.WriteLine("El Vehículo está lleno.");
            }
        }

        public void MoverMascota()
        {
            Random rnd = new Random();
            int numeroAleatorio = rnd.Next(0, Pasajeros.Count);
            _sobreRegazo = numeroAleatorio;
        }

        public void ScoobyDondeEstasTu()
        {
            Console.WriteLine("La Mascota está sentada sobre el regazo de: " + Pasajeros[_sobreRegazo].NombreCompleto);
        }

        public void ConstitucionVehiculo()
        {
            Console.WriteLine("El conductor es: " + Conductor.NombreCompleto);
            foreach(Persona persona in Pasajeros)
            {
                Console.WriteLine("Viajan estos pasajeros: " + persona.NombreCompleto);
            }
            ScoobyDondeEstasTu();
        }

        public void BajarPasajero(Persona persona)
        {
            if (Velocidad == 0)
            {
                if (persona == Conductor)
                {
                    ApagarMotor();
                    Conductor = null;
                }
                else
                {
                    Pasajeros.Remove(persona);
                }
            }
            else
            {
                Console.WriteLine("No se puede bajar a la persona porque el vehículo está en movimiento.");
            }
        }
	}
}

