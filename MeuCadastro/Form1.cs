using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuCadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancodeDadosDataSet.Pessoas' table. You can move, or remove it, as needed.
            this.pessoasTableAdapter.Fill(this.bancodeDadosDataSet.Pessoas);

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            pessoasBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            pessoasBindingSource.MoveNext();
        }

        private void Deletar_Click(object sender, EventArgs e)
        {
            pessoasBindingSource.RemoveCurrent();
        }

        private void btnNovoRegistro_Click(object sender, EventArgs e)
        {
            pessoasBindingSource.AddNew();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            pessoasBindingSource.EndEdit();
            pessoasTableAdapter.Update(bancodeDadosDataSet);
        }
    }
}
