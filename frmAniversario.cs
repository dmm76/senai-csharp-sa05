using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFuncionario
{
    public partial class frmAniversario : Form
    {
        public frmAniversario()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbClienteDataSet);

        }

        private void frmAniversario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbClienteDataSet1.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.dbClienteDataSet1.Funcionario);
            // TODO: esta linha de código carrega dados na tabela 'dbClienteDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.dbClienteDataSet.Cliente);

        }
    }
}
