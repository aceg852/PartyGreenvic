using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net.Attributes;
namespace PartyGreenvic
{
    public class Empleado
    {
        [PrimaryKey, AutoIncrement]
        public int IDEmpleado { get; set; }
        public string Rut { get; set; }
        public string Nombre { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", IDEmpleado, Rut, Nombre);
        }
    }
}
