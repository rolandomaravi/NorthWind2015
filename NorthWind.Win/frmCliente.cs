﻿
using NorthWind.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWind.Win
{
    public partial class frmCliente : Form
    {
        public event EventHandler<TbClienteBE> OnClienteSeleccionado;

        public frmCliente()
        {
            InitializeComponent();
        }

        List<TbClienteBE> Lista = new List<TbClienteBE>();

        private void frmCliente_Load(object sender, EventArgs e)
        {
            Lista = TbClienteBE.SelectAll();
            TbClientebindingSource.DataSource = Lista;
            dataGridView1.SelectionMode = 
                DataGridViewSelectionMode.FullRowSelect;
        }

        private void AgregarClienteafactura()
        { 
        // agrefgar cliente al formulario
            int i = dataGridView1.CurrentRow.Index;
            int codigocliente = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
       // query en LINQ
            TbClienteBE oCliente = (from item in Lista.ToArray()
                                    where item.CodCliente == codigocliente
                                    select item).Single();
            OnClienteSeleccionado(new object(), oCliente);
            this.Close();
                                              
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // boton agregar
            AgregarClienteafactura();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return)
            {
                AgregarClienteafactura();

            }

        }
    }
}
