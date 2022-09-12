using System;
using System.Collections;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Data;

namespace Capitulo5_8{
    
    class Funciones{

        // Funcion para calcular el factoria  de un número.
        public void Capitulo5_E4(){

            byte numero, i;
	        long result = 1;
		    string linea ="";

            Console.WriteLine("Ingrese un numero: ");
            linea = Console.ReadLine();
		    numero = byte.Parse(linea);
			for (i = 2; i <= numero; i++)
			{
				result = result * i;
			}
            Console.WriteLine("El factorial de {0} es {1}" , numero, result);
        }

         
       // Función que dado un número nos regrese una cadena donde se encuentre escrito en palabras.
        public void Capitulo5_E5(){
            Console.WriteLine("Ingrese un numero entre 0 y 99: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int decenas = (numero / 10);
            int unidades = (numero % 10);

            if (decenas == 0) Console.Write("");
                else if (decenas == 1) {
            if (unidades == 0) Console.Write("Diez");
            else if (unidades == 1) Console.Write("Once");
            else if (unidades == 2) Console.Write("Doce");
            else if (unidades == 3) Console.Write("Trece");
            else if (unidades == 4) Console.Write("Catorce");
            else if (unidades == 5) Console.Write("Quince");
            else Console.Write("Dieci");
       }

            else if (decenas == 2) {
            if (unidades == 0) Console.Write("Veinte");
            else Console.Write("Veinti");
       }

            else if (decenas == 3) Console.Write("Treinta");
            else if (decenas == 4) Console.Write("Cuarenta");
            else if (decenas == 5) Console.Write("Cincuenta");
            else if (decenas == 6) Console.Write("Secenta");
            else if (decenas == 7) Console.Write("Setenta");
            else if (decenas == 8) Console.Write("Ochenta");
            else if (decenas == 9) Console.Write("Noventa");

            if (unidades != 0 && decenas > 2)  Console.Write(" Y ");

            if (numero < 10 || numero > 15){

            if (unidades == 0){
                if(decenas != 0)Console.Write("");
            } 
            else if (unidades == 1) Console.Write("Uno");
            else if (unidades == 2) Console.Write("Dos");
            else if (unidades == 3) Console.Write("Tres");
            else if (unidades == 4) Console.Write("Cuatro");
            else if (unidades == 5) Console.Write("Cinco");
            else if (unidades == 6) Console.Write("Seis");
            else if (unidades == 7) Console.Write("Siete");
            else if (unidades == 8) Console.Write("Ocho");
            else if (unidades == 9) Console.Write("Nueve");
            }
        } 

     /* 1. Agregar el cálculo del promedio para el programa con arreglo jagged.
        2. Agregar el cálculo de la menor calificación para el programa con arreglo jagged.
        3. Agregar el cálculo de la mayor calificación para el programa con arreglo jagged.
        4. Modificar el programa de la escuela para que utilice funciones.
        5. Crear un programa que pase un arreglo jagged como parámetro a una función. 
          */
         public void Capitulo6_E1_5(){
                
               int cantidad = 0, salones = 0, n = 0, m = 0; 
               string valor = "";

               float suma = 0.0f;
               float promedio = 0.0f;
               float minima = 10.0f; 
               float maxima = 0.0f; 

          
               Console.WriteLine("Ingrese la cantidad de salones");
               valor = Console.ReadLine();
               salones = Convert.ToInt32(valor);
             
               float[][] calif = new float[salones][];
             
               for (n = 0; n < salones; n++) 
               {
                    Console.WriteLine($"ingrese la cantidad de alumno spara el salon {0}", n);
                    valor = Console.ReadLine();
                    cantidad = Convert.ToInt32(valor);
                
                    calif[n] = new float[cantidad];
               }

               for (n = 0; n < salones; n++)
               {
                    Console.WriteLine("\nSalon {0}", n);
                    for (m = 0; m < calif[n].GetLength(0); m++) 
                    {
                         Console.Write("Ingrese la calificación ");
                         valor = Console.ReadLine();
                         calif[n][m] = Convert.ToSingle(valor);

                         suma += calif[n][m];

                         if (calif[n][m] > maxima)

                              maxima = calif[n][m];

                         else if (calif[n][m] < minima)

                              minima = calif[n][m];
                    }

                    promedio = suma / calif[n].GetLength(0);
                    Console.WriteLine($"EL Promedio de Calificaciones es: {promedio}");

               }

               Infomacion(calif, salones, m, maxima, minima);

          }
         public static void Infomacion(float[][] calif, int salones, int m, float maxima, float minima)
          {

            Console.WriteLine("—— Información ——");
            for (int n = 0; n < salones; n++) 
            {
                Console.WriteLine("\nSalon {0}", n);
                for (m = 0; m < calif[n].GetLength(0); m++) 
                {
                    Console.WriteLine("El alumno {0} tiene {1}", m, calif[n][m]);
                }
                Console.Write($"\nLa mayor venta es: {maxima}");
                Console.Write($"\nLa menor venta es: {minima}");
            }
          }

          /*
            Hacer el programa que calcula el promedio, calificación máxima y mínima
            de un salón de clases usando el ArrayList.
            */
         public void Capitulo7_E1(){
     
            int sumatoria = 0;

            int[] calificaciones = new int[15];
            int v, max = calificaciones[0], min = calificaciones[0];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese las calificaciones: ");
                v = int.Parse(Console.ReadLine());
                calificaciones[i] = v;
            }

            foreach (int i in calificaciones)
            {
                sumatoria += i;
            }
            int promedio = sumatoria / calificaciones.Length;
            Console.WriteLine("Promedio: " + promedio);
            Console.Write("\n\nLa mayor venta es: " + calificaciones.Max());
            Console.Write("\n\nLa menor venta es: " + calificaciones.Min()+"\n\n");
        }

         /*
            Hacer un programa que funcione como un
            diccionario, con palabra y definición,
            usando el Hashtable.
          */ 
         public void Capitulo7_E2(){

        }

       /*
       hacer un programa que funcione como una agenda telefónica y que guarde el
       nombre de la persona y su número telefónico.
        */ 
         public void Capitulo7_E5(){

        }


    // Programa que muestre la hora del día en formato AM/FM seguida del año, el día y el mes actual.
  
         public void Capitulo8_E3(){
            DateTime hora = DateTime.Now;
            Console.WriteLine("La hora es: " + hora.ToString("h:mm:ss AM/PM"));
            Console.WriteLine(" \n La fecha es: " + hora.ToLongDateString());
        }

    //Programa que le solicite alusuario dos cadenas y luego las muestre en orden alfabético.
         
         public void Capitulo8_E5(){
            char datos;
            string Cadena = Console.ReadLine();
            string Data = Cadena.ToLower();
            char[] letra = Data.ToCharArray();

            for (int i = 1; i < letra.Length; i++)
            {
                for (int j = 0; j < letra.Length - 1; j++)
                {
                    if (letra[j] > letra[j + 1])
                    {
                        datos = letra[j];
                        letra[j] = letra[j + 1];
                        letra[j + 1] = datos;
                    }
                }
            }
            Console.WriteLine(letra);
            Console.ReadLine();
        }
    }
}


