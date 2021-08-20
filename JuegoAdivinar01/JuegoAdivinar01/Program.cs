using System;

namespace JuegoAdivinar01
{
    class Program
    {
        static void Main(string[] args)
        {
            int milisec = DateTime.Now.Millisecond;
            int dado;
            
            dado = (milisec % 6) + 1;


            Console.WriteLine("El numero del dado es: {0}",dado);
            
            //Ejercicio Propuesto #1
            
            int mili = DateTime.Now.Millisecond;
            int numero;
            numero = (mili % 10) + 1;

            Console.WriteLine("Numero del 1 al 10 es: {0} ", numero);

            //Ejercicio Propuesto #2
            int segundoNum = DateTime.Now.Millisecond;
            int num2; 
            num2 = (segundoNum % 10) + 11;

            Console.WriteLine("El número del 11 al 20 es: {0}", num2);

            //Juego Adivinanza ejemplo 
            Random r = new Random();
            int aleatorio = r.Next(1, 7);
            Console.WriteLine("Indica el número que creas: ");
            int numLeer = Convert.ToInt32 (Console.ReadLine());

            if(numLeer == aleatorio)
            {
                Console.WriteLine("¡Has acertado!");

            }
            else
            {
               if (numLeer < aleatorio)
                {
                    Console.WriteLine("Prueba un número más alto."); 
                }
               if (numLeer > aleatorio)
                {
                    Console.WriteLine("Prueba un número más bajo.");
                }

                Console.WriteLine("Indica el nuevo número:");
                numLeer = Convert.ToInt32(Console.ReadLine()); 

                if(numLeer == aleatorio)
                {
                    Console.WriteLine("¡Has acertado!");

                }
                else
                {
                    // Segundo intento
                    Console.WriteLine("Prueba una vez más.");
                    numLeer = Convert.ToInt32(Console.ReadLine());

                    // tercer intento
                    if(numLeer == aleatorio)
                    {
                        Console.WriteLine("Por fin acertaste.");
                    }else
                    {
                        Console.WriteLine("El numero aleatorio era {0}", aleatorio);
                    }

                }
            }

            //Juego del 1 al 100

            Random generador = new Random();
            int tries = 10;
            int numeroLectura, randoCien;

            randoCien = generador.Next(1, 101);
            
            Console.WriteLine("Te quedan {0} intentos.", tries);
            Console.Write("Ingresa el número a adivinar: ");
            numeroLectura = Convert.ToInt32(Console.ReadLine());

            //Bucle que se repite hasta que se averigua el numero
            while((numeroLectura != randoCien) && (tries > 1))
            {
                tries -= 1;

                if(numeroLectura < randoCien)
                {
                    Console.WriteLine("Te quedaste corto.");

                }if(numeroLectura > randoCien)
                {
                    Console.WriteLine("Te has pasado.");

                }

                Console.WriteLine("Te quedan {0}", tries);
                Console.Write("Ingresa el número a adivinar.");
                numeroLectura = Convert.ToInt32(Console.ReadLine());
                if (numeroLectura == randoCien)
                {
                    Console.WriteLine("Has ganado!");
                }
                else
                {
                    Console.WriteLine("Perdiste.");
                    Console.WriteLine("Era el número {0} ", randoCien);
                }
            }

            //Juego para averiguar entre 1 y 10000

            int triesMil = 10;
            int numeroRead, randoMil;
            randoMil = generador.Next(1, 10001);

            Console.WriteLine("Te quedan {0} intentos.", triesMil);
            Console.Write("Ingresa el número a adivinar: ");
            numeroRead = Convert.ToInt32(Console.ReadLine());

            while ((numeroRead != randoMil) && (triesMil > 1))
            {
                tries -= 1;

                if (numeroRead < randoMil)
                {
                    Console.WriteLine("Te quedaste corto.");

                }
                if (numeroRead > randoMil)
                {
                    Console.WriteLine("Te has pasado.");

                }

                Console.WriteLine("Te quedan {0}", triesMil);
                Console.Write("Ingresa el número a adivinar.");
                numeroRead = Convert.ToInt32(Console.ReadLine());
                if (numeroRead == randoMil)
                {
                    Console.WriteLine("Has ganado!");
                }
                else
                {
                    Console.WriteLine("Perdiste.");
                    Console.WriteLine("Era el número {0} ", randoMil);
                }
            }
        }

    }
    }
