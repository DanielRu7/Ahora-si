﻿using Ahora_si.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahora_si
{
    public partial class ComprarProducto : Form
    {
        producto pro;

        public ComprarProducto()
        {
            InitializeComponent();
        }
        public ComprarProducto(producto pro)
        {
            InitializeComponent();
            this.pro = pro;
        }

    }
}
