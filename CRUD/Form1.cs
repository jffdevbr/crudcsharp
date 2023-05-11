using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class FormCRUD : Form
    {
        public FormCRUD()
        {
            InitializeComponent();
        }

        private void pictureBoxMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My first CRUD \n jffdevbr Developer");
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cRUD_DBDataSet);

        }

        private void FormCRUD_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cRUD_DBDataSet.Table'. Você pode movê-la ou removê-la conforme necessário.
            this.tableTableAdapter.Fill(this.cRUD_DBDataSet.Table);

        }
    }
}
