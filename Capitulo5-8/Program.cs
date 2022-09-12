using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capitulo5_8{
class Program{
    static void Main(string[] args){

         int operador = 0;

        Funciones ej = new Funciones(); // Llamando a las funciones de ejecucion 

        do{

            Console.Write("\n -----------MENU-----------\n\n");
            Console.Write("\n ---Selecciona una opcion:n ");
            Console.Write("\n 1) Capitulo #5 Ejercicio 4");
            Console.Write("\n 2) Capitulo #5 Ejercicio 5 ");
            Console.Write("\n 3) Capitulo #6 (Ejercicios 1, 3, 4 y 5");
            Console.Write("\n 4) Capitulo #7 Ejercicio 1");
            Console.Write("\n 5) Capitulo #8 Ejercicio 3");
            Console.Write("\n 6) Capitulo #8 Ejercicio 5");
            Console.Write("\n 7) Salir\n\n ");
                
            operador = Int16.Parse(Console.ReadLine());
            Console.Clear();

            switch(operador)
            {
                case 1:
                    Console.Clear();
                    ej.Capitulo5_E4();
                    Console.ReadKey(); 
                    Console.Clear();
                break;

                case 2:
                    Console.Clear();
                    ej.Capitulo5_E5();
                    Console.ReadKey();
                    Console.Clear();
                    break;

                    case 3:
                        Console.Clear();
                        ej.Capitulo6_E1_5();
                        Console.ReadKey();
                        Console.Clear();
                    break;

                    case 4:
                        Console.Clear();
                        ej.Capitulo7_E1();
                        Console.ReadKey();
                        Console.Clear();
                    break;

                    case 5: 
                        Console.Clear();
                        ej.Capitulo8_E3();
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 6:
                        Console.Clear();
                        ej.Capitulo8_E5();
                        Console.ReadKey();
                        Console.Clear();   
                    break;

                    case 7:
                        Console.Clear();
                        break;
                    }

               }while(operador != 7);
          }
      
        }
    }
