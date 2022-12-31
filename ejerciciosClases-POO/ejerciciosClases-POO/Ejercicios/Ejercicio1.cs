using System;
namespace ejerciciosClases_POO.Ejercicios
{
	public class Ejercicio1
	{
		        
        public void EsMayorA100(int num)
        {
            if (num > 100)
            {
                Console.WriteLine("El valor es mayor que 100");
            }
        }

        public void ParOImpar(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("Su número es par");
            }
            else
            {
                Console.WriteLine("Su número es impar.");
            }
        }

        public void DobleDeImpar (int num)
        {
            int numDoble = 0;

            for (var i = num; i > 0; i--)
            {
                if (i * 2 == num && i % 2 != 0)
                {
                    numDoble = i;
                }
            }

            if (numDoble > 0)
            {
                Console.WriteLine("El numero ingresado es el doble del impar: " + numDoble);
            }
            else
            {
                Console.WriteLine("El numero ingresado no es el doble de ningún impar.");
            }
        }

        public void VersionRomana (int num)
        {
            switch (num)
            {
                case 1:
                    Console.WriteLine("I");
                    break;
                case 2:
                    Console.WriteLine("I");
                    break;
                case 3:
                    Console.WriteLine("III");
                    break;
                case 4:
                    Console.WriteLine("IV");
                    break;
                case 5:
                    Console.WriteLine("V");
                    break;
                case 6:
                    Console.WriteLine("VI");
                    break;
                case 7:
                    Console.WriteLine("VII");
                    break;
                case 8:
                    Console.WriteLine("VIII");
                    break;
                case 9:
                    Console.WriteLine("IX");
                    break;
                case 10:
                    Console.WriteLine("X");
                    break;
                default:
                    Console.WriteLine("Debió ingresar un valor del 1 al 10.");
                    break;
            }
        }

        public string QuienEsMenor(string person1, string person2, int edad1, int edad2)
        {
            int dif = 0;

            if (edad1 > edad2)
            {
                dif = edad1 - edad2;
                return person1 + " es " + dif + " años mayor que " + person2;
            }
            else if (edad2 > edad1)
            {
                dif = edad2 - edad1;
                return person2 + " es " + dif + " año/s mayor que " + person1;
            }
            else
            {
                return person1 + " y " + person2 + " tienen la misma edad.";
            }
        }

        public void TipoTriangulo (int long1, int long2, int long3)
        {
            if (long1 == long2 && long1 == long3)
            {
                Console.WriteLine("El triangulo es equilátero");
            }else if (long1 != long2 && long1 != long3 && long2 != long3)
            {
                Console.WriteLine("El triangulo es escaleno");
            }else
            {
                Console.WriteLine("El triangulo es equilátero");
            }

            Console.WriteLine("El peímetro del triangulo es: " + (long1 + long2 + long3));

            int p = (long1 + long2 + long3) / 2;
            double area = Math.Sqrt(p * (p - long1) * (p - long2) * (p - long3));
            Console.WriteLine("El área del triángulo es: " + area);

        }

        public string DesgloceBilletes(double valor)
        {
            string mensaje = "";

            double mil = Math.Floor(valor / 1000);
            valor %= 1000;
            double quinientos = Math.Floor(valor / 500);
            valor %= 500;
            double cien = Math.Floor(valor / 100);
            valor %= 100;
            double cincuenta = Math.Floor(valor / 50);
            valor %= 50;
            double veinte = Math.Floor(valor / 20);
            valor %= 20;
            double diez = Math.Floor(valor / 10);
            valor %= 10;
            double cinco = Math.Floor(valor / 5);
            valor %= 5;
            double dos = Math.Floor(valor / 2);
            double uno = valor % 2;

            if (mil > 0)
            {
                mensaje += mil + " billetes de $1000, ";
            }
            if (quinientos > 0)
            {
                mensaje += quinientos + " billetes de $500,";
            }
            if (cien > 0)
            {
                mensaje += cien + " billetes de $100, ";
            }
            if (cincuenta > 0)
            {
                mensaje += cincuenta + " billetes de $50, ";
            }
            if (veinte > 0)
            {
                mensaje += veinte + " billetes de $20, ";
            }
            if (diez > 0)
            {
                mensaje += diez + " billetes de $10, ";
            }
            if (cinco > 0)
            {
                mensaje += cinco + " monedas de $5, ";
            }
            if (dos > 0)
            {
                mensaje += dos + " monedas de $2, ";
            }
            if (uno > 0)
            {
                mensaje += uno + " monedas de $1.";
            }

            return mensaje;
        }

        public void ListaNumeros(int valor)
        {
            for (var i = 1; i <= valor; i++)
            {
                Console.WriteLine(i);
            }
        }

        public string SumarNumeros()
        {
            int suma = 0;
            for (var i = 1; i <= 15; i++)
            {
                Console.WriteLine("Ingrese el numero que desea sumar: ");
                int valor = int.Parse(Console.ReadLine());
                suma += valor;
            }
            return "El resultado de la suma es: " + suma;
        }

        public void MultiploDe3()
        {
            for (var i = 1; i <= 5; i++)
            {
                Console.WriteLine("Ingrese el numero que desea: ");
                int valor = int.Parse(Console.ReadLine());
                if (valor % 3 == 0)
                {
                    Console.WriteLine("El numero ingresado es multipo de 3");
                }
                else
                {
                    Console.WriteLine("El numero ingresado es no multipo de 3");
                }
            }
        }
        
        public string ValidadorContraseña()
        {
            while (true)
            {
                Console.WriteLine("Ingrese la primera contraseña");
                string pass1 = Console.ReadLine();
                Console.WriteLine("Ingrese la segunda contraseña");
                string pass2 = Console.ReadLine();
                if (pass1 == pass2)
                {
                    return "Bien hecho!";

                }
                Console.WriteLine("Contraseña mal ingresada, vuelva a intentarlo");
            }
        }

        public string ValidadorContraseña2()
        {
            int cont = 0;
            while (cont < 3)
            {
                Console.WriteLine("Ingrese la primera contraseña");
                string pass1 = Console.ReadLine();
                Console.WriteLine("Ingrese la segunda contraseña");
                string pass2 = Console.ReadLine();
                if (pass1 == pass2)
                {
                    return "Bien hecho!";
                }
                Console.WriteLine("Contraseña mal ingresada, vuelva a intentarlo");
                cont++;
            }
            return "Lo siento. Ha agotado todas sus chances.";

        }

        public string AdivinaNumero()
        {
            int numero = 7342;

            Console.WriteLine("Ingrese el numero segun su pápito");
            int valor = int.Parse(Console.ReadLine());

            if (numero == valor)
            {
                return "Ganas te la Quiniela!";
            }
            else
            {
                return "Mejor suerte la próxima";
            }
        }

        public string AdivinaMayorMenor()
        {
            int numero = 7342;

            int valor = 0;

            do
            {
                Console.WriteLine("Ingrese el numero segun su pápito");
                valor = int.Parse(Console.ReadLine());
                if (numero < valor)
                {
                    Console.WriteLine("Intenta con un numero menor");
                }
                else if (numero > valor)
                {
                    Console.WriteLine("Intenta con un numero mayor");
                }
            } while (numero != valor);

            return "Ganas te la Quiniela!";
        }

        public string SumaInfinita()
        {
            string numero;

            int cont = 0;
            do
            {
                Console.WriteLine("Ingrese el numero a sumar");
                numero = Console.ReadLine();
                if (numero == "fin")
                {
                    break;
                }
                cont += int.Parse(numero);
            } while (true);

            return "La suma total es: " + cont;
        }

    }
}

