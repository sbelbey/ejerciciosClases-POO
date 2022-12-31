using System.Reflection;
using ejerciciosClases_POO.Ejercicios;

namespace ejerciciosClases_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio1 oEjercicio1 = new ();
            //Console.WriteLine(oEjercicio1.DesgloceBilletes(173));

            //Cuadrado oCuadrado = new();
            //oCuadrado.Lado = 4;
            //Console.WriteLine(oCuadrado.CalcArea());

            //Persona oPersona = new("Saul", "Belbey");
            //oPersona.FechaDeNacimiento = new DateTime(1988, 09, 12);
            //Console.WriteLine(oPersona.CalcEdad());

            //Auto elAuto = new Auto();
            //elAuto.Marca = "Peugeot";
            //elAuto.Modelo = "408";
            //elAuto.Color = "Blanco";
            //elAuto.EncederMotor();
            //elAuto.EncederMotor();

            //Mascota simona = new Mascota("Simona", "Perro");
            //simona.Energia = 43;
            //simona.Alimentar();
            //simona.Correr();
            //simona.Correr();
            //simona.Correr();
            //simona.Correr();
            //simona.Alimentar();

            //Smartphone iphone = new("Apple", "Iphone 11 Pro Max");
            //iphone.Apagar();
            //iphone.BajarBrillo();
            //iphone.Encender();
            //iphone.SubirBrillo();
            //iphone.SubirBrillo();
            //iphone.SubirBrillo();
            //iphone.SubirBrillo();
            //iphone.BajarBrillo();
            //iphone.SubirVolumen();
            //iphone.SubirVolumen();
            //iphone.Silenciar();
            //iphone.Silenciar();
            //iphone.SubirVolumen();
            //iphone.SubirVolumen();
            //iphone.BajarVolumen();
            //iphone.Apagar();

            //Smartphone iphone = new("Apple", "Iphone 11 Pro Max");
            //Persona oPersona = new("Saul", "Belbey", iphone);
            //Console.WriteLine(oPersona.Cellphone());

            //Smartphone iphone = new("Apple", "Iphone 11 Pro Max");
            //Persona oPersona = new("Saul", "Belbey", iphone);
            //oPersona.FechaDeNacimiento = new DateTime(2008, 09, 12);
            //Auto elAuto = new Auto();
            //elAuto.Marca = "Peugeot";
            //elAuto.Modelo = "408";
            //elAuto.Color = "Blanco";
            //elAuto.Conductor = oPersona;
            //Console.WriteLine(elAuto.Conductor.NombreCompleto);
            //elAuto.EncederMotor();


            Smartphone iphone = new("Apple", "Iphone 11 Pro Max");
            Persona oPersona1 = new("Saul", "Belbey", iphone);
            Persona oPersona2 = new("Lisa", "Simpson", iphone);
            Persona oPersona3 = new("Marge", "Bubbie", iphone);
            Persona oPersona4 = new("Homero", "Simpson", iphone);
            Persona oPersona5 = new("Bart", "Simpson", iphone);
            Auto elAuto = new Auto();
            Mascota laMascota = new Mascota("Simona", "Perro", true);
            oPersona1.FechaDeNacimiento = new DateTime(1988, 09, 12);
            elAuto.CapacidadVehiculo(5);
            elAuto.Marca = "Peugeot";
            elAuto.Modelo = "408";
            elAuto.Color = "Blanco";
            elAuto.Conductor = oPersona1;
            elAuto.SentarPasajero(oPersona2);
            elAuto.SentarPasajero(oPersona3);
            elAuto.SentarPasajero(oPersona4);
            elAuto.SentarPasajero(oPersona5);
            elAuto.SetMascotaTransportada(laMascota);
            //elAuto.ScoobyDondeEstasTu();
            //elAuto.MoverMascota();
            //elAuto.ScoobyDondeEstasTu();

            elAuto.BajarPasajero(oPersona1);



        }
    }
}
