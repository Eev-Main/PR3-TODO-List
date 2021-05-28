using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;

namespace PR3_TODO_List
{
    class listaTareas
    {

        List<Tareas> listaPendientes = new List<Tareas>();

        List<Tareas> listaTerminados = new List<Tareas>();

        public void push(Tareas nota)
        {
            //la parte de arriba del stack es el final de la lista
            this.listaPendientes.Add(nota);
        }

        public void mostrar()
        {
            //lista de pendientes NO termiandos
            for (int i = this.listaPendientes.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(i + ")" + listaPendientes[i].NombreTarea + " " + listaPendientes[i].fecha);
            }

        }
        public void mostrarYaHechos()
        {
            //lista de pendientes terminados
            for (int i = this.listaTerminados.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(i + ")" + listaTerminados[i].NombreTarea + " " + listaTerminados[i].fecha + "[✓]");
            }
        }
        public void completar()
        {
            int pendienteABuscar = Convert.ToInt32(Console.ReadLine());
            Tareas pendienteAMover = listaPendientes[pendienteABuscar];
            listaTerminados.Add(pendienteAMover);
            listaPendientes.RemoveAt(pendienteABuscar);
        }
        public void pBorrar()
        {
            int pendienteAEliminar = Convert.ToInt32(Console.ReadLine());
            listaPendientes.RemoveAt(pendienteAEliminar);
        }
        public void tBorrar()
        {
            int pendienteAEliminar = Convert.ToInt32(Console.ReadLine());
            listaTerminados.RemoveAt(pendienteAEliminar);
        }
        public void mostrarTxt()
        {
            //lista de pendientes NO termiandos
            using (StreamWriter sw = new StreamWriter("Lista_de_pendientes.txt"))
            {
                sw.WriteLine("----------------------------------------");

                sw.WriteLine("----Lista de pendientes sin realizar----");

                for (int i = this.listaPendientes.Count - 1; i >= 0; i--)
                {
                    sw.WriteLine(listaPendientes[i].NombreTarea + " " + listaPendientes[i].fecha);
                    
                }

                sw.WriteLine("----------------------------------------");

                sw.WriteLine("-----Lista de pendientes realizados-----");

                for (int i = this.listaTerminados.Count - 1; i >= 0; i--)
                {
                    sw.WriteLine(listaTerminados[i].NombreTarea + " " + listaTerminados[i].fecha);
                }
            }
        }
    }
}