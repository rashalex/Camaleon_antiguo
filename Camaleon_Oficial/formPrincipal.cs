using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;

namespace Presentacion
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Quiere cerrar sesión? ", "Warning",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }
        private void formPrincipal_Load(object sender, EventArgs e)
        {
            LoadUserData();
            if (UserCache.Id_cargo == Cargo.GG)
            {

            }
            
            if (UserCache.Id_cargo == Cargo.GD)
            {
                btn_producto.Enabled = false;
                btn_empleados.Enabled = false;
                btn_anadirCliente.Enabled = false;

            }
            if(UserCache.Id_cargo == Cargo.AS)
            {
                
            }
            if (UserCache.Id_cargo == Cargo.VN)
            {
                btn_producto.Enabled = false;
                //btnproveedores.Enabled = false;

            }


            }
            private void LoadUserData()//se muestra los datos del usuario en menú
        {
            lbl_nom.Text = UserCache.Nombre_emp + " " + UserCache.ApPaterno_emp;
            /*lbl_cargo.Text = UserCache.Id_cargo;
            lbl_usu.Text = UserCache.Usuario_emp;*/
            
        }
      
        private void AbrirFormhijo(object formhijo)//abre contenido de formulario en panel 
        {
            if (this.pnl_contenido.Controls.Count > 0)

                this.pnl_contenido.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnl_contenido.Controls.Add(fh);
            this.pnl_contenido.Tag = fh;
            fh.Show();
        }

        public void AnyMethod()//permisos de usuario
        {
            if (UserCache.Id_cargo == Cargo.GG)
            {

            }
            if (UserCache.Id_cargo == Cargo.GD)
            {

            }
            if (UserCache.Id_cargo == Cargo.AS)
            {

            }
            if (UserCache.Id_cargo == Cargo.VN)
            {

            }
            
        }

        private void panelcontenedor_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btn_perfilUsu_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new formPerfil());
        }

        private void btn_anadirCliente_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new FormRegistroClientes());
        }

        private void pnl_contenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_producto_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new FormProductos());
        }

        private void btn_empleados_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new FormEmpleados());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncargo_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new FormCargo());
        }

        private void btnprov_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new FormProveedor());
        }
    }
}
