using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// son tipos globales qye se usaran en el proyecto

namespace NorthWind.Entity
{
    public enum eTipoDocumento
    { 
        Nothing,
        Factura,
        Boleta,
        GuiaRemision,
    }

    public enum eEstadoProceso
    { 
        Nothing,
        Error,
        Completado,
    }
}
