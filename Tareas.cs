using System;
using System.IO;
using System.Globalization;


namespace PR3_TODO_List
{
    class Tareas
    {
        public string NombreTarea;

        public string fecha;

        public Tareas(string NombreTarea, string fecha)
        {
            this.NombreTarea = NombreTarea;
            this.fecha = fecha;
        }
    }
}