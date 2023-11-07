using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Multitienda.Negocio
{
    public class Categoria : IPersistente
    {
        public int IdCategoria { get; set; }
        public string nombre { get; set; }

        public Categoria()
        {
            this.Init();
        }

        public void Init()
        {
            IdCategoria = 0;
            nombre = string.Empty;
        }
        public bool Create()
        {
            Multitienda.Categoria cat = new Multitienda.Categoria();
            try
            {
                cat.IdCategoria = this.IdCategoria;
                cat.nombre = this.nombre;
                CommonBC.ModeloMultitienda.Categorias.Add(cat);
                CommonBC.ModeloMultitienda.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                CommonBC.ModeloMultitienda.Entry(cat).State = System.Data.Entity.EntityState.Detached;
                return false;
            }
        }

        public bool Delete()
        {
            try
            {
                Multitienda.Categoria categoriaEliminada = CommonBC.ModeloMultitienda.Categorias.First(cat => cat.IdCategoria == this.IdCategoria);

                CommonBC.ModeloMultitienda.Categorias.Remove(categoriaEliminada);
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
                Multitienda.Categoria categoria = CommonBC.ModeloMultitienda.Categorias.First(cat => cat.IdCategoria == this.IdCategoria);
                this.nombre = categoria.nombre;

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
                Multitienda.Categoria categoriaModificada = CommonBC.ModeloMultitienda.Categorias.First(cat => cat.IdCategoria == this.IdCategoria);

                categoriaModificada.nombre = this.nombre;

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