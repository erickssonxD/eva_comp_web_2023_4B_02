using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Multitienda.Negocio {
    public class Producto : IPersistente
    {
        public int idProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public int idCategoria { get; set; }
        public Producto()
        {
            this.Init();
        }
        public void Init()
        {
            idProducto = 0;
            Nombre = string.Empty;
            Descripcion = string.Empty;
            idCategoria = 0;
        }
        public bool Create()
        {
            Multitienda.Producto prod = new Multitienda.Producto();
            try
            {
                prod.idProducto = this.idProducto;
                prod.Nombre = this.Nombre;
                prod.Descripcion = this.Descripcion;
                prod.idCategoria = this.idCategoria;

                CommonBC.ModeloMultitienda.Productoes.Add(prod);
                CommonBC.ModeloMultitienda.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                CommonBC.ModeloMultitienda.Entry(prod).State = System.Data.Entity.EntityState.Detached;
                return false;
            }
        }

        public bool Delete()
        {
            try
            {
                Multitienda.Producto productoEliminado = CommonBC.ModeloMultitienda.Productoes.First(prod => prod.idProducto == this.idProducto);

                CommonBC.ModeloMultitienda.Productoes.Remove(productoEliminado);
                CommonBC.ModeloMultitienda.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Read()
        {
            try
            {
                Multitienda.Producto producto = CommonBC.ModeloMultitienda.Productoes.First(prod => prod.idProducto == this.idProducto);
                this.Nombre = producto.Nombre;
                this.Descripcion = producto.Descripcion;
                this.idCategoria = producto.idCategoria;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update()
        {
            try
            {
                Multitienda.Producto productoModificado = CommonBC.ModeloMultitienda.Productoes.First(prod => prod.idProducto == this.idProducto);

                productoModificado.Nombre = this.Nombre;
                productoModificado.Descripcion = this.Descripcion;
                productoModificado.idCategoria = this.idCategoria;

                CommonBC.ModeloMultitienda.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}