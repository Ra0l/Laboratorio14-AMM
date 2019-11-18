using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio11
{
    public class TodoItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public int Dni { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Fechanacimiento { get; set; }
        public bool Done { get; set; }
    }
}
