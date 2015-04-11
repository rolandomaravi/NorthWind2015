using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Entity
{
    public class TbProductoBE
    {
        //Creamos las propiedades
        public int CodProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

        //Creamos el constructor
        public TbProductoBE(int codproducto, 
                                        string descripcion, 
                                        decimal precio)
        {
            this.CodProducto = codproducto;
            this.Descripcion = descripcion;
            this.Precio = precio;
        }
        //Creamos metodo Select All
        public static List<TbProductoBE> SelectAll()
        {
            List<TbProductoBE> productos = new List<TbProductoBE>();
            productos.Add(new TbProductoBE(1, "Producto 1", 50));
            productos.Add(new TbProductoBE(2, "Producto 2", 100));
            productos.Add(new TbProductoBE(3, "Producto 3",200));
            productos.Add(new TbProductoBE(4, "Producto 4", 150));
            return productos;
        }
        

    }
}
