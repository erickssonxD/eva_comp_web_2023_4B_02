using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Multitienda.Negocio
{
    public class ProductoCollection
    {
        public List<Producto> ReadAll()
        {
            var productos = CommonBC.ModeloMultitienda.Productoes;

            return GenerarListado(productos.ToList());

        }

        private List<Producto> GenerarListado(List<Multitienda.Producto> productosDALC)
        {
            List<Multitienda.Negocio.Producto> productos = new List<Producto>();

            foreach (Multitienda.Producto prod in productosDALC)
            {
                Producto producto = new Producto();
                producto.idProducto = prod.idProducto;
                producto.Nombre = prod.Nombre;
                producto.Descripcion = prod.Descripcion;
                producto.idCategoria = prod.idCategoria;

                productos.Add(producto);
            }

            return productos;
        }
    }
}