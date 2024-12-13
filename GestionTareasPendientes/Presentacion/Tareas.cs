using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionTareasPendientes
{
    public partial class frmTareas : Form
    {
        public frmTareas()
        {
            InitializeComponent();
        }

        private void btnAgregar_Tarea_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtCajaTareas.Text))
            {
                lstTodas_Tareas.Items.Add(txtCajaTareas.Text);
                txtCajaTareas.Clear(); 
            }
        }

        private void btnEliminar_Tarea_Click(object sender, EventArgs e)
        {
            if (lstTodas_Tareas.SelectedItem != null)
            {
                lstTodas_Tareas.Items.Remove(lstTodas_Tareas.SelectedItem);
            }
        }
    }
}
