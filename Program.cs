using System;
using System.IO;
using System.Globalization;

namespace PR3_TODO_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //lista
            listaTareas listaTareas = new listaTareas();

            //Preparacion para integracion de fecha 
            DateTime fechaActual = DateTime.Now;

            CultureInfo culture = new CultureInfo("es-MX");

            string fechaActualAsStr = fechaActual.ToString(culture);


            //menu interactivo

            string opcion = "";

            while (opcion != "9")
            {
                Console.WriteLine(" ");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Escribe el numero de la opción que deseas realizar:");
                Console.WriteLine(" ");
                Console.WriteLine(" 1) Agregar Pendiente/quehacer");
                Console.WriteLine(" 2) Mostrar Pendientes terminados y Pendientes sin terminar");
                Console.WriteLine(" 3) Completar un pendiente");
                Console.WriteLine(" 4) Borrar un Pendiente");
                Console.WriteLine(" 5) Borrar un Pendiente terminado");
                Console.WriteLine(" 6) Exportar lista de Pendientes");
                Console.WriteLine(" 9) Salir");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine(" ");

                opcion = Console.ReadLine();

                //en caso de que no se selecione una opcion indicada

                if (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4" && opcion != "5" && opcion != "6" && opcion != "9")
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine(" ");
                    Console.WriteLine("La opcion seleccionada no es correcta");
                    Console.WriteLine("Porfavor intoduce un numero valido");
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine(" ");

                }

                //Acciones a realizar
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine(" ");
                        Console.WriteLine("Escribe a continuacion el pendiente que deseas agregar a la lista");
                        Console.WriteLine("(la fecha actual se registra automaticamente a el pendiente)");
                        Tareas nota = new Tareas(Console.ReadLine(), fechaActualAsStr);
                        listaTareas.push(nota);
                        Console.WriteLine(" ");
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine(" ");
                        Console.WriteLine("Tu pendiente se ah agregado a la lista!");
                        Console.WriteLine(" ");
                        Console.WriteLine("--------------------------------------");
                        break;
                    case "2":
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine("----Lista de pendientes sin realizar----");
                        Console.WriteLine(" ");
                        listaTareas.mostrar();
                        Console.WriteLine(" ");
                        Console.WriteLine("-----Lista de pendientes realizados-----");
                        Console.WriteLine(" ");
                        listaTareas.mostrarYaHechos();
                        Console.WriteLine(" ");
                        Console.WriteLine("--------------------------------------");
                        break;
                    case "3":
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine(" ");
                        Console.WriteLine("Porfavor escribe a continuacion el numero de la lista en el que se encuentra tu pendiente realizado");
                        Console.WriteLine("(No olvides que el conteo de la liste comienza en el numero 0)");
                        listaTareas.completar();
                        Console.WriteLine(" ");
                        Console.WriteLine("Felicidades por completar tu Pendiente, Tu logro se ah guardado correctamente!");
                        Console.WriteLine(" ");
                        Console.WriteLine("--------------------------------------");
                        break;
                    case "4":
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine("Porfavor escribe a continuacion el numero de la lista en el que se encuentra el pendiente que deseas borrar de la lista");
                        Console.WriteLine("(Recuerda que esta es la lista de Pendientes sin realizar)");
                        Console.WriteLine("(No olvides que el conteo de la liste comienza en el numero 0)");
                        Console.WriteLine(" ");
                        listaTareas.pBorrar();
                        Console.WriteLine(" ");
                        Console.WriteLine("Tu pendiente ah sido borrado, Espero que no te estes salteando tus deberes!");
                        Console.WriteLine(" ");
                        Console.WriteLine("--------------------------------------");
                        break;
                    case "5":
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine("Porfavor escribe a continuacion el numero de la lista en el que se encuentra el pendiente que deseas borrar de la lista");
                        Console.WriteLine("(Recuerda que esta es la lista de Pendientes realizados)");
                        Console.WriteLine("(No olvides que el conteo de la liste comienza en el numero 0)");
                        Console.WriteLine(" ");
                        listaTareas.tBorrar();
                        Console.WriteLine(" ");
                        Console.WriteLine("--------------------------------------");
                        break;
                    case "6":

                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine(" ");
                        Console.WriteLine("Exportanto en Lista_de_pendientes.txt ...");
                        Console.WriteLine(" ");
                        listaTareas.mostrarTxt();
                        Console.WriteLine(" ");
                        Console.WriteLine("Se ah terminado de exportar la lista!");
                        Console.WriteLine(" ");
                        Console.WriteLine("--------------------------------------");
                        break;
                    case "9":
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine(" ");
                        Console.WriteLine("cerrando programa...");
                        Console.WriteLine(" ");
                        Console.WriteLine("--------------------------------------");
                        break;
                }
            }
        }
    }
}
