using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Multitienda
{
    public partial class Categoria1 : System.Web.UI.Page
    {
        Multitienda.Negocio.Categoria categoriaBLL = new Multitienda.Negocio.Categoria(); // Instantiate the BLL

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarCategorias();
            }
        }
     
        private void CargarCategorias()
        {
            GridViewCategories.DataSource = new Multitienda.Negocio.CategoriaCollection().ReadAll();
            GridViewCategories.DataBind();
        }

        private void CargarUIDesdeBC(Negocio.Categoria cat)
        {
            txtIdCategoria.Text = cat.IdCategoria.ToString();
            txtNombreCategoria.Text = cat.nombre;
        }

        private Multitienda.Negocio.Categoria CargarBCDesdeUI()
        {
            Multitienda.Negocio.Categoria categoria = new Multitienda.Negocio.Categoria();

            if (!string.IsNullOrEmpty(txtIdCategoria.Text))
            {
                categoria.IdCategoria = Convert.ToInt32(txtIdCategoria.Text);
            }

            categoria.nombre = txtNombreCategoria.Text;

            return categoria;
        }


        protected void btnActualizarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                Negocio.Categoria cat = CargarBCDesdeUI();
                if (cat.Update())
                {
                    CargarUIDesdeBC(cat);
                    lblErrorMessage.Text = "La categoria fue actualizada";
                }
                else
                {
                    lblErrorMessage.Text = "La categoria no pudo ser actualizada";

                }
            }
            catch(Exception)
            {
                lblErrorMessage.Text = "Error en el proceso de actualizacion";
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}