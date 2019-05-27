using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace ConsoleApp1
{
    class Program
    {


        static void Main(string[] args)
        {
            /*
             Declarar la variable palabra
             Pedir al usuario asignar un valor a variable palabra
             Revisar si la palabra se escribe igual al revés
             Si sí
                 Imprimir que si es palíndromo
             Si no
                 Imprimir que no es palíndromo
             */
            Class2 con = new Class2();

            Console.Write("Nombre: ");
            string Nombre= Console.ReadLine();

            Console.Write("Contraseña: ");
            string Contraseña = Console.ReadLine();

            if(con.select1(Nombre, Contraseña))
            {
                Console.Write("Entraste");
                Console.ReadLine();
            }
            else
            {
                Console.Write("No entraste");
                Console.ReadLine();
            }



            //int num1;
            //do
            //{
            //    Console.Write("1.Insertar, 2.Actualizar, 3.Eliminar, 4.Mostrar datos: \n");

            //    num1 = Convert.ToInt32(Console.ReadLine());


            //    if (num1 == 1)
            //    {

            //        Console.Write("escribe el nombre: ");
            //        string nombre = Console.ReadLine();
            //        Console.Write("escribe el Apellido: ");
            //        string Apellido = Console.ReadLine();

            //        if (con.insert(nombre, Apellido))
            //        {
            //            Console.Write("registro guardado");
            //            Console.ReadLine();
            //        }
            //        else
            //        {
            //            Console.Write("registro no guardado");
            //            Console.ReadLine();
            //        }
            //    }
            //    else if (num1 == 2)
            //    {

            //        Console.Write("Ingresa el ID: ");
            //        int ID = Convert.ToInt32(Console.ReadLine());

            //        Console.Write("Reescribe el nombre: ");
            //        string nombre = Console.ReadLine();
            //        Console.Write("Reescribe el Apellido: ");
            //        string apellido = Console.ReadLine();

            //        if (con.update(ID, nombre, apellido))
            //        {
            //            Console.Write("registro actualizadoo");
            //            Console.ReadLine();
            //        }
            //        else
            //        {
            //            Console.Write("registro no encontrado");
            //            Console.ReadLine();
            //        }

            //    }
            //    else if (num1 == 3)
            //    {
            //        Console.Write("Ingresa el ID: ");
            //        int ID = Convert.ToInt32(Console.ReadLine());

            //        if (con.Delete(ID))
            //        {
            //            Console.Write("registro eliminado");
            //            Console.ReadLine();
            //        }
            //        else
            //        {
            //            Console.Write("este registro no existe");
            //            Console.ReadLine();
            //        }


            //    } else if (num1 == 4)
            //    {

            //        DataTable dt = new DataTable();
            //        dt = con.select();
            //        for (int i = 0; i < dt.Rows.Count; i++)
            //        {
            //            for (int j = 0; j < dt.Columns.Count; j++)
            //            {
            //                Console.Write(dt.Rows[i][j]+" ");

            //            }
            //            Console.WriteLine();
            //        }

            //    }
            //    else if(num1!=-1)
            //    {
            //        Console.Write("No entro a nunguna opción");
            //        Console.ReadLine();
            //    }


            //} while (num1!=-1);






            //Console.Write("escribe una palabra: ");
            //string palabra= (Console.ReadLine());
            //string palabraReves = "";

            //for (int i = palabra.Length - 1; i >= 0; i--) 
            //{
            //    palabraReves += palabra[i];
            //}

            //if(palabra == palabraReves)
            //{
            //    Console.WriteLine("Si es palindromo");
            //}
            //else
            //{
            //    Console.WriteLine("no es palindromo");
            //}





            //    string abecedario="abcdefghijklwnopqrstuvwxyz";
            //    Console.Write("Escribe una frase: ");
            //    string palabra = Console.ReadLine();
            //    bool b = false;

            //    for (int i = 0; i < abecedario.Length; i++)
            //    {
            //        if (palabra.Contains(abecedario[i]))
            //        {
            //            b = true;
            //        }
            //        else
            //        {
            //            b = false;
            //            break;
            //        }


            //    }

            //    if (b)
            //    {
            //        Console.Write("si es pangrama");
            //        Console.ReadLine();
            //    }
            //    else
            //    {
            //        Console.Write("no no pangrama");
            //        Console.ReadLine();
            //    }


            //}


























            /*Declarar las variables a, b y c
            Pedir al usuario el valor de a y b
            Elevar a y b al cuadrado a y b
            Sumamos los valores de a y b
            Asignar a la variable c la raíz cuadrada de la suma de a y b
            Imprimir la variable c

            Console.Write("Ingresa el valor de a: ");
            int a = potencia(Convert.ToInt32 (Console.ReadLine()),2);
            Console.Write("Ingresa el valor de b: ");
            int b = potencia(Convert.ToInt32(Console.ReadLine()),2);

            int suma = a + b;
            Console.Write(Math.Sqrt(suma));
            */
















            //int[] numeros = new int[200];

            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    numeros[i] = obj.potencia(i + 1, 2);
            //    Console.WriteLine(numeros[i]);

            //}

            //Console.Write("Escribe un numero: ");
            //Console.Write(obj.factorial(Convert.ToInt32(Console.ReadLine())));

            /*int[] vector1;

            int tam = Convert.ToInt32(Console.ReadLine());
            vector1 = new int[tam];

            for (int i = 0; i < vector1.Length; i++)
            {
                Console.WriteLine(i);
            }*/

            // Console.Read();



            //Console.Write(Math.Pow(5, 8));


            //int[] materias= new int[5];
            //double suma=0;
            //double divicion = 1;

            //for (int i = 0; i < 5; i++)
            //{
            //    materias[i] = Convert.ToInt32(Console.ReadLine());
            //    suma += materias[i];   
            //}
            //divicion = suma / 5;

            //Console.Write(divicion);
            //Console.Read();





        }
    }
}
