﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// documento representa la factura o boleta  y tiene una cabecera y un detalle

namespace NorthWind.Entity
{
    public class DocumentoBE
    {
        public CabDocumentoBE Cabecera { get; set; }
        public List<ItemBE> Detalle { get; set; }
    }
}
