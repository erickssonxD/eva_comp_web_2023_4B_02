using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Multitienda
{
    public partial class Producto1 : System.Web.UI.Page
    {
        Multitienda.Negocio.Producto productoBLL = new Multitienda.Negocio.Producto(); // Instantiate the BLL

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarProductos();
            }
        }

        private void CargarProductos()
        {
            GridViewProductos.DataSource = new Multitienda.Negocio.ProductoCollection().ReadAll();
            GridViewProductos.DataBind();
        }

        private void CargarUIDesdeBC(Negocio.Producto prod)
        {
            txtIdProducto.Text = prod.idProducto.ToString();
            txtNombreProducto.Text = prod.Nombre;
            txtDescripcion.Text = prod.Descripcion;
            ddlCategoria.Text = prod.idCategoria.ToString();
        }

        private Multitienda.Negocio.Producto CargarBCDesdeUI()
        {
            Multitienda.Negocio.Producto producto = new Multitienda.Negocio.Producto();

            if (!string.IsNullOrEmpty(txtIdProducto.Text))
            {
                producto.idProducto = Convert.ToInt32(txtIdProducto.Text);
            }

            producto.Nombre = txtNombreProducto.Text;
            producto.Descripcion = txtDescripcion.Text;
            producto.idCategoria = Int32.Parse(ddlCategoria.Text);

            return producto;
        }


        protected void btnActualizarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                Negocio.Producto prod = CargarBCDesdeUI();
                if (prod.Update())
                {
                    CargarUIDesdeBC(prod);
                    CargarProductos();
                    lblErrorMessage.Text = "El producto fue actualizado";
                }
                else
                {
                    lblErrorMessage.Text = "El producto no pudo ser actualizado";

                }
            }
            catch (Exception)
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