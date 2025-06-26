using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_agenda_2025_1sem.Formulários
{
    public partial class frmVisualizaListaPessoas : Form
    {
        public frmVisualizaListaPessoas()
        {
            InitializeComponent();
        }

        private void frmVisualizaListaPessoas_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
