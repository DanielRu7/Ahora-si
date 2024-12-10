using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahora_si.clases
{
    public class persona
    {
        public int Id {  get; set; }
        public string? Nombre {  get; set; }
        public string? Cuenta {  get; set; }
        public string? Contrasena {  get; set; }
        public float Monto {  get; set; }
        public bool Admin {  get; set; }
    }
}
