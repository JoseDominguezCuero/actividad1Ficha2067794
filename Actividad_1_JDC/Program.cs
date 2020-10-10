﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1_JDC
{
    class Program
    {
        static void Main(string[] args)
        {
            //...Variables---//
            int limite = 1;
            int numero1;
            int contador = 0;
            int Actividades;
            int i = 0;
            string palabra;
            int decis = 0;

            //...Repetidor...//
            while (limite == 1)
            {
                Console.Clear();
                Console.WriteLine("                            SENA \n" +
                                  "            Aprendiz-Jose Dominguez Cuero ADSI (2067794) \n" +
                                  "\n" +
                                  " Actividad I\n");
                Console.WriteLine(" 1 -> Numero Par o Impar");
                Console.WriteLine(" 2 -> Tabla de Multiplicar 1 al 10");
                Console.WriteLine(" 3 -> Tabla de Multiplicar 2 al 9 del 1 al 11");
                Console.WriteLine(" 4 -> Numero Primo o No ");
                Console.WriteLine(" 5 -> Numeros en forma ascendientes");
                Console.WriteLine(" 6 -> Datos existentes Edad y Nombre");
                Console.WriteLine(" 7 -> Datos Edad y Nombre de Menor y Mayor ");
                Console.WriteLine(" 8 -> Palíndromo o No");
                Console.WriteLine(" 0 -> Salir \n");
                Console.WriteLine("      Por favor digite el numero de la actividad que desea conocer o 0 si desea salir. ");
                Console.WriteLine("\n        *----------------------------------------------------------------------*");
                Console.WriteLine("        | RECUERDE DAR UN ENTER AL FINAL DE CADA ACTIVIDAD PARA VOLVER AL MENU |");
                Console.WriteLine("        *----------------------------------------------------------------------*");

                Actividades = Convert.ToInt32(Console.ReadLine());

                //...Menu...//
                switch (Actividades)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("  Por favor digite un numero: ");
                        numero1 = Convert.ToInt32(Console.ReadLine());
                        if (numero1 % 2 == 0)
                        {
                            Console.WriteLine("\n           El numero " + numero1 + ", es un numero Par");
                            Console.WriteLine("\n     --------------------//--------------------\n");
                            Console.ReadLine();
                        }
                        else if (numero1 % 1 == 0)
                        {
                            Console.WriteLine("\n           El numero " + numero1 + ", es un numero Impar\n");
                            Console.WriteLine("\n     --------------------//--------------------\n");
                            Console.ReadLine();
                        }
                        break;
                    case 2:
                        Console.Clear();
                        int tabla;
                        int numeros;
                        Console.WriteLine("Por favor digite el numero de la tabla que desea conocer");
                        tabla = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("\n*   " + "Tabla del " + tabla + ": *\n"
                                         );
                        for (i = 1; i <= 10; i++)
                        {
                            numeros = tabla * i;
                            Console.WriteLine("*     " + tabla + "X" + i + "=" + numeros + "     *");
                        }
                        Console.WriteLine("\n     --------------------//--------------------\n");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        int numeroT;
                        Console.WriteLine("Tabla del multiplicar del 2 al 9 cada una del 1 al 10\n");
                        Console.Clear();
                        for (int p = 2; p <= 9; p++)
                        {
                            Console.WriteLine("\n*   " + "Tabla del " + p + ": *\n");
                            for (i = 1; i <= 10; i++)
                            {
                                numeroT = p * i;
                                Console.WriteLine("*     " + p + "X" + i + "=" + numeroT + "     *");
                            }
                        }
                        Console.WriteLine("\n     --------------------//--------------------\n");
                        Console.ReadLine();

                        break;
                    case 4:
                        Console.Clear();

                        Console.Write("Por favor digite un numero: ");
                        numero1 = Convert.ToInt32(Console.ReadLine());

                        if (numero1 == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("\n(" + numero1 + ") Es un numero primo");
                            Console.WriteLine("\n     --------------------//--------------------\n");
                            Console.ReadLine();
                            return;
                        }
                        for (int u = 1; u <= numero1; u++)
                        {
                            int numero2 = numero1 % u;

                            if (numero2 == 0)
                            {
                                contador = contador + 1;
                            }
                            if (contador > 2)
                            {
                                Console.Clear();
                                Console.WriteLine("\n(" + numero1 + ") NO es un numero primo");
                                Console.WriteLine("\n     --------------------//--------------------\n");
                                Console.ReadLine();
                                return;
                            }
                            if (numero1 == u && contador <= 2)
                            {
                                Console.Clear();
                                Console.WriteLine("\n(" + numero1 + ") Es un numero primo");
                                Console.WriteLine("\n     --------------------//--------------------\n");
                                Console.ReadLine();
                                return;
                            }
                        }
                        break;
                    case 5:
                        Console.Clear();
                        int[] edad_A = { 12, 50, 23, 10, 18, 35, 41, 85, 16, 45 };
                        Console.WriteLine("\n los vectores registrados son: \n");
                        Console.WriteLine("    Desordenados\n");
                        for (int z = 0; z <= 9; z++)
                        {
                            Console.WriteLine("        " + edad_A[z]);
                        }
                        int t = edad_A.Length;
                        for (int j = 1; j < t; j++)
                        {
                            for (int k = 0; k < t - j; k++)
                            {
                                if (edad_A[k] > edad_A[k + 1])
                                {
                                    int temp = edad_A[k];
                                    edad_A[k] = edad_A[k + 1];
                                    edad_A[k + 1] = temp;
                                }
                            }
                        }
                        Console.WriteLine("\n Los vectores de forma Ascendientes son: \n");
                        Console.WriteLine("     Ordenados\n");
                        for (int z = 0; z <= 9; z++)
                        {
                            Console.WriteLine("        " + edad_A[z]);
                        }
                        Console.WriteLine("\n     --------------------//--------------------\n");
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.Clear();
                        int[] edades = { 12, 50, 23, 10, 18, 35, 41, 85, 16, 45 };
                        string[] nombres = { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };
                        Console.Write("Escriba un nombre:  ");
                        palabra = Console.ReadLine();
                        for (i = 0; i < nombres.Length; i++)
                        {
                            if (palabra == nombres[i])
                            {
                                Console.WriteLine("\n     La edad correspondiente de " + palabra + " es " + edades[i]);
                                Console.WriteLine("\n     --------------------//--------------------\n");
                                Console.ReadLine();
                                decis = 1;
                                break;
                            }
                            else
                            {
                                decis = 0;
                            }
                        }
                        if (decis == 0)
                        {
                            Console.WriteLine("\n     El nombre " + palabra + " no existe en la base de datos");
                            Console.WriteLine("\n     --------------------//--------------------\n");
                            Console.ReadLine();
                        }
                        break;
                    case 7:
                        Console.Clear();
                        int[] edad = { 12, 50, 23, 10, 18, 35, 41, 85, 16, 45 };
                        string[] nomb = { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };
                        Console.WriteLine("\n los vectores registrados son: \n");
                        Console.WriteLine("      Nombre  |  Edad");
                        Console.WriteLine("      ----------------");
                        for (int z = 0; z <= 9; z++)
                        {
                            Console.WriteLine("      " + nomb[z] + " -->   " + edad[z]);
                        }
                        int H = edad.Length;
                        for (int j = 1; j < H; j++)
                        {
                            for (int k = 0; k < H - j; k++)
                            {
                                if (edad[k] > edad[k + 1])
                                {
                                    int temp = edad[k];
                                    string temp2 = nomb[k];
                                    edad[k] = edad[k + 1];
                                    nomb[k] = nomb[k + 1];
                                    edad[k + 1] = temp;
                                    nomb[k + 1] = temp2;
                                }
                            }
                        }
                        Console.WriteLine("\n Las edades y nombres ordenadas del menor al mayor son: \n");
                        Console.WriteLine("      Nombre  |  Edad");
                        Console.WriteLine("      ----------------");
                        for (int z = 0; z <= 9; z++)
                        {
                            Console.WriteLine("      " + nomb[z] + " -->   " + edad[z]);
                        }
                        Console.WriteLine("\n     --------------------//--------------------\n");
                        Console.ReadLine();
                        break;
                    case 8:
                        Console.Clear();
                        Console.Write("\n ingrese el palabra:  ");
                        String polin = (Console.ReadLine());
                        char[] poliArray = polin.ToCharArray();
                        String AlRevez = "";
                        for (int e = poliArray.Length - 1; e >= 0; e--)
                        {
                            AlRevez += poliArray[e];
                        }
                        if (polin == AlRevez)
                        {
                            Console.WriteLine("\n    la palabra " + polin + ", Es palindromo");
                            Console.WriteLine("\n     --------------------//--------------------\n");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("\n    la palabra " + polin + ", NO es palindromo");
                            Console.WriteLine("\n    Debido a que su inverso es: " + AlRevez);
                            Console.WriteLine("\n     --------------------//--------------------\n");
                            Console.ReadLine();
                        }
                        break;
                    case 0:
                        limite = 2;
                        Console.Clear();
                        Console.WriteLine("\n     Gracias por realizar este recorrido.\n" +
                            "\n     Presiona cualquier tecla para salir.");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
