﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahora_si.clases
{
    public class producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public float Precio { get; set; }
        public int Cantidad { get; set; }

        public string Descripcion { get; set; }
        public  byte[] Imagen {  get; set; }

        public int CantidadCompra { get; set; }

    }
}
