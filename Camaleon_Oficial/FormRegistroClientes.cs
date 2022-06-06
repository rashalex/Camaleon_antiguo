﻿using System;
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
    public partial class FormRegistroClientes : Form
    {
        CD_cliente objectoCD = new CD_cliente();//instanciar capa 
        private string idClient; //= null;
        private bool editar = false;    
        public FormRegistroClientes()
        {
            InitializeComponent();
        }

        private void dgb_cliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormRegistroClientes_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }
        private void MostrarClientes()
        {
            CD_cliente objectoCD = new CD_cliente();
            dgb_cliente.DataSource = objectoCD.MostrarCliente();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                try
                {
                    objectoCD.InsertarCliente(txt_ci.Text, txt_nom.Text, txt_paterno.Text, txt_materno.Text, txt_cel.Text, txt_direc.Text);

                    MessageBox.Show("Registro de cliente exitoso");
                    MostrarClientes();
                    LimpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo agregar el Cliente por " + ex);
                }
            }
            if (editar == true)
            {
                try
                {
                    objectoCD.EditarCliente(txt_ci.Text, txt_nom.Text, txt_paterno.Text, txt_materno.Text, txt_cel.Text, txt_direc.Text, idClient);
                    MessageBox.Show("Se editó Correctamente");
                    MostrarClientes();
                    LimpiarForm();
                    editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar el Cliente por " + ex);
                }
            }

        }
        private void LimpiarForm()
        {
            txt_ci.Text = "";
            txt_nom.Text = "";
            txt_paterno.Text = "";
            txt_materno.Text = "";
            txt_cel.Text = "";
            txt_direc.Text = "";
            
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (dgb_cliente.SelectedRows.Count > 0)
            {
                editar = true;
                txt_ci.Text = dgb_cliente.CurrentRow.Cells["CI"].Value.ToString();
                txt_nom.Text = dgb_cliente.CurrentRow.Cells["nombre_cli"].Value.ToString();
                txt_paterno.Text = dgb_cliente.CurrentRow.Cells["apPaterno_cli"].Value.ToString();
                txt_materno.Text = dgb_cliente.CurrentRow.Cells["apMaterno_cli"].Value.ToString();
                txt_cel.Text = dgb_cliente.CurrentRow.Cells["celular_cli"].Value.ToString();
                txt_direc.Text = dgb_cliente.CurrentRow.Cells["direccion_cli"].Value.ToString();
                idClient = dgb_cliente.CurrentRow.Cells["id_cliente"].Value.ToString();
                //CIcliente = dgb_cliente.CurrentRow.Cells["CI"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgb_cliente.SelectedRows.Count > 0)
            {
                editar = true;
                idClient = dgb_cliente.CurrentRow.Cells["id_cliente"].Value.ToString();
                try
                {
                    objectoCD.EliminarCliente(idClient);
                    MessageBox.Show("Se eliminó correctamente");
                    MostrarClientes();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("No se pudo eliminar el cliente" + ex);
                }
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void dgb_cliente_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
