using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Multitienda.Negocio
{
    public class CategoriaCollection
    {
        public List<Categoria> ReadAll()
        {
            var categorias = CommonBC.ModeloMultitienda.Categorias;

            return GenerarListado(categorias.ToList());

        }

        private List<Categoria> GenerarListado(List<Multitienda.Categoria> categoriasDALC)
        {
            List<Multitienda.Negocio.Categoria> categorias = new List<Categoria>();

            foreach (Multitienda.Categoria cat in categoriasDALC)
            {
                Categoria categoria = new Categoria();
                categoria.IdCategoria = cat.IdCategoria;
                categoria.nombre = cat.nombre;

                categorias.Add(categoria);
            }

            return categorias;
        }
    }
}