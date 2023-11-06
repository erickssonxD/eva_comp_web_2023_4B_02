using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Multitienda.Negocio
{
    public class Categoria: IPersistente
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
            catch (Exception ex)
            {
                CommonBC.ModeloMultitienda.Entry(cat).State = System.Data.Entity.EntityState.Detached;
                return false;
            }
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public bool Read()
        {
            throw new NotImplementedException();
        }

        public bool Update()
        {
            throw new NotImplementedException();
        }
    }
}