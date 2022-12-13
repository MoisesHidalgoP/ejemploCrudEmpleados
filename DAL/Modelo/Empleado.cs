using System;
using System.Collections.Generic;

namespace DAL.Modelo
{
    public partial class Empleado
    {
        public long Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellidos { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
    }
}
