using System;

namespace Contar_vocales
{
    class Program
    {
        //Hecho po Angie Paola Schumann Canjura 1201119  y Catherine Rosario López Vicente 1055816
        static void Main(string[] args)

        {
            bool salir = false;

            while (!salir)
            {

                try
                {

                    Console.WriteLine("1. Opción 1");
                    Console.WriteLine("2. Opción 2");
                    Console.WriteLine("3. Opción 3");
                    Console.WriteLine("4. Salir");
                    Console.WriteLine("Elige una de las opciones");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Has elegido la opción 1");
                            contador();
                            break;

                        case 2:
                            Console.WriteLine("Has elegido la opción 2");
                            factorial ();
                            break;
                        
                        case 3:
                            Console.WriteLine("Has elegido la opción 3");
                            break;
                            porciones(); 
                        case 4:
                            Console.WriteLine("Has elegido salir de la aplicación");
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Elige una opcion entre 1 y 4");
                            break;
                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            static void contador()
            {
                int j;
                char i;
                string palabra;
                int vocales = 0;


                Console.WriteLine("Ingrese una palabra");
                palabra = Console.ReadLine();

                for (j = 0; j < palabra.Length; j++)
                {
                    i = palabra[j];
                    int c = char.ToLower(i);
                    if ((c == 'a') | (c == 'e') | (c == 'i') | (c == 'o') | (c == 'u'))
                        vocales++;

                }
                Console.WriteLine();
                Console.WriteLine("la palabra tiene:" + vocales + "vocales");
            }

            static int factorial()
            {
               
                int fact, numero, suma = 0;
                int[] vec = new int[10];

                Console.WriteLine("Ingrese el número: ");
                numero = int.Parse(Console.ReadLine());
                 
                if (numero != 0)
                {
                    return numero * factorial(numero - 1);

                }
                else
                {

                    return 1;
                }

                for (int i = 0; i < 10; i++)
                {
                    fact = factorial(i);
                    suma = suma + fact;

                    if (suma > numero || suma == numero)
                    {
                        break;
                        vec[i] = fact;
                    }

                }
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(vec[i]);
                }
                Console.ReadKey();


            }
        }

        static void porciones (){


            int porcion, personas, unidadesT, unidadesPastel = 0;
            Console.WriteLine("Ingrese el número de personas: ");
            personas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de porciones: ");
            porcion = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de pedazos por pastel: ");
            unidadesPastel = int.Parse(Console.ReadLine());

            unidadesT = (1 / unidadesPastel) * porcion * personas;
            Console.WriteLine("El total de porciones serán: " + unidadesT);

            Console.ReadKey();

        }


    }
    }

