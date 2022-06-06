using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
namespace Presentacion
{
    public partial class FormCargo : Form
    {
        CD_Producto objectoCD = new CD_Producto();
        private string idCargo; //= null;
        private bool editar = false;//instanciar capa
        public FormCargo()
        {
            InitializeComponent();
        }

        private void FormCargo_Load(object sender, EventArgs e)
        {
            MostrarCargo();
        }
        private void MostrarCargo()
        {
            CD_Producto objectoCD = new CD_Producto();
            dgv_cargo.DataSource = objectoCD.MostrarProductos();
        }
    }
}
