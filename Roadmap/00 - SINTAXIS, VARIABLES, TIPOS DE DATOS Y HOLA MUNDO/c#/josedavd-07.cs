/*
 * ¿Preparad@ para aprender o repasar el lenguaje de programación que tú quieras?
 * - Recuerda que todas las instrucciones de participación están en el
 *   repositorio de GitHub.
 *
 * Lo primero... ¿Ya has elegido un lenguaje?
 * - No todos son iguales, pero sus fundamentos suelen ser comunes.
 * - Este primer reto te servirá para familiarizarte con la forma de participar
 *   enviando tus propias soluciones.
 *
 * EJERCICIO:
 * - Crea un comentario en el código y coloca la URL del sitio web oficial del
 *   lenguaje de programación que has seleccionado.
 * - Representa las diferentes sintaxis que existen de crear comentarios
 *   en el lenguaje (en una línea, varias...).
 * - Crea una variable (y una constante si el lenguaje lo soporta).
 * - Crea variables representando todos los tipos de datos primitivos
 *   del lenguaje (cadenas de texto, enteros, booleanos...).
 * - Imprime por terminal el texto: "¡Hola, [y el nombre de tu lenguaje]!"
 *
 * ¿Fácil? No te preocupes, recuerda que esta es una ruta de estudio y
 * debemos comenzar por el principio.
 */

 //**************

 //Hola bienvenidos a todos en este fichero dare  la solucion del ejercicio 00
 // en el lenguaje de programación C# espero les sirva a los que estan comenzando con este lenguaje.

 //***************
 
 //primero que todo la documentación oficial del lenguaje de programación C#.

 // https://dotnet.microsoft.com/es-es/languages/csharp  - esto es donde descargamos el framework .net para trabajar con C#.

 // https://learn.microsoft.com/es-es/dotnet/csharp/    - Aca encontramos la dumentacion oficial de C# para cualquier duda.

 //***************

 // Esto es un comentario de una sola linea  y el lenguaje de programacion que ehe escogido es C#.

 /*
    * Esto es un comentario de varias lineas
    * y el lenguaje de programacion que ehe escogido es C#.
    * no te desanimes si todo sale mal a la primera.
    * siguelo intentando todo esfuerzo trae su recompensa.
    * eres capas de hacer lo que creas posible.
*/
 
//******************
// lenguaje seleccionado es C#.
//******************

//******************
// Ahora procedemos al desarrollo de la actividad propuesta del ejercicio 00.
//******************

using System;
using System.Collections.Generic;
using System.Linq;                  //Todas estas son librerias que podemos usar en nuestro programa 
using System.Text;                 // y asi reutilizar codigo ya hecho      
using System.Threading.Tasks;    // Es una buena practica solo dejar las librerias que vas
                                 //para que el programa no se haga pesado y no consuma tanta memoria.
                                 //En este caso solo estamos usando using system pero se dejan las otras para que sepas que existen.

namespace holaMundo   //Este es el nombre del proyecto, podemos usar el que deseemos.
{
    class Program   //Esta es la clase principal llamada program a medida que avances veras que podras crear tus propias clases.
    {
        static void Main(string[] args)   //Este es el metodo principal llamado Main en el podras  ver todo la ejecucion del codigo.
        {
            //Console hace parte de la libreria System
            //WriteLine es un metodo de la clase Console
            //WriteLine es un metodo que imprime en pantalla y hace un salto de linea
            //Write es un metodo que imprime en pantalla pero no hace salto de linea
            //ReadLine es un metodo que lee lo que el usuario ingresa por teclado
            //ReadKey es un metodo que lee la tecla que el usuario presiona y se termina la ejecucion del programa.
            
            Console.WriteLine("Hello, World! C#"); //Este es el mensaje que se mostrara en pantalla
            Console.WriteLine("Hola amigo recuerda este dia de hoy 2 de enero del 2024.");
            Console.WriteLine("seras un experto programador , cree en ti siempre y lo lograras.");

            //************************
            //Ahora vamos a crear una variable y una constante y seguimos continuando con el desarrollo de la actividad.
            //************************
            //Variables en C#
            //Las variables son espacios de memoria que se reservan para almacenar datos.
            //Las variables pueden cambiar su valor durante la ejecucion del programa.
            //Las variables se pueden declarar de la siguiente forma:
            //tipoDeDato nombreDeVariable = valorInicial;
            //Ejemplo:
            
            int numero = 0;  // variable declarada y inicializada con su valor 0 
            string nombre = "Jose David"; // variable creada y inicializada con el valor de Jose David.
            bool esVerdad = true; // variable creada y inicializada con el valor de true.
            double numeroDecimal = 0.0; // variable creada y inicializada con el valor de 0.0.
            float numeroDecimal2 = 0.0f; // variable creada y inicializada con el valor de 0.0f.
            char caracter = 'a'; // variable creada y inicializada con el valor de a.
            int valor1 = 1 , valor2 = 2 , valor3 = 3 ; // asi podemos declarar varias variablesen una sola linea y gastamos menos memoria

            int num1; //variable creada y no inicializada que se le dara el valor luego esto no es muy recomendado.
            num1 = 12; // le dimos el valor a la variable 

            //Constante del numero pi
            const double pi = 3.1416; //Esta es una constante que no se puede modificar su valor.
            const string nombre = "Jose David"; //Esta es una constante que no se puede modificar su valor.
            const int diaNacimiento = 7;

            //**************************
            //Ahora vamos a crear variables de los tipos de datos primitivos del lenguaje.
            //**************************
            //Tipos de datos primitivos en C#
            //Los tipos de datos primitivos son los tipos de datos que vienen por defecto en el lenguaje.
            //Los tipos de datos primitivos son los siguientes:
            //int - representa un numero entero
            //double - representa un numero decimal
            //float - representa un numero decimal
            //char - representa un caracter
            //string - representa una cadena de caracteres
            //bool - representa un valor booleano
            //byte - representa un numero entero
            //short - representa un numero entero
            //long - representa un numero entero
            //uint - representa un numero entero
            //ulong - representa un numero entero
            //ushort - representa un numero entero
            //sbyte - representa un numero entero
            //decimal - representa un numero decimal
            //object - representa un objeto
            //dynamic - representa un tipo de dato dinamico
            //var - representa un tipo de dato dinamico
            //Ejemplo:

            int numero = 0; // variable de tipo entero
            double numeroDecimal = 0.0; // variable de tipo decimal
            float numeroDecimal2 = 0.0f; // variable de tipo decimal
            char caracter = 'a'; // variable de tipo caracter
            string nombre = "Jose David"; // variable de tipo cadena de caracteres
            bool esVerdad = true; // variable de tipo booleano
            byte numeroByte = 0; // variable de tipo entero
            short numeroShort = 0; // variable de tipo entero
            long numeroLong = 0; // variable de tipo entero
            uint numeroUInt = 0; // variable de tipo entero
            ulong numeroULong = 0; // variable de tipo entero
            ushort numeroUShort = 0; // variable de tipo entero
            sbyte numeroSByte = 0; // variable de tipo entero
            decimal numeroDecimal3 = 0.0m; // variable de tipo decimal
            object objeto = new object(); // variable de tipo objeto
            dynamic dinamico = 0; // variable de tipo dinamico

            //***********************
            //Ahora vamos a imprimir por pantalla el texto: "¡Hola, [y el nombre de tu lenguaje]!"  
            //***********************
            //Para imprimir por pantalla en C# se usa el metodo WriteLine de la clase Console.

            Console.WriteLine("¡Hola, C#!"); //Este es el mensaje que se mostrara en pantalla
            Console.WriteLine("¡Hola felicidades si llegastes hasta aca eres una persona genial y sigue creyendo en ti lo lograras.");

            //***********************
            /*
                * Bueno amigos espero les haya gustado mi solucion al ejercicio 00
                *  y sigan aprendiendo cordialmente:
                *  Jose David Carranza Anagrita.
                *  2 de enero del 2024.  
            */
            //***********************
        }
    }
}

