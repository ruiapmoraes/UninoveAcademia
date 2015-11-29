using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UninoveAcademia.View
{
    public partial class frmCargo : Form
    {
        public frmCargo()
        {
            InitializeComponent();
        }

        private void cARGOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cARGOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.academiaUninoveDataSet);

        }

        private void frmCargo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'academiaUninoveDataSet.CARGO' table. You can move, or remove it, as needed.
            this.cARGOTableAdapter.Fill(this.academiaUninoveDataSet.CARGO);

        }
    }
}
