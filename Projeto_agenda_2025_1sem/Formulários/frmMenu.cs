using Projeto_agenda_2025_1sem.Formulários;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_agenda_2025_1sem
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroPessoas objCadPessoa = new frmCadastroPessoas();
            objCadPessoa.MdiParent = this;
            objCadPessoa.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void pessoasFiltroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaPessoa objConPessoa = new frmConsultaPessoa();
            objConPessoa.MdiParent = this;
            objConPessoa.Show();
        }

        private void relatórioPessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisualizaListaPessoas objVisualiza = new frmVisualizaListaPessoas();
            objVisualiza.MdiParent = this;
            objVisualiza.Show();
        }
    }
    
}
