
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
    }
}
